using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pesopolis
{
    public partial class Auth_form : Form
    {
        // Токен сессии
        public string token;
        // Роль
        public string role;
        public string login;
        // Адрес для отправки сообщений
        public string route = "http://localhost:5000";
        // Часть с токеном и маком при отправке пакета на сервер
        public string after_route;
        // Число активных форм для отображения через трею
        public int active_forms;

        public Auth_form()
        {
            login = "";
            token = "";
            role = "";
            after_route = "";
            active_forms = 1;
            InitializeComponent();

            notifyIcon1.Click += NotifyIconClick;
            notifyIcon1.ContextMenu = new ContextMenu();
            notifyIcon1.ContextMenu.MenuItems.Add(new MenuItem("Выйти", NotifyIconClosing));
        }

        private void NotifyIconClosing(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void NotifyIconClick(object sender, EventArgs e)
        {
            // Если залогинен и нет активных форм, то открываем меню
            if (login != "" && active_forms == 0)
            {
                active_forms = 1;
                Menu_form form1 = new Menu_form(this);
                form1.Show();
            }
            // Если не залогинен и формы закрыты, то просто показываем эту форму
            else if (active_forms == 0)
            {
                this.Show();
            }
        }

        public string GetMACAddress()
        {
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            String sMacAddress = string.Empty;
            foreach (NetworkInterface adapter in nics)
            {
                if (sMacAddress == String.Empty)// only return MAC Address from first card  
                {
                    IPInterfaceProperties properties = adapter.GetIPProperties();
                    sMacAddress = adapter.GetPhysicalAddress().ToString();
                }
            }
            return sMacAddress;
        }

        private void auth_bttn_Click(object sender, EventArgs e)
        {
            // Проверка на дурака
            if (login_box.Text == "" || password_box.Text == "")
            {
                MessageBox.Show("Заполните поля!");
                return;
            } else if (login_box.Text.IndexOf('?') + login_box.Text.IndexOf('&') != -2)
            {
                MessageBox.Show("Введите коррктные данные!");
                return;
            }

            // Запрос на проверку логина и пароля
            string address = route + "/login?";
            address += "login=" + login_box.Text + "&password=" + password_box.Text + "&mac=" + GetMACAddress();
            string line = "0~";
            // try для обработки разрывов соединения
            try
            {
                WebRequest request = WebRequest.Create(address);
                WebResponse response = request.GetResponse();
                
                using (Stream stream = response.GetResponseStream())
                {
                    using (StreamReader reader = new StreamReader(stream))
                    {

                        //while ((line = reader.ReadLine()) != null)
                        //{
                        //    MessageBox.Show(line);
                        //}
                        line = reader.ReadToEnd();
                        MessageBox.Show(line);
                    }
                }
                response.Close();
            }
            catch (WebException ex)
            { // Обработка ошибок соединения
                // получаем статус исключения
                WebExceptionStatus status = ex.Status;

                if (status == WebExceptionStatus.ProtocolError)
                {
                    HttpWebResponse httpResponse = (HttpWebResponse)ex.Response;
                    MessageBox.Show(string.Format("Статусный код ошибки: {0} - {1}",
                            (int)httpResponse.StatusCode, httpResponse.StatusCode) );
                }
            }
            // Если ответ получен нормальный

            string[] words = line.Split(new char[] { '~' });
            if (words[0] == "1" && words.Length == 3)
            {
                login = login_box.Text;
                token = words[1];
                role = words[2];
                after_route = "token=" + token + "&login=" + login + "&mac=" + GetMACAddress();
                active_forms = 0;
                Menu_form form1 = new Menu_form(this);
                form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Не получилось пройти авторизацию. Повторите попытку позже");
            }
        }

        public void Change_token(string token1)
        {
            token = token1;
            after_route = "token=" + token + "&login=" + login + "&mac=" + GetMACAddress();
        }

        public string send_request(string address)
        {
            string line = "0~Произошла ошибка";
            // try для обработки разрывов соединения
            try
            {
                WebRequest request = WebRequest.Create(address);
                WebResponse response = request.GetResponse();

                using (Stream stream = response.GetResponseStream())
                {
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        line = reader.ReadToEnd();
                        MessageBox.Show(line);
                    }
                }
                response.Close();
            }
            catch (WebException ex)
            {
                HttpWebResponse httpResponse = (HttpWebResponse)ex.Response;
                line = "0~" + string.Format("Статусный код ошибки: {0} - {1}",
                        (int)httpResponse.StatusCode, httpResponse.StatusCode);
            }
            return line;
        }

        public void Show_menu(Panel panel, int role)
        {

        }

    }
}
