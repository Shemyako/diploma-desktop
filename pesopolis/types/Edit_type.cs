using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pesopolis.types
{
    public partial class Edit_type : Form
    {
        private Auth_form form;
        private string edit_id;
        public Edit_type(Auth_form form1, string[] info = null)
        {
            form = form1;
            InitializeComponent();
            if (info != null)
            {
                name_textbox.Text = info[1];
                amount_textbox.Text = info[2];
                price_textbox.Text = info[3];
                if (info[4] == "False")
                    is_actual.Checked = false;
                edit_id = info[0];
            }
        }

        private void back_bttn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите выйти? Данные не сохранятся", "Выход", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;
            Show_types form1 = new Show_types(form);
            // this.FormClosing -= New_dog_FormClosing;
            form1.Show();
            form1.Location = this.Location;
            this.FormClosing -= Edit_type_FormClosing;
            this.Close();
        }

        private void Edit_type_Load(object sender, EventArgs e)
        {
            form.Show_menu(panel1);
        }

        private void Edit_type_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.active_forms = 0;
        }

        private void save_bttn_Click(object sender, EventArgs e)
        {
            // Проверка цены
            price_textbox.Text = price_textbox.Text.Replace(" ", "");
            price_textbox.Text = price_textbox.Text.Replace(".", ",");
            // Проверка на дурака
            try
            {
                Convert.ToDouble(price_textbox.Text);
            }
            catch
            {
                MessageBox.Show("Введите корректную цену");
                return; //если хоть один символ не число, то выкидываешь "ложь"
            }

            price_textbox.Text = price_textbox.Text.Replace(",", ".");

            // Проверка цены
            amount_textbox.Text = amount_textbox.Text.Replace(" ", "");
            amount_textbox.Text = amount_textbox.Text.Replace(".", ",");
            // Проверка на дурака
            try
            {
                Convert.ToDouble(amount_textbox.Text);
            }
            catch
            {
                MessageBox.Show("Введите корректную цену");
                return; //если хоть один символ не число, то выкидываешь "ложь"
            }

            amount_textbox.Text = amount_textbox.Text.Replace(",", ".");

            string address = form.route + "/new/type?" + form.after_route;

            address += "&name=" + name_textbox.Text + "&amount=" + amount_textbox.Text + "&price=" + price_textbox.Text + "&actual=" + is_actual.Checked.ToString();

            if (edit_id != null)
                address += "&id=" + edit_id;

            //MessageBox.Show(address);

            string line = form.send_request(address);

            string[] words = line.Split(new char[] { '~' });

            // Проверка на статус
            switch (words[0])
            {
                // Всё норм
                case "1":
                    MessageBox.Show("Готово");
                    Show_types form1 = new Show_types(form);
                    form1.Location = this.Location;
                    form1.Show();
                    this.FormClosing -= Edit_type_FormClosing;
                    this.Close();
                    break;

                // Была ошибка
                case "0":
                    MessageBox.Show(words[1]);
                    break;

                // Реавторизация
                case "3":
                    // Обновление токена
                    form.Change_token(words[1]);
                    // Повторная отправка сообщения
                    save_bttn_Click(sender, e);
                    break;

                case "-1":
                    MessageBox.Show("Вам нужно пройти заново авторизацию");
                    form.Show();
                    this.FormClosing -= Edit_type_FormClosing;
                    this.Close();
                    break;


            }
        }
    }
}
