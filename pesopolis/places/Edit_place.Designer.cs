﻿
namespace pesopolis.places
{
    partial class Edit_place
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit_place));
            this.is_actual = new System.Windows.Forms.CheckBox();
            this.save_bttn = new System.Windows.Forms.Button();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.address_textbox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.back_bttn = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.tg_id_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // is_actual
            // 
            this.is_actual.AutoSize = true;
            this.is_actual.Checked = true;
            this.is_actual.CheckState = System.Windows.Forms.CheckState.Checked;
            this.is_actual.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.is_actual.Location = new System.Drawing.Point(331, 158);
            this.is_actual.Name = "is_actual";
            this.is_actual.Size = new System.Drawing.Size(177, 20);
            this.is_actual.TabIndex = 40;
            this.is_actual.Text = "Актуальная площадка";
            this.is_actual.UseVisualStyleBackColor = true;
            // 
            // save_bttn
            // 
            this.save_bttn.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save_bttn.Location = new System.Drawing.Point(331, 290);
            this.save_bttn.Name = "save_bttn";
            this.save_bttn.Size = new System.Drawing.Size(159, 51);
            this.save_bttn.TabIndex = 39;
            this.save_bttn.Text = "Сохранить";
            this.save_bttn.UseVisualStyleBackColor = true;
            this.save_bttn.Click += new System.EventHandler(this.save_bttn_Click);
            // 
            // name_textbox
            // 
            this.name_textbox.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_textbox.Location = new System.Drawing.Point(331, 247);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(251, 22);
            this.name_textbox.TabIndex = 37;
            this.name_textbox.Text = "Название";
            // 
            // address_textbox
            // 
            this.address_textbox.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.address_textbox.Location = new System.Drawing.Point(331, 202);
            this.address_textbox.Name = "address_textbox";
            this.address_textbox.Size = new System.Drawing.Size(616, 22);
            this.address_textbox.TabIndex = 36;
            this.address_textbox.Text = "Адрес";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(13, 173);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(149, 496);
            this.panel1.TabIndex = 41;
            // 
            // back_bttn
            // 
            this.back_bttn.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.back_bttn.Location = new System.Drawing.Point(217, 618);
            this.back_bttn.Name = "back_bttn";
            this.back_bttn.Size = new System.Drawing.Size(159, 51);
            this.back_bttn.TabIndex = 42;
            this.back_bttn.Text = "Назад";
            this.back_bttn.UseVisualStyleBackColor = true;
            this.back_bttn.Click += new System.EventHandler(this.back_bttn_Click);
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
            // tg_id_lbl
            // 
            this.tg_id_lbl.AutoSize = true;
            this.tg_id_lbl.Font = new System.Drawing.Font("Georgia", 8F);
            this.tg_id_lbl.Location = new System.Drawing.Point(328, 185);
            this.tg_id_lbl.Name = "tg_id_lbl";
            this.tg_id_lbl.Size = new System.Drawing.Size(42, 14);
            this.tg_id_lbl.TabIndex = 43;
            this.tg_id_lbl.Text = "Адрес";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 8F);
            this.label1.Location = new System.Drawing.Point(328, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 14);
            this.label1.TabIndex = 43;
            this.label1.Text = "Название";
            // 
            // Edit_place
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tg_id_lbl);
            this.Controls.Add(this.back_bttn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.is_actual);
            this.Controls.Add(this.save_bttn);
            this.Controls.Add(this.name_textbox);
            this.Controls.Add(this.address_textbox);
            this.Controls.Add(this.logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Edit_place";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Изменить площадку";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Edit_place_FormClosing);
            this.Load += new System.EventHandler(this.Edit_place_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.CheckBox is_actual;
        private System.Windows.Forms.Button save_bttn;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.TextBox address_textbox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button back_bttn;
        private System.Windows.Forms.Label tg_id_lbl;
        private System.Windows.Forms.Label label1;
    }
}