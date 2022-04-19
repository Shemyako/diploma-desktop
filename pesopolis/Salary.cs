using System;
using System.Collections;
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
    public partial class Salary : Form
    {
        private Auth_form form;
        private ArrayList lessons = new ArrayList();
        private string[] handlers;
        public Salary(Auth_form form1)
        {
            form = form1;
            InitializeComponent();
        }

        private void get_handlers()
        {
            string address = form.route + "/get/handlers?" + form.after_route;
            MessageBox.Show(address);

            string line = form.send_request(address);
            string[] words = line.Split(new char[] { '~' });

            // Проверка на статус
            switch (words[0])
            {
                // Всё норм
                case "1":
                    bool flag = false;
                    foreach (var item in words)
                    {
                        if (flag)
                        {
                            handlers = item.Split(new char[] { '|' });
                        }
                        flag = true;
                    }
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
                    get_handlers();
                    break;

                case "-1":
                    MessageBox.Show("Вам нужно пройти заново авторизацию");
                    form.Show();
                    this.FormClosing -= Salary_FormClosing;
                    this.Close();
                    break;


            }

            for (int i = 0; i < (handlers.Length - 1); i += 2)
                staff_comboBox.Items.Add(handlers[i] + " " + handlers[i + 1]);
        }

        private void Salary_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.active_forms = 0;
        }

        private void staff_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Тут получаем расписание кинолог на конкретную дату

            string address = form.route + "/get/salary?" + form.after_route;
            if (date_picker.Text == "" || staff_comboBox.Text == "")
                return;
            address += "&id=" + staff_comboBox.SelectedItem.ToString().Split(new char[] { ' ' })[0] + "&date=" + date_picker.Text;
            

            // Отправка запроса
            string line = form.send_request(address);
            string[] words = line.Split(new char[] { '~' });
            // Копируем в список занятия. Этот список позже будет редактирвовать
            //lessons.Clear();
            //lessons.AddRange(words);
            // Проверка на статус
            switch (words[0])
            {
                // Всё норм
                case "1":
                    // Удаляем статус операции
                    //lessons.RemoveAt(0);
                    // Удаляем тотал
                    //total_salary_lbl.Text = "Итого: " + lessons[1].ToString();

                    total_salary_lbl.Text = "Итого: " + words[2].ToString();

                    lessons_list.Items.Clear();
                    if (words[2].ToString() != "0")
                    {
                        //lessons.RemoveAt(1);
                        show_lessons(words[1]);
                    }
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
                    staff_comboBox_SelectedIndexChanged(sender, e);
                    break;

                case "-1":
                    MessageBox.Show("Вам нужно пройти заново авторизацию");
                    form.Show();
                    this.FormClosing -= Salary_FormClosing;
                    this.Close();
                    break;


            }
        }

        private void show_lessons(string to_show)
        {
            // Сортировка и отображение занятий

            

            //var query = from String stri in to_show
            //            orderby stri.Split(new char[] { '|' })[1]
            //            select stri;

            string[] sub_words = to_show.Split(new char[] { '|' });
            for (int i = 0; i < sub_words.Length - 1; i+=4)
            {
                //MessageBox.Show(item);


                ListViewItem item1 = new ListViewItem(sub_words[i]);
                item1.SubItems.Add(sub_words[i + 1]);
                item1.SubItems.Add(sub_words[i + 2]);
                item1.SubItems.Add(sub_words[i + 3]);
                
                lessons_list.Items.Add(item1);




            }

        }

        private void Salary_Shown(object sender, EventArgs e)
        {
            form.Show_menu(panel1);
            get_handlers();
            // Set the view to show details.
            lessons_list.View = View.Details;
            // Select the item and subitems when selection is made.
            lessons_list.FullRowSelect = true;
            // Display grid lines.
            lessons_list.GridLines = true;

            lessons_list.Columns.Add("№", lessons_list.Width / 4, HorizontalAlignment.Left);
            lessons_list.Columns.Add("Дата", lessons_list.Width / 4, HorizontalAlignment.Left);
            lessons_list.Columns.Add("Собака", lessons_list.Width / 4, HorizontalAlignment.Left);
            lessons_list.Columns.Add("Тип занятия", lessons_list.Width / 4, HorizontalAlignment.Left);
        }

        private void date_picker_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                staff_comboBox_SelectedIndexChanged(sender, e);
        }
    }
}
