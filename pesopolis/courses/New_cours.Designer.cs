﻿
namespace pesopolis
{
    partial class New_cours
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
            this.cours_list = new System.Windows.Forms.ListView();
            this.create_cours = new System.Windows.Forms.Button();
            this.is_actual_box = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // cours_list
            // 
            this.cours_list.HideSelection = false;
            this.cours_list.Location = new System.Drawing.Point(368, 116);
            this.cours_list.Name = "cours_list";
            this.cours_list.Size = new System.Drawing.Size(710, 372);
            this.cours_list.TabIndex = 31;
            this.cours_list.UseCompatibleStateImageBehavior = false;
            // 
            // create_cours
            // 
            this.create_cours.Font = new System.Drawing.Font("Georgia", 10F);
            this.create_cours.Location = new System.Drawing.Point(368, 494);
            this.create_cours.Name = "create_cours";
            this.create_cours.Size = new System.Drawing.Size(189, 31);
            this.create_cours.TabIndex = 32;
            this.create_cours.Text = "Создать новый курс";
            this.create_cours.UseVisualStyleBackColor = true;
            this.create_cours.Click += new System.EventHandler(this.create_cours_Click);
            // 
            // is_actual_box
            // 
            this.is_actual_box.AutoSize = true;
            this.is_actual_box.Checked = true;
            this.is_actual_box.CheckState = System.Windows.Forms.CheckState.Checked;
            this.is_actual_box.Location = new System.Drawing.Point(940, 93);
            this.is_actual_box.Name = "is_actual_box";
            this.is_actual_box.Size = new System.Drawing.Size(138, 17);
            this.is_actual_box.TabIndex = 33;
            this.is_actual_box.Text = "Скрыть старые курсы";
            this.is_actual_box.UseVisualStyleBackColor = true;
            this.is_actual_box.CheckedChanged += new System.EventHandler(this.is_actual_box_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "menu";
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
            // New_cours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.is_actual_box);
            this.Controls.Add(this.create_cours);
            this.Controls.Add(this.cours_list);
            this.Controls.Add(this.logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "New_cours";
            this.Text = "Редактор курсов";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.New_cours_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.ListView cours_list;
        private System.Windows.Forms.Button create_cours;
        private System.Windows.Forms.CheckBox is_actual_box;
        private System.Windows.Forms.Label label1;
    }
}