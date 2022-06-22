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
    public partial class Show_mails : Form
    {
        Auth_form form;
        string[] ads;
        public Show_mails(Auth_form form1)
        {
            form = form1;
            InitializeComponent();
            //# Настройка listView
            // Set the view to show details.
            cours_list.View = View.Details;
            // Allow the user to rearrange columns.
            cours_list.AllowColumnReorder = true;
            // Select the item and subitems when selection is made.
            cours_list.FullRowSelect = true;
            // Display grid lines.
            cours_list.GridLines = true;
            // Sort the items in the list in ascending order.
            cours_list.Sorting = SortOrder.Ascending;
            cours_list.Columns.Add("№", cours_list.Width / 4, HorizontalAlignment.Left);
            cours_list.Columns.Add("Дата рассылки", cours_list.Width  / 4, HorizontalAlignment.Left);
            cours_list.Columns.Add("Тип рассылки", cours_list.Width / 4, HorizontalAlignment.Left);
            cours_list.Columns.Add("Создатель", cours_list.Width / 4, HorizontalAlignment.Left);
            get_ad();
        }

        private void get_ad()
        {
            string address = form.route + "/get/ad?" + form.after_route;
            //MessageBox.Show(address);

            // Отправка запроса
            string line = form.send_request(address);
            string[] words = line.Split(new char[] { '~' });

            // Проверка на статус
            switch (words[0])
            {
                // Всё норм
                case "1":
                    ads = words;
                    cours_list.Items.Clear();

                    show_ads();

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
                    get_ad();
                    break;

                case "-1":
                    MessageBox.Show("Вам нужно пройти заново авторизацию");
                    form.Show();
                    this.FormClosing -= Show_mails_FormClosing;
                    this.Close();
                    break;


            }
        }

        private void show_ads()
        {
            // Проверка на статус
            switch (ads[0])
            {
                // Всё норм
                case "1":
                    cours_list.Items.Clear();
                    int uncorrect_amount = 0;
                    bool flag = false;
                    foreach (var item in ads)
                    {
                        // Первый пропустится проход, т.к. первое число - статус операции
                        if (flag)
                        {
                            string[] sub_words = item.Split(new char[] { '|' });
                            if (sub_words.Length == 4)
                            {
                                // Create three items and three sets of subitems for each item.
                                ListViewItem item1 = new ListViewItem(sub_words[0], 0);
                                // Place a check mark next to the item.
                                // item1.Checked = true;
                                item1.SubItems.Add(sub_words[1]);
                                item1.SubItems.Add(sub_words[2]);
                                item1.SubItems.Add(sub_words[3]);
                                cours_list.Items.Add(item1);
                            }
                            else
                            {
                                uncorrect_amount += 1;
                            }

                        }
                        flag = true;
                    }
                    // Если были ошибки в значениях
                    if (uncorrect_amount > 0)
                    {
                        MessageBox.Show("Некорректных значений пришло: " + Convert.ToString(uncorrect_amount));
                    }
                    break;

                // Была ошибка
                case "0":
                    MessageBox.Show(ads[1]);
                    break;


            }
        }

        private void Show_mails_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.active_forms = 0;
        }

        private void create_cours_Click(object sender, EventArgs e)
        {
            this.FormClosing -= Show_mails_FormClosing;
            Create_mail_send new_from = new Create_mail_send(form);
            new_from.Show();
            new_from.Location = this.Location;
            this.Close();
            form.active_forms = 1;
        }

        private void Show_mails_Load(object sender, EventArgs e)
        {
            form.Show_menu(panel1);
        }

        private void cours_list_DoubleClick(object sender, EventArgs e)
        {
            //MessageBox.Show(cours_list.SelectedItems[0].SubItems[0].Text);
            string to_send = cours_list.SelectedItems[0].SubItems[0].Text;
            this.FormClosing -= Show_mails_FormClosing;
            Create_mail_send form1 = new Create_mail_send(form, to_send);
            form1.Location = this.Location;
            form1.Show();
            this.Close();
        }
    }
}
