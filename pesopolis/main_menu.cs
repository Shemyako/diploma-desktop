﻿using pesopolis.places;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pesopolis
{
    public partial class Menu_form : Form
    {
        public Auth_form form;
        public Menu_form(Auth_form form1)
        {
            form = form1;
            form.active_forms = 1;

            InitializeComponent();
        }

        //private async Task Pre_new_client_opening()
        //{
        //    await Task.Run(() => New_client_opening());
        //}

        //private void New_client_opening()
        //{
        //    // Thread.Sleep(3000);
        //    New_client new_from = new New_client(form);
        //    new_from.ShowDialog();
        //}
        
        private void Menu_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            //MessageBox.Show("Exit");
            form.active_forms = 0;
            // Application.Exit();
        }

        private void New_client_bttn_Click(object sender, EventArgs e)
        {

            New_client new_from = new New_client(form);
            new_from.Show();
            this.FormClosing -= Menu_form_FormClosing;
            this.Close();

        }

        private void find_client_bttn_click(object sender, EventArgs e)
        {
            Find_client new_from = new Find_client(form);
            new_from.Show();
            this.FormClosing -= Menu_form_FormClosing;
            this.Close();
        }

        private void cours_bttn_Click(object sender, EventArgs e)
        {
            New_cours new_from = new New_cours(form);
            new_from.Show();
            this.FormClosing -= Menu_form_FormClosing;
            this.Close();
        }

        private void lesson_bttn_Click(object sender, EventArgs e)
        {
            Lessons new_form = new Lessons(form);
            new_form.Show();
            this.FormClosing -= Menu_form_FormClosing;
            this.Close();
        }

        private void places_bttn_Click(object sender, EventArgs e)
        {
            Show_places new_form = new Show_places(form);
            new_form.Show();
            this.FormClosing -= Menu_form_FormClosing;
            this.Close();
        }

        private void Menu_form_Load(object sender, EventArgs e)
        {
            main_lbl.Text = $"Приветствую.\nСегодня {DateTime.Now.ToString("dd MMMM yy")}\nВремя: {DateTime.Now.ToString("HH:mm")}";
            form.Show_menu(panel1);

        }
    }
}
