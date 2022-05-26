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
    public partial class Create_mail_send : Form
    {
        private Auth_form form;
        private string id = null;
        public Create_mail_send(Auth_form form1, string id1 = null)
        {
            form = form1;
            
            InitializeComponent();
            if (id1 != null)
            {
                id = id1;
                get_advertisement();
            }
        }

        private void get_advertisement()
        {
            string address = form.route + "/get/advertisement?id=" + id + "&" + form.after_route;
            MessageBox.Show(address);

            // Отправка запроса
            string line = form.send_request(address);
            string[] words = line.Split(new char[] { '~' });
            // Проверка на статус
            switch (words[0])
            {
                // Всё норм
                case "1":
                    if (words.Length != 5)
                    {
                        MessageBox.Show("Пришли некорректные значения");
                        return;
                    }
                    dateTimePicker1.Text = words[2];

                    if (words[3] == "1")
                        send_to_chckBx.SelectedIndex = 1;
                    else if (words[3] == "2")
                        send_to_chckBx.SelectedIndex = 2;

                    textBox1.Text = words[4];

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
                    get_advertisement();
                    break;

                case "-1":
                    MessageBox.Show("Вам нужно пройти заново авторизацию");
                    form.Show();
                    this.FormClosing -= Create_mail_send_FormClosing;
                    this.Close();
                    break;


            }
        }

        private void Create_mail_send_Load(object sender, EventArgs e)
        {
            form.Show_menu(panel1);

        }

        private void create_bttn_Click(object sender, EventArgs e)
        {
            if (send_to_chckBx.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите корректный способ отправки");
                return;
            }
            string address = form.route + "/new/ad?" + form.after_route;

            string send_to = send_to_chckBx.SelectedIndex.ToString();


            address += "&text=" + textBox1.Text + "&date=" + dateTimePicker1.Text + "&send_to=" + send_to + 
                    "&created_by=" + form.login;
            if (id != null)
                address += "&id=" + id;

            // Отправка запроса
            string line = form.send_request(address);
            string[] words = line.Split(new char[] { '~' });
            // Проверка на статус
            switch (words[0])
            {
                // Всё норм
                case "1":
                    MessageBox.Show("Успешно");
                    //MessageBox.Show(words[1]);
                    Show_mails form1 = new Show_mails(form);
                    // this.FormClosing -= New_dog_FormClosing;
                    form1.Show();
                    form1.Location = this.Location;
                    this.FormClosing -= Create_mail_send_FormClosing;
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
                    create_bttn_Click(sender, e);
                    break;

                case "-1":
                    MessageBox.Show("Вам нужно пройти заново авторизацию");
                    form.Show();
                    this.FormClosing -= Create_mail_send_FormClosing;
                    this.Close();
                    break;


            }
        }

        private void Create_mail_send_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.active_forms = 0;
        }

        private void back_bttn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите выйти? Данные не сохранятся", "Выход", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;
            Show_mails form1 = new Show_mails(form);
            // this.FormClosing -= New_dog_FormClosing;
            form1.Show();
            form1.Location = this.Location;
            this.FormClosing -= Create_mail_send_FormClosing;
            this.Close();
        }
    }
}
