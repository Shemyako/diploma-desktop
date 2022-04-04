
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
            this.logo = new System.Windows.Forms.PictureBox();
            this.is_actual = new System.Windows.Forms.CheckBox();
            this.save_bttn = new System.Windows.Forms.Button();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.address_textbox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
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
            // is_actual
            // 
            this.is_actual.AutoSize = true;
            this.is_actual.Checked = true;
            this.is_actual.CheckState = System.Windows.Forms.CheckState.Checked;
            this.is_actual.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.is_actual.Location = new System.Drawing.Point(331, 158);
            this.is_actual.Name = "is_actual";
            this.is_actual.Size = new System.Drawing.Size(144, 20);
            this.is_actual.TabIndex = 40;
            this.is_actual.Text = "Актуальный курс";
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
            // Edit_place
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.is_actual);
            this.Controls.Add(this.save_bttn);
            this.Controls.Add(this.name_textbox);
            this.Controls.Add(this.address_textbox);
            this.Controls.Add(this.logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Edit_place";
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
    }
}