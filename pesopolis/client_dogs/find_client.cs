using System;
using System.Windows.Forms;

namespace pesopolis
{
    public partial class Find_client : Form
    {
        public Auth_form form;
        public Find_client(Auth_form form1)
        {
            form = form1;
            form.active_forms = 1;
            InitializeComponent();
            // Set the view to show details.
            listView1.View = View.Details;
            // Allow the user to rearrange columns.
            listView1.AllowColumnReorder = true;
            // Select the item and subitems when selection is made.
            listView1.FullRowSelect = true;
            // Display grid lines.
            listView1.GridLines = true;
            // Sort the items in the list in ascending order.
            listView1.Sorting = SortOrder.Ascending;

            // Create columns for the items and subitems.
            // Width of -2 indicates auto-size.
            listView1.Columns.Add("№", listView1.Width / 7, HorizontalAlignment.Left);
            listView1.Columns.Add("Имя", listView1.Width / 7, HorizontalAlignment.Left);
            listView1.Columns.Add("Телефон", listView1.Width / 7, HorizontalAlignment.Left);
            listView1.Columns.Add("Дата рождения", listView1.Width / 7, HorizontalAlignment.Left);
            listView1.Columns.Add("Тг. id", listView1.Width / 7, HorizontalAlignment.Center);
            listView1.Columns.Add("Почта", listView1.Width / 7, HorizontalAlignment.Center);
            listView1.Columns.Add("Роль", listView1.Width / 7, HorizontalAlignment.Center);
            listView1.Columns.Add("Логин", listView1.Width / 7, HorizontalAlignment.Center);
        }

        private void Find_client_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.active_forms = 0;
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
            //MessageBox.Show(address);

            string line = form.send_request(address);

            
            string[] words = line.Split(new char[] { '~' });

            // Проверка на статус
            switch (words[0])
            {
                // Всё норм
                case "1":
                    listView1.Items.Clear();
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
                                item1.SubItems.Add(sub_words[7]);
                                listView1.Items.Add(item1);
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
                    this.FormClosing -= Find_client_FormClosing;
                    this.Close();
                    break;


            }
            
            
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //MessageBox.Show(listView1.SelectedItems[0].SubItems[0].Text);
            string[] to_send = new string[8];
            for (int i = 0; i<8; i++)
            {
                to_send[i] = listView1.SelectedItems[0].SubItems[i].Text;
            }
            this.FormClosing -= Find_client_FormClosing;
            Edit_client form1 = new Edit_client(form, to_send);
            form1.Show();
            form1.Location = this.Location;
            this.Close();


        }

        private void Find_client_Load(object sender, EventArgs e)
        {
            form.Show_menu(panel1);
        }
    }
}
