﻿
namespace pesopolis
{
    partial class Edit_client
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
            this.logo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.save_bttn = new System.Windows.Forms.Button();
            this.email_textbox = new System.Windows.Forms.TextBox();
            this.tg_id_textbox = new System.Windows.Forms.TextBox();
            this.phone_textbox = new System.Windows.Forms.TextBox();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.dogs_list = new System.Windows.Forms.ListView();
            this.dog_lbl = new System.Windows.Forms.Label();
            this.add_dog_bttn = new System.Windows.Forms.Button();
            this.birth_picker = new System.Windows.Forms.DateTimePicker();
            this.is_handler = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.Image = global::pesopolis.Properties.Resources.logo;
            this.logo.Location = new System.Drawing.Point(13, 14);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(149, 153);
            this.logo.TabIndex = 2;
            this.logo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Menu";
            // 
            // save_bttn
            // 
            this.save_bttn.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save_bttn.Location = new System.Drawing.Point(202, 490);
            this.save_bttn.Name = "save_bttn";
            this.save_bttn.Size = new System.Drawing.Size(159, 51);
            this.save_bttn.TabIndex = 16;
            this.save_bttn.Text = "Сохранить";
            this.save_bttn.UseVisualStyleBackColor = true;
            this.save_bttn.Click += new System.EventHandler(this.save_bttn_Click);
            // 
            // email_textbox
            // 
            this.email_textbox.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.email_textbox.Location = new System.Drawing.Point(202, 315);
            this.email_textbox.Name = "email_textbox";
            this.email_textbox.Size = new System.Drawing.Size(251, 22);
            this.email_textbox.TabIndex = 15;
            this.email_textbox.Text = "e-mail";
            // 
            // tg_id_textbox
            // 
            this.tg_id_textbox.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tg_id_textbox.Location = new System.Drawing.Point(202, 260);
            this.tg_id_textbox.Name = "tg_id_textbox";
            this.tg_id_textbox.Size = new System.Drawing.Size(251, 22);
            this.tg_id_textbox.TabIndex = 14;
            this.tg_id_textbox.Text = "tg_id";
            // 
            // phone_textbox
            // 
            this.phone_textbox.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phone_textbox.Location = new System.Drawing.Point(202, 156);
            this.phone_textbox.Name = "phone_textbox";
            this.phone_textbox.Size = new System.Drawing.Size(251, 22);
            this.phone_textbox.TabIndex = 12;
            this.phone_textbox.Text = "Телефон";
            // 
            // name_textbox
            // 
            this.name_textbox.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_textbox.Location = new System.Drawing.Point(202, 111);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(251, 22);
            this.name_textbox.TabIndex = 11;
            this.name_textbox.Text = "Имя";
            // 
            // dogs_list
            // 
            this.dogs_list.HideSelection = false;
            this.dogs_list.Location = new System.Drawing.Point(496, 102);
            this.dogs_list.Name = "dogs_list";
            this.dogs_list.Size = new System.Drawing.Size(733, 301);
            this.dogs_list.TabIndex = 23;
            this.dogs_list.UseCompatibleStateImageBehavior = false;
            this.dogs_list.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dogs_list_MouseDoubleClick);
            // 
            // dog_lbl
            // 
            this.dog_lbl.AutoSize = true;
            this.dog_lbl.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dog_lbl.Location = new System.Drawing.Point(493, 83);
            this.dog_lbl.Name = "dog_lbl";
            this.dog_lbl.Size = new System.Drawing.Size(55, 16);
            this.dog_lbl.TabIndex = 24;
            this.dog_lbl.Text = "Собаки";
            // 
            // add_dog_bttn
            // 
            this.add_dog_bttn.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_dog_bttn.Location = new System.Drawing.Point(692, 490);
            this.add_dog_bttn.Name = "add_dog_bttn";
            this.add_dog_bttn.Size = new System.Drawing.Size(159, 51);
            this.add_dog_bttn.TabIndex = 25;
            this.add_dog_bttn.Text = "Добавить собаку";
            this.add_dog_bttn.UseVisualStyleBackColor = true;
            this.add_dog_bttn.Click += new System.EventHandler(this.add_dog_bttn_Click);
            // 
            // birth_picker
            // 
            this.birth_picker.Checked = false;
            this.birth_picker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birth_picker.Location = new System.Drawing.Point(202, 206);
            this.birth_picker.Name = "birth_picker";
            this.birth_picker.ShowCheckBox = true;
            this.birth_picker.Size = new System.Drawing.Size(251, 20);
            this.birth_picker.TabIndex = 26;
            // 
            // is_handler
            // 
            this.is_handler.AutoSize = true;
            this.is_handler.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.is_handler.Location = new System.Drawing.Point(202, 65);
            this.is_handler.Name = "is_handler";
            this.is_handler.Size = new System.Drawing.Size(84, 20);
            this.is_handler.TabIndex = 27;
            this.is_handler.Text = "Кинолог";
            this.is_handler.UseVisualStyleBackColor = true;
            // 
            // Edit_client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.is_handler);
            this.Controls.Add(this.birth_picker);
            this.Controls.Add(this.add_dog_bttn);
            this.Controls.Add(this.dog_lbl);
            this.Controls.Add(this.dogs_list);
            this.Controls.Add(this.save_bttn);
            this.Controls.Add(this.email_textbox);
            this.Controls.Add(this.tg_id_textbox);
            this.Controls.Add(this.phone_textbox);
            this.Controls.Add(this.name_textbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Edit_client";
            this.Text = "Редактировать клиента";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.edit_client_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button save_bttn;
        private System.Windows.Forms.TextBox email_textbox;
        private System.Windows.Forms.TextBox tg_id_textbox;
        private System.Windows.Forms.TextBox phone_textbox;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.ListView dogs_list;
        private System.Windows.Forms.Label dog_lbl;
        private System.Windows.Forms.Button add_dog_bttn;
        private System.Windows.Forms.DateTimePicker birth_picker;
        private System.Windows.Forms.CheckBox is_handler;
    }
}