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
    public partial class Show_types : Form
    {
        Auth_form form;
        string[] courses;
        public Show_types(Auth_form form1)
        {
            form = form1;
            form.active_forms = 1;
            InitializeComponent();
            //# Настройка listView
            // Set the view to show details.
            types_list.View = View.Details;
            // Allow the user to rearrange columns.
            types_list.AllowColumnReorder = true;
            // Select the item and subitems when selection is made.
            types_list.FullRowSelect = true;
            // Display grid lines.
            types_list.GridLines = true;
            // Sort the items in the list in ascending order.
            types_list.Sorting = SortOrder.Ascending;
            types_list.Columns.Add("№", types_list.Width / 6, HorizontalAlignment.Left);
            types_list.Columns.Add("Название", types_list.Width * 2 / 6, HorizontalAlignment.Left);
            types_list.Columns.Add("С клиента", types_list.Width / 6, HorizontalAlignment.Left);
            types_list.Columns.Add("Инструктору", types_list.Width / 6, HorizontalAlignment.Left);
            types_list.Columns.Add("Актуально", types_list.Width / 6, HorizontalAlignment.Left);
            get_types();
        }

        private void get_types()
        {
            string address = form.route + "/get/types?" + form.after_route;
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
                    types_list.Items.Clear();

                    show_types();

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
                    get_types();
                    break;

                case "-1":
                    MessageBox.Show("Вам нужно пройти заново авторизацию");
                    form.Show();
                    this.FormClosing -= Show_types_FormClosing;
                    this.Close();
                    break;


            }
        }

        private void show_types()
        {
            // Проверка на статус
            switch (courses[0])
            {
                // Всё норм
                case "1":
                    types_list.Items.Clear();
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
                                types_list.Items.Add(item1);
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

        private void Show_types_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.active_forms = 0;
        }

        private void Show_types_Load(object sender, EventArgs e)
        {
            form.Show_menu(panel1);
        }
    }
}
