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
    public partial class New_database : Form
    {
        private Auth_form form;
        private string address;

        public New_database(Auth_form form1)
        {
            form = form1;
            InitializeComponent();
        }

        private void check_file_bttn_Click(object sender, EventArgs e)
        {
            OpenFileDialog OPF = new OpenFileDialog();
            OPF.Filter = "Файлы sql|*.sql";
            if (OPF.ShowDialog() == DialogResult.OK)
            {
                address = OPF.FileName;
                address_textbox.Text = "Выбранный файл: " + address;
            }
        }

        private void New_database_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.active_forms = 0;
        }

        private void New_database_Load(object sender, EventArgs e)
        {
            form.Show_menu(panel1);
        }

        private void send_file_bttn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(form.Send_file(address));
        }
    }
}
