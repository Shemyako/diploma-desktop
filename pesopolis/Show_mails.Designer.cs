﻿
namespace pesopolis
{
    partial class Show_mails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Show_mails));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.places_bttn = new System.Windows.Forms.Button();
            this.lesson_bttn = new System.Windows.Forms.Button();
            this.cours_bttn = new System.Windows.Forms.Button();
            this.find_client_bttn = new System.Windows.Forms.Button();
            this.new_client_bttn = new System.Windows.Forms.Button();
            this.cours_list = new System.Windows.Forms.ListView();
            this.create_cours = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.places_bttn);
            this.panel1.Controls.Add(this.lesson_bttn);
            this.panel1.Controls.Add(this.cours_bttn);
            this.panel1.Controls.Add(this.find_client_bttn);
            this.panel1.Controls.Add(this.new_client_bttn);
            this.panel1.Location = new System.Drawing.Point(13, 173);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(149, 496);
            this.panel1.TabIndex = 5;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(3, 177);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(143, 23);
            this.button7.TabIndex = 9;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Visible = false;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(3, 148);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(143, 23);
            this.button6.TabIndex = 8;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Visible = false;
            // 
            // places_bttn
            // 
            this.places_bttn.Location = new System.Drawing.Point(3, 119);
            this.places_bttn.Name = "places_bttn";
            this.places_bttn.Size = new System.Drawing.Size(143, 23);
            this.places_bttn.TabIndex = 7;
            this.places_bttn.Text = "Площадки";
            this.places_bttn.UseVisualStyleBackColor = true;
            this.places_bttn.Visible = false;
            // 
            // lesson_bttn
            // 
            this.lesson_bttn.Location = new System.Drawing.Point(3, 90);
            this.lesson_bttn.Name = "lesson_bttn";
            this.lesson_bttn.Size = new System.Drawing.Size(143, 23);
            this.lesson_bttn.TabIndex = 6;
            this.lesson_bttn.Text = "Занятия";
            this.lesson_bttn.UseVisualStyleBackColor = true;
            this.lesson_bttn.Visible = false;
            // 
            // cours_bttn
            // 
            this.cours_bttn.Location = new System.Drawing.Point(3, 61);
            this.cours_bttn.Name = "cours_bttn";
            this.cours_bttn.Size = new System.Drawing.Size(143, 23);
            this.cours_bttn.TabIndex = 5;
            this.cours_bttn.Text = "Окно курсов";
            this.cours_bttn.UseVisualStyleBackColor = true;
            this.cours_bttn.Visible = false;
            // 
            // find_client_bttn
            // 
            this.find_client_bttn.Location = new System.Drawing.Point(3, 32);
            this.find_client_bttn.Name = "find_client_bttn";
            this.find_client_bttn.Size = new System.Drawing.Size(143, 23);
            this.find_client_bttn.TabIndex = 4;
            this.find_client_bttn.Text = "Найти клиента";
            this.find_client_bttn.UseVisualStyleBackColor = true;
            this.find_client_bttn.Visible = false;
            // 
            // new_client_bttn
            // 
            this.new_client_bttn.Location = new System.Drawing.Point(3, 3);
            this.new_client_bttn.Name = "new_client_bttn";
            this.new_client_bttn.Size = new System.Drawing.Size(143, 23);
            this.new_client_bttn.TabIndex = 3;
            this.new_client_bttn.Text = "Новый клинт";
            this.new_client_bttn.UseVisualStyleBackColor = true;
            this.new_client_bttn.Visible = false;
            // 
            // cours_list
            // 
            this.cours_list.HideSelection = false;
            this.cours_list.Location = new System.Drawing.Point(374, 135);
            this.cours_list.Name = "cours_list";
            this.cours_list.Size = new System.Drawing.Size(710, 372);
            this.cours_list.TabIndex = 35;
            this.cours_list.UseCompatibleStateImageBehavior = false;
            this.cours_list.DoubleClick += new System.EventHandler(this.cours_list_DoubleClick);
            // 
            // create_cours
            // 
            this.create_cours.Font = new System.Drawing.Font("Georgia", 10F);
            this.create_cours.Location = new System.Drawing.Point(374, 513);
            this.create_cours.Name = "create_cours";
            this.create_cours.Size = new System.Drawing.Size(189, 31);
            this.create_cours.TabIndex = 36;
            this.create_cours.Text = "Создать новую расслыку";
            this.create_cours.UseVisualStyleBackColor = true;
            this.create_cours.Click += new System.EventHandler(this.create_cours_Click);
            // 
            // logo
            // 
            this.logo.Image = global::pesopolis.Properties.Resources.logo;
            this.logo.Location = new System.Drawing.Point(13, 14);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(149, 153);
            this.logo.TabIndex = 4;
            this.logo.TabStop = false;
            // 
            // Show_mails
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.create_cours);
            this.Controls.Add(this.cours_list);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Show_mails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Показать рассылки";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Show_mails_FormClosing);
            this.Load += new System.EventHandler(this.Show_mails_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button places_bttn;
        private System.Windows.Forms.Button lesson_bttn;
        private System.Windows.Forms.Button cours_bttn;
        private System.Windows.Forms.Button find_client_bttn;
        private System.Windows.Forms.Button new_client_bttn;
        private System.Windows.Forms.ListView cours_list;
        private System.Windows.Forms.Button create_cours;
    }
}