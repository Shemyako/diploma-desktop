
namespace pesopolis.types
{
    partial class Show_types
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.types_list = new System.Windows.Forms.ListView();
            this.create_cours = new System.Windows.Forms.Button();
            this.is_actual_box = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.Image = global::pesopolis.Properties.Resources.logo;
            this.logo.Location = new System.Drawing.Point(13, 14);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(149, 153);
            this.logo.TabIndex = 3;
            this.logo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(13, 173);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(149, 496);
            this.panel1.TabIndex = 38;
            // 
            // types_list
            // 
            this.types_list.HideSelection = false;
            this.types_list.Location = new System.Drawing.Point(374, 135);
            this.types_list.Name = "types_list";
            this.types_list.Size = new System.Drawing.Size(710, 372);
            this.types_list.TabIndex = 39;
            this.types_list.UseCompatibleStateImageBehavior = false;
            // 
            // create_cours
            // 
            this.create_cours.Font = new System.Drawing.Font("Georgia", 10F);
            this.create_cours.Location = new System.Drawing.Point(374, 513);
            this.create_cours.Name = "create_cours";
            this.create_cours.Size = new System.Drawing.Size(206, 31);
            this.create_cours.TabIndex = 40;
            this.create_cours.Text = "Создать новый тип занятия";
            this.create_cours.UseVisualStyleBackColor = true;
            // 
            // is_actual_box
            // 
            this.is_actual_box.AutoSize = true;
            this.is_actual_box.Checked = true;
            this.is_actual_box.CheckState = System.Windows.Forms.CheckState.Checked;
            this.is_actual_box.Font = new System.Drawing.Font("Georgia", 9F);
            this.is_actual_box.Location = new System.Drawing.Point(879, 110);
            this.is_actual_box.Name = "is_actual_box";
            this.is_actual_box.Size = new System.Drawing.Size(205, 19);
            this.is_actual_box.TabIndex = 41;
            this.is_actual_box.Text = "Скрыть старые типы занятий";
            this.is_actual_box.UseVisualStyleBackColor = true;
            // 
            // Show_types
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.is_actual_box);
            this.Controls.Add(this.create_cours);
            this.Controls.Add(this.types_list);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Show_types";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Показать типы занятий";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Show_types_FormClosing);
            this.Load += new System.EventHandler(this.Show_types_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView types_list;
        private System.Windows.Forms.Button create_cours;
        private System.Windows.Forms.CheckBox is_actual_box;
    }
}