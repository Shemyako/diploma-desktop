
namespace pesopolis
{
    partial class Salary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Salary));
            this.panel1 = new System.Windows.Forms.Panel();
            this.staff_comboBox = new System.Windows.Forms.ComboBox();
            this.date_picker = new System.Windows.Forms.DateTimePicker();
            this.lessons_list = new System.Windows.Forms.ListView();
            this.total_salary_lbl = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(13, 173);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(149, 496);
            this.panel1.TabIndex = 40;
            // 
            // staff_comboBox
            // 
            this.staff_comboBox.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.staff_comboBox.FormattingEnabled = true;
            this.staff_comboBox.Location = new System.Drawing.Point(346, 143);
            this.staff_comboBox.Name = "staff_comboBox";
            this.staff_comboBox.Size = new System.Drawing.Size(251, 24);
            this.staff_comboBox.TabIndex = 43;
            this.staff_comboBox.SelectedIndexChanged += new System.EventHandler(this.staff_comboBox_SelectedIndexChanged);
            // 
            // date_picker
            // 
            this.date_picker.Checked = false;
            this.date_picker.CustomFormat = "MM.yyyy";
            this.date_picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_picker.Location = new System.Drawing.Point(603, 147);
            this.date_picker.Name = "date_picker";
            this.date_picker.Size = new System.Drawing.Size(92, 20);
            this.date_picker.TabIndex = 42;
            this.date_picker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.date_picker_KeyDown);
            // 
            // lessons_list
            // 
            this.lessons_list.HideSelection = false;
            this.lessons_list.Location = new System.Drawing.Point(346, 173);
            this.lessons_list.Name = "lessons_list";
            this.lessons_list.Size = new System.Drawing.Size(587, 372);
            this.lessons_list.TabIndex = 41;
            this.lessons_list.UseCompatibleStateImageBehavior = false;
            this.lessons_list.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lessons_list_ColumnClick);
            // 
            // total_salary_lbl
            // 
            this.total_salary_lbl.AutoSize = true;
            this.total_salary_lbl.Font = new System.Drawing.Font("Georgia", 10F);
            this.total_salary_lbl.Location = new System.Drawing.Point(939, 528);
            this.total_salary_lbl.Name = "total_salary_lbl";
            this.total_salary_lbl.Size = new System.Drawing.Size(54, 17);
            this.total_salary_lbl.TabIndex = 46;
            this.total_salary_lbl.Text = "Итого:";
            // 
            // logo
            // 
            this.logo.Image = global::pesopolis.Properties.Resources.logo;
            this.logo.Location = new System.Drawing.Point(13, 14);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(149, 153);
            this.logo.TabIndex = 39;
            this.logo.TabStop = false;
            // 
            // Salary
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.total_salary_lbl);
            this.Controls.Add(this.staff_comboBox);
            this.Controls.Add(this.date_picker);
            this.Controls.Add(this.lessons_list);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Salary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Зарплата";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Salary_FormClosing);
            this.Shown += new System.EventHandler(this.Salary_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.ComboBox staff_comboBox;
        private System.Windows.Forms.DateTimePicker date_picker;
        private System.Windows.Forms.ListView lessons_list;
        private System.Windows.Forms.Label total_salary_lbl;
    }
}