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
    public partial class Lessons : Form
    {
        private Auth_form form;
        public Lessons(Auth_form form1)
        {
            form = form1;
            InitializeComponent();
        }

        private void get_pre_lesson()
        {
            // Нужно получить всех
            // кинологов
            // Собак
            // Типы занятий
            // Площадки
            string address = form.route + "/get/client/dog?" + form.after_route;
            //address += "&id=" + id;
            MessageBox.Show(address);

            // Отправка запроса
            string line = form.send_request(address);
            string[] words = line.Split(new char[] { '~' });
        }
    }
}
