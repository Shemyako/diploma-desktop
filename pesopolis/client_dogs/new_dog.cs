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
    public partial class New_dog : Form
    {
        Auth_form form;
        string[] to_be_back;
        string id;
        string dog_id;
        // id пользователей для проверки на добавление существующего пользователя
        ArrayList owner_ids;
        // Список с полученными владельцами
        string[] words;
        // Список с курсами
        string[] courses;
        public New_dog(Auth_form form1, string usr_id, string dog_id1 = null, string[] name1 = null)
        {
            
            to_be_back = name1;
            id = usr_id;
            form = form1;
            form.active_forms = 1;
            owner_ids = new ArrayList();
            InitializeComponent();

            // Если редактирование собаки
            if (dog_id1 != null)
            {
                dog_id = dog_id1;
                change_mod_bttn.Enabled = true;
                get_owners();
                show_owners();
            }

            get_info();
            get_courses();
            // Set the view to show details.
            dogs_list.View = View.Details;
            // Allow the user to rearrange columns.
            dogs_list.AllowColumnReorder = true;
            // Select the item and subitems when selection is made.
            dogs_list.FullRowSelect = true;
            // Display grid lines.
            dogs_list.GridLines = true;
            // Sort the items in the list in ascending order.
            dogs_list.Sorting = SortOrder.Ascending;

            // Create columns for the items and subitems.
            // Width of -2 indicates auto-size.
            
        }

        // pre_dogs
        private void get_info()
        {
            cours_comboBox.Items.Clear();
            place_comboBox.Items.Clear();
            staff_comboBox.Items.Clear();
            string address = form.route + "/get/pre_dogs?" + form.after_route;
            // MessageBox.Show(address);
            if (dog_id != null)
                address += "&dog_id=" + dog_id;
            // Отправка запроса
            string line = form.send_request(address);
            ArrayList words = new ArrayList();
            words.AddRange( line.Split(new char[] { '~' }));

            // Проверка на статус
            switch (words[0])
            {
                // Всё норм
                case "1":
                    int sub = 0;
                    bool flag = false;
                    foreach (string item in words)
                    {
                        // Первый пропустится проход, т.к. первое число - статус операции
                        if (flag)
                        {
                            string[] sub_words = item.Split(new char[] { '|' });
                            
                            
                            switch (sub)
                            {
                                case 1:
                                    cours_comboBox.Items.AddRange(sub_words);
                                    break;
                                case 2:
                                    place_comboBox.Items.AddRange(sub_words);
                                    break;
                                case 3:
                                    staff_comboBox.Items.AddRange(sub_words);
                                    break;
                            }
                            

                        }
                        flag = true;
                        sub++;
                    }
                    cours_comboBox.Items.RemoveAt(0);
                    place_comboBox.Items.RemoveAt(0);
                    cours_comboBox.SelectedIndex = 0;
                    place_comboBox.SelectedIndex = 0;
                    break;

                // Была ошибка
                case "0":
                    MessageBox.Show(words[1].ToString());
                    break;

                // Реавторизация
                case "3":
                    // Обновление токена
                    form.Change_token(words[1].ToString());
                    // Повторная отправка сообщения
                    get_info();
                    break;

                case "-1":
                    MessageBox.Show("Вам нужно пройти заново авторизацию");
                    form.Show();
                    this.Close();
                    break;
                case "1.1":
                    words.RemoveAt(0);
                    int sub1 = 1;
                    foreach (string item in words)
                    {
                        
                        string[] sub_words = item.Split(new char[] { '|' });


                        switch (sub1)
                        {
                            case 1:
                                cours_comboBox.Items.AddRange(sub_words);
                                break;
                            case 2:
                                place_comboBox.Items.AddRange(sub_words);
                                break;
                            case 3:
                                staff_comboBox.Items.AddRange(sub_words);
                                break;
                            case 4:
                                // Если такого курса больше нет
                                if (sub_words[0] == " ") { }
                                //cours_comboBox.Enabled = false;
                                else
                                {
                                    cours_comboBox.Items.RemoveAt(0);
                                    cours_comboBox.SelectedIndex = Convert.ToInt32(sub_words[0]);
                                }
                                // Если такой площадки больше нет
                                if (sub_words[1] == " ") { }
                                //place_comboBox.Enabled = false;
                                else
                                {
                                    place_comboBox.Items.RemoveAt(0);
                                    place_comboBox.SelectedIndex = Convert.ToInt32(sub_words[1]);
                                }
                                // Если такого сотрудника больше нет
                                if (sub_words[2] == " ") { }
                                //staff_comboBox.Enabled = false;
                                else
                                {
                                    staff_comboBox.Items.RemoveAt(0);
                                    staff_comboBox.SelectedIndex = Convert.ToInt32(sub_words[2]);
                                }
                                name_textbox.Text = sub_words[3];
                                breed_textbox.Text = sub_words[4];
                                if (sub_words[5] == "False")
                                    is_actual_box.Checked = false;

                                break;
                        }


                        
                        sub1++;
                    }
                    //cours_comboBox.Items.RemoveAt(0);
                    //place_comboBox.Items.RemoveAt(0);

                    
                    break;



            }
        }

        
        private void New_dog_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            form.active_forms = 0;
        }

        private void save_bttn_Click(object sender, EventArgs e)
        {
            string address = form.route + "/new/dog?" + form.after_route;
            // MessageBox.Show(address);
            string staff_id = staff_comboBox.Text.Split(new char[] { ' ' })[0];
            string[] ids = {staff_comboBox.Text.Split(new char[] { ' ' })[0], place_comboBox.Text.Split(new char[] { ' ' })[0],
                cours_comboBox.Text.Split(new char[] { ' ' })[0] };
            if (ids[0] == "")
            {
                ids[0] = "0";
            }

            // Проверка на id все
            foreach (var item in ids)
            {
                foreach (var sub_item in item)
                {
                    if (!char.IsDigit(sub_item))
                    {
                        MessageBox.Show("Вырите корректные данные");
                        return; //если хоть один символ не число, то выкидываешь "ложь"
                    }
                }
            }
            
            // Проверка на staff_id
            if (staff_id == "")
            {
                ids[0] = "None";
            }

            address += "&usr_id=" + id + "&name=" + name_textbox.Text + "&breed=" + breed_textbox.Text +
                "&staff_id=" + ids[0] + "&place=" + ids[1] + "&cours=" + ids[2] + "&actual=" + is_actual_box.Checked.ToString();
            
            if (dog_id != null)
            {
                address += "&dog_id=" + dog_id;
            }

            // Отправка запроса
            string line = form.send_request(address);
            string[] words = line.Split(new char[] { '~' });

            // Проверка на статус
            switch (words[0])
            {
                // Всё норм
                case "1":
                    //MessageBox.Show(words[1]);
                    Edit_client form1 = new Edit_client(form, to_be_back);
                    // this.FormClosing -= New_dog_FormClosing;
                    form1.Show();
                    this.FormClosing -= New_dog_FormClosing;
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
                    this.FormClosing -= New_dog_FormClosing;
                    this.Close();
                    break;


            }
        }


        private void find_bttn_Click(object sender, EventArgs e)
        {
            // Проверка на дурака
            foreach (var item in phone_textBox.Text)
            {
                if (!char.IsDigit(item))
                {
                    MessageBox.Show("Введите номер не через +7");
                    return; //если хоть один символ не число, то выкидываешь "ложь"
                }
            }
            string address = form.route + "/get/client?" + form.after_route;

            address += "&phone=" + phone_textBox.Text;
            MessageBox.Show(address);

            string line = form.send_request(address);


            string[] words = line.Split(new char[] { '~' });

            // Проверка на статус
            switch (words[0])
            {
                // Всё норм
                case "1":
                    dogs_list.Items.Clear();
                    int uncorrect_amount = 0;
                    bool flag = false;
                    foreach (var item in words)
                    {
                        // Первый пропустится проход, т.к. первое число - статус операции
                        if (flag)
                        {
                            string[] sub_words = item.Split(new char[] { '|' });
                            if (sub_words.Length == 8)
                            {
                                // Create three items and three sets of subitems for each item.
                                ListViewItem item1 = new ListViewItem(sub_words[0], 0);
                                // Place a check mark next to the item.
                                // item1.Checked = true;
                                item1.SubItems.Add(sub_words[1]);
                                item1.SubItems.Add(sub_words[2]);
                                item1.SubItems.Add(sub_words[3]);
                                item1.SubItems.Add(sub_words[4]);
                                item1.SubItems.Add(sub_words[5]);
                                item1.SubItems.Add(sub_words[6]);
                                dogs_list.Items.Add(item1);
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
                    MessageBox.Show(words[1]);
                    break;

                // Реавторизация
                case "3":
                    // Обновление токена
                    form.Change_token(words[1]);
                    // Повторная отправка сообщения
                    find_bttn_Click(sender, e);
                    break;

                case "-1":
                    MessageBox.Show("Вам нужно пройти заново авторизацию");
                    form.Show();
                    this.FormClosing -= New_dog_FormClosing;
                    this.Close();
                    break;


            }


        }

        private void show_owners()
        {
            switch (words[0])
            {
                // Всё норм
                case "1":
                    dogs_list.Columns.Clear();
                    dogs_list.Columns.Add("№", dogs_list.Width / 7, HorizontalAlignment.Left);
                    dogs_list.Columns.Add("Имя", dogs_list.Width / 7, HorizontalAlignment.Left);
                    dogs_list.Columns.Add("Телефон", dogs_list.Width / 7, HorizontalAlignment.Left);
                    dogs_list.Columns.Add("Дата рождения", dogs_list.Width / 7, HorizontalAlignment.Left);
                    dogs_list.Columns.Add("Тг. id", dogs_list.Width / 7, HorizontalAlignment.Center);
                    dogs_list.Columns.Add("Почта", dogs_list.Width / 7, HorizontalAlignment.Center);
                    dogs_list.Columns.Add("Роль", dogs_list.Width / 7, HorizontalAlignment.Center);
                    dogs_list.Items.Clear();
                    int uncorrect_amount = 0;
                    bool flag = false;
                    foreach (var item in words)
                    {
                        // Первый пропустится проход, т.к. первое число - статус операции
                        if (flag)
                        {
                            string[] sub_words = item.Split(new char[] { '|' });
                            if (sub_words.Length == 7)
                            {
                                // Create three items and three sets of subitems for each item.
                                owner_ids.Add(sub_words[0]);
                                ListViewItem item1 = new ListViewItem(sub_words[0], 0);
                                // Place a check mark next to the item.
                                // item1.Checked = true;
                                item1.SubItems.Add(sub_words[1]);
                                item1.SubItems.Add(sub_words[2]);
                                item1.SubItems.Add(sub_words[3]);
                                item1.SubItems.Add(sub_words[4]);
                                item1.SubItems.Add(sub_words[5]);
                                item1.SubItems.Add(sub_words[6]);
                                dogs_list.Items.Add(item1);
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
            }
        }

        private void get_owners()
        {
            string address = form.route + "/get/dog/client?" + form.after_route;

            address += "&dog_id=" + dog_id;
            MessageBox.Show(address);

            string line = form.send_request(address);


            words = line.Split(new char[] { '~' });
            owner_ids.Clear();
            switch (words[0])
            {
                
                // Была ошибка
                case "0":
                    MessageBox.Show(words[1]);
                    break;

                // Реавторизация
                case "3":
                    // Обновление токена
                    form.Change_token(words[1]);
                    // Повторная отправка сообщения
                    get_owners();
                    break;

                case "-1":
                    MessageBox.Show("Вам нужно пройти заново авторизацию");
                    form.Show();
                    this.FormClosing -= New_dog_FormClosing;
                    this.Close();
                    break;


            }
        }

        private void show_courses()
        {
            dogs_list.Columns.Clear();
            dogs_list.Columns.Add("№", dogs_list.Width / 4, HorizontalAlignment.Left);
            dogs_list.Columns.Add("Название", dogs_list.Width / 4, HorizontalAlignment.Left);
            dogs_list.Columns.Add("Кол-во занятий", dogs_list.Width / 4, HorizontalAlignment.Left);
            dogs_list.Columns.Add("Цена", dogs_list.Width / 4, HorizontalAlignment.Left);
            switch (courses[0])
            {
                // Всё норм
                case "1":
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
                                // Create three items and three sets of subitems for each item.
                                owner_ids.Add(sub_words[0]);
                                ListViewItem item1 = new ListViewItem(sub_words[0], 0);
                                // Place a check mark next to the item.
                                // item1.Checked = true;
                                item1.SubItems.Add(sub_words[1]);
                                item1.SubItems.Add(sub_words[2]);
                                item1.SubItems.Add(sub_words[3]);
                                dogs_list.Items.Add(item1);
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
            }
        }

        private void get_courses()
        {
            

            // Удаляем выбранного пользователя
            string address = form.route + "/get/courses?" + form.after_route;

            MessageBox.Show(address);
            // Поулчаем ответ
            string line = form.send_request(address);
            // split ответа
            courses = line.Split(new char[] { '~' });

            // Проверка на статус
            switch (courses[0])
            {
                
                // Была ошибка
                case "0":
                    MessageBox.Show(courses[1]);
                    break;

                // Реавторизация
                case "3":
                    // Обновление токена
                    form.Change_token(courses[1]);
                    // Повторная отправка сообщения
                    get_courses();
                    break;

                case "-1":
                    MessageBox.Show("Вам нужно пройти заново авторизацию");
                    form.Show();
                    this.FormClosing -= New_dog_FormClosing;
                    this.Close();
                    break;


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Добавление хозяев
            if (change_mod_bttn.Text == "Добавить хозяев")
            {
                phone_textBox.Enabled = true;
                find_user_bttn.Enabled = true;
                change_mod_bttn.Text = "Добавить курс";
                dogs_list.Items.Clear();
            }
            // Отображение хозяев
            else if (change_mod_bttn.Text == "Отобразить хозяев")
            {
                
                phone_textBox.Enabled = false;
                find_user_bttn.Enabled = false;
                change_mod_bttn.Text = "Добавить хозяев";
                dogs_list.Items.Clear();
                show_owners();
            }
            // Отображение курсов
            else
            {
                phone_textBox.Enabled = false;
                find_user_bttn.Enabled = false;
                change_mod_bttn.Text = "Отобразить хозяев";
                dogs_list.Items.Clear();
                show_courses();
            }
        }

        private void dogs_list_DoubleClick(object sender, EventArgs e)
        {
            // Если сейчас отображаются хозяева
            if (change_mod_bttn.Text == "Добавить хозяев")
            {
                // Если пытаемся удалить последнего хозяина
                if (words.Length == 2)
                {
                    MessageBox.Show("Вы пытаетесь удалить последнего хозяина. Это невозможно");
                    return;
                }
                // Уточнение
                if (MessageBox.Show("Вы уверены, что хотите уалить хозяина?", "Удаление", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;

                // Удаляем выбранного пользователя
                string address = form.route + "/delete/dog/client?" + form.after_route;

                address += "&dog_id=" + dog_id + "&id=" + dogs_list.SelectedItems[0].SubItems[0].Text;
                MessageBox.Show(address);
                // Поулчаем ответ
                string line = form.send_request(address);
                // split ответа
                string[] local_words = line.Split(new char[] { '~' });

                // Проверка на статус
                switch (local_words[0])
                {
                    // Всё норм
                    case "1":
                        dogs_list.Items.Clear();
                        get_owners();
                        show_owners();
                        MessageBox.Show("Пользователь удалён");
                        break;

                    // Была ошибка
                    case "0":
                        MessageBox.Show(local_words[1]);
                        break;

                    // Реавторизация
                    case "3":
                        // Обновление токена
                        form.Change_token(local_words[1]);
                        // Повторная отправка сообщения
                        dogs_list_DoubleClick(sender, e);
                        break;

                    case "-1":
                        MessageBox.Show("Вам нужно пройти заново авторизацию");
                        form.Show();
                        this.FormClosing -= New_dog_FormClosing;
                        this.Close();
                        break;


                }

            }
            // Если мы добавляем хозяев новых
            else if (change_mod_bttn.Text == "Добавить курс")
            {
                // Проверка на добавление существующего хозяина
                if (owner_ids.IndexOf(dogs_list.SelectedItems[0].SubItems[0].Text) != -1)
                {
                    MessageBox.Show("Вы пытаетесь добавить существующего клиента");
                    return;
                }
                // Проверка на дурака
                if (MessageBox.Show("Вы уверены, что хотите добавить хозяина?", "Добавление", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;


                string address = form.route + "/add/dog/client?" + form.after_route;

                address += "&dog_id=" + dog_id + "&id=" + dogs_list.SelectedItems[0].SubItems[0].Text;
                MessageBox.Show(address);

                string line = form.send_request(address);


                string[] words = line.Split(new char[] { '~' });

                // Проверка на статус
                switch (words[0])
                {
                    // Всё норм
                    case "1":
                        get_owners();
                        MessageBox.Show("Пользователь добавлен");
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
                        dogs_list_DoubleClick(sender, e);
                        break;

                    case "-1":
                        MessageBox.Show("Вам нужно пройти заново авторизацию");
                        form.Show();
                        this.FormClosing -= New_dog_FormClosing;
                        this.Close();
                        break;


                }
            }
            // Добавляем курс
            else
            {
                
                // Проверка на дурака
                if (MessageBox.Show("Вы уверены, что хотите добавить курс? Это добавит новый курс. Чтобы изменить текущий, измените его в поле слева", "Добавление", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;


                string address = form.route + "/add/dog/cours?" + form.after_route;

                address += "&dog_id=" + dog_id + "&cours_id=" + dogs_list.SelectedItems[0].SubItems[0].Text;
                MessageBox.Show(address);

                string line = form.send_request(address);


                string[] words = line.Split(new char[] { '~' });

                // Проверка на статус
                switch (words[0])
                {
                    // Всё норм
                    case "1":
                        get_info();
                        MessageBox.Show("Курс добавлен");

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
                        dogs_list_DoubleClick(sender, e);
                        break;

                    case "-1":
                        MessageBox.Show("Вам нужно пройти заново авторизацию");
                        form.Show();
                        this.FormClosing -= New_dog_FormClosing;
                        this.Close();
                        break;


                }
            }
            
        }

        private void New_dog_Load(object sender, EventArgs e)
        {
            form.Show_menu(panel1);
        }
    }
}
