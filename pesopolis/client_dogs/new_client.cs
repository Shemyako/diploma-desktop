using System;
using System.Windows.Forms;

namespace pesopolis
{
    public partial class New_client : Form
    {
        private Auth_form form;
        public New_client(Auth_form form1)
        {
            
            form = form1;
            form.active_forms = 1;
            InitializeComponent();
            if (form.role == "3")
            {
                is_admin.Visible = true;
                is_admin.Enabled = true;
                password.Visible = true;
                login_lbl.Visible = true;
            }
                
        }

        private void New_client_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Application.Exit();
            form.active_forms = 0;
        }
        
        // Отправка и создание нового пользователя
        private void save_bttn_Click(object sender, EventArgs e)
        {
            string birth = birth_picker.Text;
            string role = "0";
            // Проверка на дуркака
            if (name_textbox.Text == "" || phone_textbox.Text == "" ||
                name_textbox.Text == "Имя" || phone_textbox.Text == "Телефон")
            {
                MessageBox.Show("Заполните поля корректно");
                return;
            }

            // Проверка на вводимый телефон
            foreach (var item in phone_textbox.Text)
            {
                if (!char.IsDigit(item))
                {
                    MessageBox.Show("Введите номер не через 8");
                    return; //если хоть один символ не число, то выкидываешь "ложь"
                }
            }


            string tg_id;
            // Заполнение None пустые поля
            if (tg_id_textbox.Text == "" || tg_id_textbox.Text == "tg_id" || email_textbox.Text == "None")
                tg_id = "Null";
            else
            {
                // Проверка на вводимый tg id
                foreach (var item in tg_id_textbox.Text)
                {
                    if (!char.IsDigit(item))
                    {
                        tg_id = "Null";
                        MessageBox.Show("Введите корректный tg id");
                        return; //если хоть один символ не число, то выкидываешь "ложь"
                    }
                }
                tg_id = tg_id_textbox.Text;
            }

            // Null в д.р.
            if (!birth_picker.Checked)
                birth = "Null";
            // Кинолог ли
            if (is_handler.Checked)
                role = "1";
            else if (is_admin.Checked && form.role == "3")
                role = "2";
            // Null ли в почте
            string mail;
            if (email_textbox.Text == "" || email_textbox.Text == "e-mail" || email_textbox.Text == "None")
                mail = "Null";
            else
                mail = email_textbox.Text;

            // Запрос на проверку логина и пароля
            // route - ip на который дклвть запрос
            // after_route - передача login,token, mac 
            
            string address = form.route + "/new/client?" + form.after_route;
            
            address += "&name=" + name_textbox.Text + "&phone=" + phone_textbox.Text + "&birth=" + birth + 
                "&tg_id=" + tg_id + "&email=" + mail + "&role=" + role;
            // MessageBox.Show(address);
            if (role == "2")
                address += "&password=" + password.Text;

            // Отправка запроса
            string line = form.send_request(address);
            
            string[] words = line.Split(new char[] { '~' });

            switch (words[0])
            {
                // Нужно заново зайти
                case "-1":
                    MessageBox.Show("Вам нужно пройти заново авторизацию");
                    form.Show();
                    this.Close();
                    break;
                
                // Всё хорошо
                case "1": 
                    MessageBox.Show("Успешно");
                    if (role == "2")
                        login_lbl.Text = "Логин: " + words[1];
                    break;

                // Реавторизация и обновление токена
                case "3":
                    form.Change_token(words[1]);
                    // Повторная отправка сообщения
                    save_bttn_Click(sender, e);
                    break;

                // Ошибка
                case "0":
                    MessageBox.Show("Произошла ошибка. Проверьте соединение и повторите позже");
                    break;
            }
            
            
        }

        private void New_client_Load(object sender, EventArgs e)
        {
            form.Show_menu(panel1);
        }

        private void is_admin_CheckedChanged(object sender, EventArgs e)
        {
            if (is_admin.Checked)
            {
                password.Enabled = true;
                is_handler.Checked = false;
            }
            else
                password.Enabled = false;
        }

        private void is_handler_CheckedChanged(object sender, EventArgs e)
        {
            if (is_handler.Checked)
                is_admin.Checked = false;
        }
    }
}
