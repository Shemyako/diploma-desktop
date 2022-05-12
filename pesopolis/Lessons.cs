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
    public partial class Lessons : Form
    {
        private Auth_form form;
        private string[] dogs;
        private string[] handlers;
        private string[] type_of_lesson;
        private string[] places;
        private ArrayList lessons_te_edit = new ArrayList();
        private ArrayList lessons = new ArrayList();

        public Lessons(Auth_form form1)
        {
            form = form1;
            InitializeComponent();
            
        }


        // Получение информации
        private void get_pre_lesson()
        {
            // Нужно получить всех
            // кинологов
            // Собак
            // Типы занятий
            // Площадки
            string address = form.route + "/get/pre_lesson?" + form.after_route;
            //address += "&id=" + id;
            MessageBox.Show(address);

            // Отправка запроса
            string line = form.send_request(address);
            string[] words = line.Split(new char[] { '~' });

            // Проверка на статус
            switch (words[0])
            {
                // Всё норм
                case "1":
                    int uncorrect_amount = 0;
                    bool flag = false;
                    foreach (var item in words)
                    {
                        // uncorrect_amount => 0 - кинолог; 1 - собаки; 2-типы занятий; 3-площадки
                        if (flag)
                        {
                            if (uncorrect_amount == 0)
                                handlers = item.Split(new char[] { '|' });
                            else if (uncorrect_amount == 1)
                                dogs = item.Split(new char[] { '|' });
                            else if (uncorrect_amount == 2)
                                type_of_lesson = item.Split(new char[] { '|' });
                            else if (uncorrect_amount == 3)
                                places = item.Split(new char[] { '|' });


                            uncorrect_amount += 1;
                            

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
                    get_pre_lesson();
                    break;

                case "-1":
                    MessageBox.Show("Вам нужно пройти заново авторизацию");
                    form.Show();
                    this.FormClosing -= Lessons_FormClosing;
                    this.Close();
                    break;


            }
            // Тут отобразим place combobox, type_of_lesson и staff
            for (int i = 0; i < (places.Length - 1); i += 2)
                place_combobox.Items.Add(places[i] + " " + places[i+1]);
            place_combobox.SelectedIndex = 0;

            for (int i = 0; i < (type_of_lesson.Length - 1); i += 2)
                type_of_lesson_combobox.Items.Add(type_of_lesson[i] + " " + type_of_lesson[i + 1]);
            type_of_lesson_combobox.SelectedIndex = 0;

            for (int i = 0; i < (handlers.Length - 1); i += 2)
                staff_comboBox.Items.Add(handlers[i] + " " + handlers[i + 1]);
            staff_comboBox.SelectedIndex = 0;

        }

        private void Lessons_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.active_forms = 0;
        }

        private void show_lessons(ArrayList to_show)
        {
            // Сортировка и отображение занятий
            
            lessons_list.Items.Clear();
                    
            var query = from String stri in to_show
                        orderby stri.Split(new char[] { '|' })[1]
                        select stri;
            foreach (var item in query)
            {
                //MessageBox.Show(item);
                        
                string[] sub_words = item.ToString().Split(new char[] { '|' });

                ListViewItem item1 = new ListViewItem(sub_words[0]);
                item1.SubItems.Add(sub_words[1]);
                item1.SubItems.Add(sub_words[2]);
                item1.SubItems.Add(sub_words[3]);
                item1.SubItems.Add(sub_words[4]);
                item1.SubItems.Add(sub_words[5]);
                // Узнаём количество занятий для каждой собаки из имеющихся записей (query)
                for (int i = 0; i < (dogs.Length - 1); i += 8)
                {

                    if (dogs[i] + " " + dogs[i + 1] != sub_words[2])
                        continue;

                    
                    item1.SubItems.Add(dogs[i + 6] + "/" + dogs[i + 7]);

                    break;


                }
                lessons_list.Items.Add(item1);



                        
            }
                    
        }

        private void staff_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Тут получаем расписание кинолог на конкретную дату

            string address = form.route + "/get/schedule?" + form.after_route;
            address += "&id=" + staff_comboBox.SelectedItem.ToString().Split(new char[] { ' ' })[0] + "&date=" + date_picker.Text;
            if (date_picker.Text == "")
                return;
            



            // Отправка запроса
            string line = form.send_request(address);
            string[] words = line.Split(new char[] { '~' });
            lessons.Clear();
            lessons.AddRange(words);
            // Проверка на статус
            switch (words[0])
            {
                // Всё норм
                case "1":
                    // Удаляем статус операции
                    lessons.RemoveAt(0);
                    // Копируем в список занятия. Этот список позже будет редактирвовать
                    lessons_te_edit.Clear();
                    lessons_te_edit.AddRange(lessons);
                    show_lessons(lessons);
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
                    this.FormClosing -= Lessons_FormClosing;
                    this.Close();
                    break;


            }
        }

        private void lessons_list_DoubleClick(object sender, EventArgs e)
        {
            string query = (from String stri in lessons_te_edit
                        where stri.Split(new char[] { '|' })[1] == lessons_list.SelectedItems[0].SubItems[1].Text 
                            && stri.Split(new char[] { '|' })[2] == lessons_list.SelectedItems[0].SubItems[2].Text
                        select stri).ToList()[0];
            MessageBox.Show(query);

            lessons_te_edit.Remove(query);
            // Удалим запись после двойного нажатия. Нужно переспросить перед удалением
            show_lessons(lessons_te_edit);
        }

        // Изменение чекбокса. Собаки кинолога ли. Отображение собак
        private void is_actual_box_CheckedChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(staff_comboBox.Text.Substring(0, staff_comboBox.Text.IndexOf(' ')));
            dogs_list.Items.Clear();
            for (int i = 0; i < (dogs.Length - 1); i += 8) 
            { 

                if (is_actual_box.Checked && dogs[i+3] != staff_comboBox.Text.Substring(0, staff_comboBox.Text.IndexOf(' ')))
                    continue;
                ListViewItem item1 = new ListViewItem(dogs[i], 0);
                item1.SubItems.Add(dogs[i + 1]);
                item1.SubItems.Add(dogs[i + 2]);
                item1.SubItems.Add(dogs[i + 5]);
                item1.SubItems.Add(dogs[i + 6] + "/" + dogs[i + 7]);

                dogs_list.Items.Add(item1);


            }
        }

        private void Lessons_Shown(object sender, EventArgs e)
        {
            get_pre_lesson();
            // Set the view to show details.
            lessons_list.View = View.Details;
            dogs_list.View = View.Details;
            // Select the item and subitems when selection is made.
            lessons_list.FullRowSelect = true;
            dogs_list.FullRowSelect = true;
            // Display grid lines.
            lessons_list.GridLines = true;
            dogs_list.GridLines = true;

            lessons_list.Columns.Add("№", lessons_list.Width / 7, HorizontalAlignment.Left);
            lessons_list.Columns.Add("Дата", lessons_list.Width / 7, HorizontalAlignment.Left);
            lessons_list.Columns.Add("Собака", lessons_list.Width / 7, HorizontalAlignment.Left);
            lessons_list.Columns.Add("Тип занятия", lessons_list.Width / 7, HorizontalAlignment.Left);
            lessons_list.Columns.Add("Площадка", lessons_list.Width / 7, HorizontalAlignment.Center);
            lessons_list.Columns.Add("Телефон", lessons_list.Width / 7, HorizontalAlignment.Center);
            lessons_list.Columns.Add("Занятий", lessons_list.Width / 7, HorizontalAlignment.Center);

            dogs_list.Columns.Add("№", dogs_list.Width / 10, HorizontalAlignment.Left);
            dogs_list.Columns.Add("Кличка", dogs_list.Width * 2 / 10, HorizontalAlignment.Left);
            dogs_list.Columns.Add("Порода", dogs_list.Width * 2 / 10, HorizontalAlignment.Left);
            dogs_list.Columns.Add("Телефон хозяина", dogs_list.Width * 3 / 10, HorizontalAlignment.Left);
            dogs_list.Columns.Add("Занятий", dogs_list.Width * 2 / 10, HorizontalAlignment.Left);

            is_actual_box.Checked = true;
        }

        private void dogs_list_DoubleClick(object sender, EventArgs e)
        {
            for (int i = 0; i<dogs.Length-1; i += 6) 
                if (dogs_list.SelectedItems[0].SubItems[0].Text == dogs[i])
                {
                    place_combobox.Text = dogs[i + 4];
                    break;
                }
                    

        }


        private void add_to_list_bttn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < (dogs.Length - 1); i += 8)
            {
                if (dogs[i] == dogs_list.SelectedItems[0].SubItems[0].Text)
                {
                    string to_add = "-1|" + lesson_time.Text + "|" + dogs[i] + " " + dogs[i + 1] +
                        "|" + type_of_lesson_combobox.Text + "|" + dogs[i + 4] + "|" + dogs[i + 5];

                    // MessageBox.Show(to_add);
                    lessons_te_edit.Add(to_add);
                    show_lessons(lessons_te_edit);
                    break;
                }
            }

        }

        private void cancel_bttn_Click(object sender, EventArgs e)
        {
            lessons_te_edit.Clear();
            lessons_te_edit.AddRange(lessons);
            show_lessons(lessons);            
        }

        private void save_bttn_Click(object sender, EventArgs e)
        {
            string address = form.route + "/edit/schedule?" + form.after_route;
            address += "&args=";
            foreach (ListViewItem item in lessons_list.Items)
            {
                address += item.SubItems[1].Text + " " + date_picker.Text + "|" +
                    item.SubItems[2].Text.Split(new char[] { ' ' })[0] + "|" +
                    item.SubItems[4].Text.Split(new char[] { ' ' })[0] + "|" +
                    item.SubItems[3].Text.Split(new char[] { ' ' })[0] + "|" +
                    staff_comboBox.Text.Split(new char[] { ' ' })[0] + "|"; 
            }

            MessageBox.Show(address);

            // Отправка запроса
            string line = form.send_request(address);
            string[] words = line.Split(new char[] { '~' });

            // Проверка на статус
            switch (words[0])
            {
                // Всё норм
                case "1":
                    MessageBox.Show("Готово");
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
                    this.FormClosing -= Lessons_FormClosing;
                    this.Close();
                    break;


            }
            staff_comboBox_SelectedIndexChanged(sender, e);
        }

        private void date_picker_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                staff_comboBox_SelectedIndexChanged(sender, e);
        }

        private void Lessons_Load(object sender, EventArgs e)
        {
            form.Show_menu(panel1);
        }
    }
}
