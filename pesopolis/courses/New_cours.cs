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
    public partial class New_cours : Form
    {
        Auth_form form;
        string[] courses;
        public New_cours(Auth_form form1)
        {
            form = form1;
            form.active_forms = 1;
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
            cours_list.Columns.Add("№", cours_list.Width / 5, HorizontalAlignment.Left);
            cours_list.Columns.Add("Название", cours_list.Width / 5, HorizontalAlignment.Left);
            cours_list.Columns.Add("Длина", cours_list.Width / 5, HorizontalAlignment.Left);
            cours_list.Columns.Add("Цена", cours_list.Width / 5, HorizontalAlignment.Left);
            cours_list.Columns.Add("Актуальность", cours_list.Width / 5, HorizontalAlignment.Left);
            get_courses();
        }

        private void show_courses()
        {
            // Проверка на статус
            switch (courses[0])
            {
                // Всё норм
                case "1":
                    cours_list.Items.Clear();
                    int uncorrect_amount = 0;
                    bool flag = false;
                    foreach (var item in courses)
                    {
                        // Первый пропустится проход, т.к. первое число - статус операции
                        if (flag)
                        {
                            string[] sub_words = item.Split(new char[] { '|' });
                            if (sub_words.Length == 5)
                            {
                                if (is_actual_box.Checked && sub_words[4] == "False")
                                    continue;
                                // Create three items and three sets of subitems for each item.
                                ListViewItem item1 = new ListViewItem(sub_words[0], 0);
                                // Place a check mark next to the item.
                                // item1.Checked = true;
                                item1.SubItems.Add(sub_words[1]);
                                item1.SubItems.Add(sub_words[2]);
                                item1.SubItems.Add(sub_words[3]);
                                item1.SubItems.Add(sub_words[4]);
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
                    MessageBox.Show(courses[1]);
                    break;


            }
        }

        private void get_courses()
        {
            string address = form.route + "/get/courses?" + form.after_route;
            MessageBox.Show(address);

            // Отправка запроса
            string line = form.send_request(address);
            string[] words = line.Split(new char[] { '~' });

            // Проверка на статус
            switch (words[0])
            {
                // Всё норм
                case "1":
                    courses = words;
                    cours_list.Items.Clear();

                    show_courses();

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
                    get_courses();
                    break;

                case "-1":
                    MessageBox.Show("Вам нужно пройти заново авторизацию");
                    form.Show();
                    this.FormClosing -= New_cours_FormClosing;
                    this.Close();
                    break;


            }
        }

        private void New_cours_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.active_forms = 0;
        }

        private void create_cours_Click(object sender, EventArgs e)
        {
            Create_new_cours new_form = new Create_new_cours(form);
            new_form.Show();
            this.FormClosing -= New_cours_FormClosing;
            this.Close();
        }

        private void is_actual_box_CheckedChanged(object sender, EventArgs e)
        {
            show_courses();
        }

        private void cours_list_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show(cours_list.SelectedItems[0].SubItems[0].Text);
            string[] to_send = new string[5];
            for (int i = 0; i < 5; i++)
            {
                to_send[i] = cours_list.SelectedItems[0].SubItems[i].Text;
            }
            this.FormClosing -= New_cours_FormClosing;
            Create_new_cours form1 = new Create_new_cours(form, to_send);
            form1.Show();
            this.Close();
        }

        private void New_cours_Load(object sender, EventArgs e)
        {
            form.Show_menu(panel1);
        }
    }
}
