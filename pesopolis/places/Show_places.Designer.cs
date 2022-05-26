
namespace pesopolis.places
{
    partial class Show_places
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Show_places));
            this.is_actual_box = new System.Windows.Forms.CheckBox();
            this.create_cours = new System.Windows.Forms.Button();
            this.cours_list = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // is_actual_box
            // 
            this.is_actual_box.AutoSize = true;
            this.is_actual_box.Checked = true;
            this.is_actual_box.CheckState = System.Windows.Forms.CheckState.Checked;
            this.is_actual_box.Font = new System.Drawing.Font("Georgia", 9F);
            this.is_actual_box.Location = new System.Drawing.Point(903, 110);
            this.is_actual_box.Name = "is_actual_box";
            this.is_actual_box.Size = new System.Drawing.Size(181, 19);
            this.is_actual_box.TabIndex = 36;
            this.is_actual_box.Text = "Скрыть старые площадки";
            this.is_actual_box.UseVisualStyleBackColor = true;
            this.is_actual_box.CheckedChanged += new System.EventHandler(this.is_actual_box_CheckedChanged);
            // 
            // create_cours
            // 
            this.create_cours.Font = new System.Drawing.Font("Georgia", 10F);
            this.create_cours.Location = new System.Drawing.Point(374, 513);
            this.create_cours.Name = "create_cours";
            this.create_cours.Size = new System.Drawing.Size(189, 31);
            this.create_cours.TabIndex = 35;
            this.create_cours.Text = "Создать новую площадку";
            this.create_cours.UseVisualStyleBackColor = true;
            this.create_cours.Click += new System.EventHandler(this.create_cours_Click);
            // 
            // cours_list
            // 
            this.cours_list.HideSelection = false;
            this.cours_list.Location = new System.Drawing.Point(374, 135);
            this.cours_list.Name = "cours_list";
            this.cours_list.Size = new System.Drawing.Size(710, 372);
            this.cours_list.TabIndex = 34;
            this.cours_list.UseCompatibleStateImageBehavior = false;
            this.cours_list.DoubleClick += new System.EventHandler(this.cours_list_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(13, 173);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(149, 496);
            this.panel1.TabIndex = 37;
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
            // Show_places
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.is_actual_box);
            this.Controls.Add(this.create_cours);
            this.Controls.Add(this.cours_list);
            this.Controls.Add(this.logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Show_places";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Все площадки";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Show_places_FormClosing);
            this.Load += new System.EventHandler(this.Show_places_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.CheckBox is_actual_box;
        private System.Windows.Forms.Button create_cours;
        private System.Windows.Forms.ListView cours_list;
        private System.Windows.Forms.Panel panel1;
    }
}