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
    public partial class Edit_client : Form
    {
        private string id;
        private Auth_form form;
        private string[] to_be_back;
        public Edit_client(Auth_form form1, string[] name1)
        {
            form = form1;
            form.active_forms = 1;
            id = name1[0];
            to_be_back = name1;
            InitializeComponent();
            //# Настройка listView
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
            dogs_list.Columns.Add("№", dogs_list.Width / 7, HorizontalAlignment.Left);
            dogs_list.Columns.Add("Кличка", dogs_list.Width / 7, HorizontalAlignment.Left);
            dogs_list.Columns.Add("Порода", dogs_list.Width / 7, HorizontalAlignment.Left);
            dogs_list.Columns.Add("Текущий курс", dogs_list.Width / 7, HorizontalAlignment.Left);
            dogs_list.Columns.Add("Проведено", dogs_list.Width / 7, HorizontalAlignment.Left);
            dogs_list.Columns.Add("Площадка", dogs_list.Width / 7, HorizontalAlignment.Left);
            dogs_list.Columns.Add("Инструктор", dogs_list.Width / 7, HorizontalAlignment.Left);
            name_textbox.Text = name1[1];
            phone_textbox.Text = name1[2];
            tg_id_textbox.Text = name1[4];
            email_textbox.Text = name1[5];
            login_lbl.Text = "Логин: " + name1[7];

            if (form.role == "3")
            {
                is_admin.Visible = true;
                is_admin.Enabled = true;
                password.Visible = true;
            }

            if (name1[6] == "1")
                is_handler.Checked = true;
            else if (name1[6] == "2")
            {
                is_admin.Checked = true;
                login_lbl.Visible = true;
            }
                

            // Если у пользователя задана д.р.
            if (name1[3] != "None")
            {
                birth_picker.Checked = true;
                birth_picker.Value = DateTime.Parse(name1[3]);
            }

            // Получение собак клиента
            get_dogs_info();

        }

        public void get_dogs_info()
        {
            // this.FormClosing += edit_client_FormClosing;
            string address = form.route + "/get/client/dog?" + form.after_route;
            address += "&id=" + id;
            MessageBox.Show(address);

            // Отправка запроса
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
                            if (sub_words.Length == 7)
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
                    get_dogs_info();
                    break;

                case "-1":
                    MessageBox.Show("Вам нужно пройти заново авторизацию");
                    form.Show();
                    this.FormClosing -= edit_client_FormClosing;
                    this.Close();
                    break;


            }

        }

        private void add_dog_bttn_Click(object sender, EventArgs e)
        {
            New_dog new_from = new New_dog(form, id, name1: to_be_back);
            new_from.Show();
            this.FormClosing -= edit_client_FormClosing;
            this.Close();
        }

        private void edit_client_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.active_forms = 0;
        }

        private void save_bttn_Click(object sender, EventArgs e)
        {
            string birth = birth_picker.Text;
            string role = "0";
            // Проверка на дуркака
            if (name_textbox.Text == "" || phone_textbox.Text == "" || email_textbox.Text == "" ||
                name_textbox.Text == "Имя" || phone_textbox.Text == "Телефон" || email_textbox.Text == "e-mail")
            {
                MessageBox.Show("Заполните поля корректно");
                return;
            }

            // Проверка на вводимый телефон
            foreach (var item in phone_textbox.Text)
            {
                if (!char.IsDigit(item))
                {
                    MessageBox.Show("Введите номер не через +7");
                    return; //если хоть один символ не число, то выкидываешь "ложь"
                }
            }

            // Заполнение None пустые поля
            if (tg_id_textbox.Text == "" || tg_id_textbox.Text == "tg_id" || tg_id_textbox.Text == "None")
                tg_id_textbox.Text = "Null";
            // Null в д.р.
            if (!birth_picker.Checked)
                birth = "Null";
            // Кинолог ли
            if (is_handler.Checked)
                role = "1";
            else if (is_admin.Checked && form.role == "3")
                role = "2";

            // Запрос на проверку логина и пароля
            // route - ip на который дклвть запрос
            // after_route - передача login,token, mac 

            string address = form.route + "/edit/client?" + form.after_route;

            address += "&id=" + id + "&name=" + name_textbox.Text + "&phone=" + phone_textbox.Text + "&birth=" + birth +
                "&tg_id=" + tg_id_textbox.Text + "&email=" + email_textbox.Text + "&role=" + role;
            // MessageBox.Show(address);
            if (role == "2")
                address += "&password=" + password.Text;
            // Отправка запроса
            string line = form.send_request(address);

            string[] words = line.Split(new char[] { '~' });

            switch (words[0])
            {
                // Нужно заново зайти
                case "-1":
                    MessageBox.Show("Вам нужно пройти заново авторизацию");
                    form.Show();
                    this.FormClosing -= edit_client_FormClosing;
                    this.Close();
                    break;

                // Всё хорошо
                case "1":
                    MessageBox.Show("Успешно");
                    if (words[1] != "None")
                    {
                        login_lbl.Text = "Логин: " + words[1];
                        login_lbl.Visible = true;
                    }
                    break;

                // Реавторизация и обновление токена
                case "3":
                    form.Change_token(words[1]);
                    // Повторная отправка сообщения
                    save_bttn_Click(sender, e);
                    break;

                // Ошибка
                case "0":
                    MessageBox.Show("Произошла ошибка. Проверьте соединение и повторите позже");
                    break;
            }

        }

        // Редактирование собаки
        private void dogs_list_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(dogs_list.SelectedItems[0].SubItems[0].Text);
            this.FormClosing -= edit_client_FormClosing;
            New_dog form1 = new New_dog(form, id, dogs_list.SelectedItems[0].SubItems[0].Text, to_be_back);
            form1.Show();
            this.FormClosing -= edit_client_FormClosing;
            this.Close();
        }

        private void Edit_client_Load(object sender, EventArgs e)
        {
            form.Show_menu(panel1);
        }

        private void is_admin_CheckedChanged(object sender, EventArgs e)
        {
            if (is_admin.Checked)
                password.Enabled = true;
            else
                password.Enabled = false;
        }
    }
}
