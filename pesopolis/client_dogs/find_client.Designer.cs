
namespace pesopolis
{
    partial class Find_client
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
            this.phone_textBox = new System.Windows.Forms.TextBox();
            this.find_bttn = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
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
            this.logo.TabIndex = 4;
            this.logo.TabStop = false;
            // 
            // phone_textBox
            // 
            this.phone_textBox.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phone_textBox.Location = new System.Drawing.Point(256, 112);
            this.phone_textBox.Name = "phone_textBox";
            this.phone_textBox.Size = new System.Drawing.Size(251, 22);
            this.phone_textBox.TabIndex = 20;
            this.phone_textBox.Text = "Телефон";
            // 
            // find_bttn
            // 
            this.find_bttn.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.find_bttn.Location = new System.Drawing.Point(539, 111);
            this.find_bttn.Name = "find_bttn";
            this.find_bttn.Size = new System.Drawing.Size(75, 23);
            this.find_bttn.TabIndex = 21;
            this.find_bttn.Text = "Найти";
            this.find_bttn.UseVisualStyleBackColor = true;
            this.find_bttn.Click += new System.EventHandler(this.find_bttn_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(256, 186);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(810, 400);
            this.listView1.TabIndex = 22;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(13, 173);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(149, 496);
            this.panel1.TabIndex = 35;
            // 
            // Find_client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.find_bttn);
            this.Controls.Add(this.phone_textBox);
            this.Controls.Add(this.logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Find_client";
            this.Text = "Найти клиента";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Find_client_FormClosing);
            this.Load += new System.EventHandler(this.Find_client_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.TextBox phone_textBox;
        private System.Windows.Forms.Button find_bttn;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel panel1;
    }
}