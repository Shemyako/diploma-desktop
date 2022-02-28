using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pesopolis
{
    public partial class Create_new_cours : Form
    {
        private Auth_form form;
        public Create_new_cours(Auth_form form1)
        {
            form = form1;
            InitializeComponent();
        }

        private void save_bttn_Click(object sender, EventArgs e)
        {
            // Проверка на дурака
            foreach (var item in amount_textbox.Text)
            {
                if (!char.IsDigit(item))
                {
                    MessageBox.Show("Введите корректное количество занятий");
                    return; //если хоть один символ не число, то выкидываешь "ложь"
                }
            }

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

            string address = form.route + "/new/cours?" + form.after_route;

            address += "&name=" + name_textbox.Text + "&amount=" + amount_textbox.Text + "&price=" + price_textbox.Text;
            MessageBox.Show(address);

            string line = form.send_request(address);

            string[] words = line.Split(new char[] { '~' });

            // Проверка на статус
            switch (words[0])
            {
                // Всё норм
                case "1":
                    MessageBox.Show("Готово");
                    New_cours form1 = new New_cours(form);
                    form1.Show();
                    this.FormClosing -= Create_new_cours_FormClosing;
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
                    this.FormClosing -= Create_new_cours_FormClosing;
                    this.Close();
                    break;


            }

        }

        private void Create_new_cours_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.active_forms = 0;
        }
    }
}
