﻿
namespace pesopolis
{
    partial class Create_new_cours
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
            this.is_actual = new System.Windows.Forms.CheckBox();
            this.save_bttn = new System.Windows.Forms.Button();
            this.price_textbox = new System.Windows.Forms.TextBox();
            this.phone_textbox = new System.Windows.Forms.TextBox();
            this.name_textbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.Image = global::pesopolis.Properties.Resources.logo;
            this.logo.Location = new System.Drawing.Point(13, 14);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(149, 153);
            this.logo.TabIndex = 5;
            this.logo.TabStop = false;
            // 
            // is_actual
            // 
            this.is_actual.AutoSize = true;
            this.is_actual.Checked = true;
            this.is_actual.CheckState = System.Windows.Forms.CheckState.Checked;
            this.is_actual.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.is_actual.Location = new System.Drawing.Point(255, 130);
            this.is_actual.Name = "is_actual";
            this.is_actual.Size = new System.Drawing.Size(144, 20);
            this.is_actual.TabIndex = 35;
            this.is_actual.Text = "Актуальный курс";
            this.is_actual.UseVisualStyleBackColor = true;
            // 
            // save_bttn
            // 
            this.save_bttn.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save_bttn.Location = new System.Drawing.Point(255, 328);
            this.save_bttn.Name = "save_bttn";
            this.save_bttn.Size = new System.Drawing.Size(159, 51);
            this.save_bttn.TabIndex = 33;
            this.save_bttn.Text = "Сохранить";
            this.save_bttn.UseVisualStyleBackColor = true;
            // 
            // price_textbox
            // 
            this.price_textbox.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.price_textbox.Location = new System.Drawing.Point(255, 266);
            this.price_textbox.Name = "price_textbox";
            this.price_textbox.Size = new System.Drawing.Size(251, 22);
            this.price_textbox.TabIndex = 31;
            this.price_textbox.Text = "Цена";
            // 
            // phone_textbox
            // 
            this.phone_textbox.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phone_textbox.Location = new System.Drawing.Point(255, 219);
            this.phone_textbox.Name = "phone_textbox";
            this.phone_textbox.Size = new System.Drawing.Size(251, 22);
            this.phone_textbox.TabIndex = 30;
            this.phone_textbox.Text = "Кол-во занятий";
            // 
            // name_textbox
            // 
            this.name_textbox.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_textbox.Location = new System.Drawing.Point(255, 174);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(251, 22);
            this.name_textbox.TabIndex = 29;
            this.name_textbox.Text = "Имя";
            // 
            // Create_new_cours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.is_actual);
            this.Controls.Add(this.save_bttn);
            this.Controls.Add(this.price_textbox);
            this.Controls.Add(this.phone_textbox);
            this.Controls.Add(this.name_textbox);
            this.Controls.Add(this.logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Create_new_cours";
            this.Text = "Создать новый курс";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.CheckBox is_actual;
        private System.Windows.Forms.Button save_bttn;
        private System.Windows.Forms.TextBox price_textbox;
        private System.Windows.Forms.TextBox phone_textbox;
        private System.Windows.Forms.TextBox name_textbox;
    }
}