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
            if (name_textbox.Text == "" || phone_textbox.Text == "" || email_textbox.Text == "" ||
                name_textbox.Text == "Имя" || phone_textbox.Text == "Телефон" || email_textbox.Text == "e-mail")
            {
                MessageBox.Show("Заполните поля корректно");
                return;
            }

            // Проверка на вводимый телефон
            foreach (var item in phone_textbox.Text)
            {
                if (!char.IsDigit(item))
                {
                    MessageBox.Show("Введите номер не через +7");
                    return; //если хоть один символ не число, то выкидываешь "ложь"
                }
            }

            // Заполнение None пустые поля
            if (tg_id_textbox.Text == "" || tg_id_textbox.Text == "tg_id")
                tg_id_textbox.Text = "Null";
            // Null в д.р.
            if (!birth_picker.Checked)
                birth = "Null";
            // Кинолог ли
            if (is_handler.Checked)
                role = "1";
            else if (is_admin.Checked && form.role == "3")
                role = "2";

            // Запрос на проверку логина и пароля
            // route - ip на который дклвть запрос
            // after_route - передача login,token, mac 
            
            string address = form.route + "/new/client?" + form.after_route;
            
            address += "&name=" + name_textbox.Text + "&phone=" + phone_textbox.Text + "&birth=" + birth + 
                "&tg_id=" + tg_id_textbox.Text + "&email=" + email_textbox.Text + "&role=" + role;
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
                password.Enabled = true;
            else
                password.Enabled = false;
        }
    }
}
