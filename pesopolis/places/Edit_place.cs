using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pesopolis.places
{
    public partial class Edit_place : Form
    {
        private Auth_form form;
        private string edit_id;
        public Edit_place(Auth_form form1, string[] info = null)
        {
            form = form1;
            InitializeComponent();
            if (info != null)
            {
                address_textbox.Text = info[1];
                name_textbox.Text = info[2];
                if (info[3] == "False")
                    is_actual.Checked = false;
                edit_id = info[0];
            }
        }

        private void save_bttn_Click(object sender, EventArgs e)
        {
            
            string address = form.route + "/new/place?" + form.after_route;

            address += "&address=" + address_textbox.Text + "&name=" + name_textbox.Text + "&actual=" + is_actual.Checked.ToString();

            if (edit_id != null)
                address += "&id=" + edit_id;

            MessageBox.Show(address);

            string line = form.send_request(address);

            string[] words = line.Split(new char[] { '~' });

            // Проверка на статус
            switch (words[0])
            {
                // Всё норм
                case "1":
                    MessageBox.Show("Готово");
                    Show_places form1 = new Show_places(form);
                    form1.Show();
                    this.FormClosing -= Edit_place_FormClosing;
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
                    this.FormClosing -= Edit_place_FormClosing;
                    this.Close();
                    break;


            }

        }

        private void Edit_place_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.active_forms = 0;
        }
    }
}
