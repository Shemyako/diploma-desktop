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
        public New_cours(Auth_form form1)
        {
            form = form1;
            form.active_forms = 1;
            InitializeComponent();
        }

        private void New_cours_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.active_forms = 0;
        }
    }
}
