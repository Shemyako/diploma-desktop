
namespace pesopolis
{
    partial class Lessons
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lessons));
            this.lessons_list = new System.Windows.Forms.ListView();
            this.date_picker = new System.Windows.Forms.DateTimePicker();
            this.staff_comboBox = new System.Windows.Forms.ComboBox();
            this.dogs_list = new System.Windows.Forms.ListView();
            this.is_actual_box = new System.Windows.Forms.CheckBox();
            this.lesson_time = new System.Windows.Forms.DateTimePicker();
            this.place_combobox = new System.Windows.Forms.ComboBox();
            this.add_to_list_bttn = new System.Windows.Forms.Button();
            this.save_bttn = new System.Windows.Forms.Button();
            this.cancel_bttn = new System.Windows.Forms.Button();
            this.type_of_lesson_combobox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // lessons_list
            // 
            this.lessons_list.HideSelection = false;
            this.lessons_list.Location = new System.Drawing.Point(190, 154);
            this.lessons_list.Name = "lessons_list";
            this.lessons_list.Size = new System.Drawing.Size(587, 372);
            this.lessons_list.TabIndex = 32;
            this.lessons_list.UseCompatibleStateImageBehavior = false;
            this.lessons_list.DoubleClick += new System.EventHandler(this.lessons_list_DoubleClick);
            // 
            // date_picker
            // 
            this.date_picker.Checked = false;
            this.date_picker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_picker.Location = new System.Drawing.Point(447, 128);
            this.date_picker.Name = "date_picker";
            this.date_picker.Size = new System.Drawing.Size(92, 20);
            this.date_picker.TabIndex = 33;
            this.date_picker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.date_picker_KeyDown);
            // 
            // staff_comboBox
            // 
            this.staff_comboBox.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.staff_comboBox.FormattingEnabled = true;
            this.staff_comboBox.Location = new System.Drawing.Point(190, 124);
            this.staff_comboBox.Name = "staff_comboBox";
            this.staff_comboBox.Size = new System.Drawing.Size(251, 24);
            this.staff_comboBox.TabIndex = 34;
            this.staff_comboBox.SelectedIndexChanged += new System.EventHandler(this.staff_comboBox_SelectedIndexChanged);
            // 
            // dogs_list
            // 
            this.dogs_list.HideSelection = false;
            this.dogs_list.Location = new System.Drawing.Point(858, 154);
            this.dogs_list.Name = "dogs_list";
            this.dogs_list.Size = new System.Drawing.Size(394, 372);
            this.dogs_list.TabIndex = 32;
            this.dogs_list.UseCompatibleStateImageBehavior = false;
            this.dogs_list.Click += new System.EventHandler(this.dogs_list_DoubleClick);
            // 
            // is_actual_box
            // 
            this.is_actual_box.AutoSize = true;
            this.is_actual_box.Location = new System.Drawing.Point(858, 133);
            this.is_actual_box.Name = "is_actual_box";
            this.is_actual_box.Size = new System.Drawing.Size(138, 17);
            this.is_actual_box.TabIndex = 35;
            this.is_actual_box.Text = "Выбранного кинолога";
            this.is_actual_box.UseVisualStyleBackColor = true;
            this.is_actual_box.CheckedChanged += new System.EventHandler(this.is_actual_box_CheckedChanged);
            // 
            // lesson_time
            // 
            this.lesson_time.CalendarFont = new System.Drawing.Font("Georgia", 10F);
            this.lesson_time.Checked = false;
            this.lesson_time.CustomFormat = "HH:mm";
            this.lesson_time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.lesson_time.Location = new System.Drawing.Point(1172, 532);
            this.lesson_time.Name = "lesson_time";
            this.lesson_time.ShowUpDown = true;
            this.lesson_time.Size = new System.Drawing.Size(80, 20);
            this.lesson_time.TabIndex = 33;
            // 
            // place_combobox
            // 
            this.place_combobox.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.place_combobox.FormattingEnabled = true;
            this.place_combobox.Location = new System.Drawing.Point(1055, 558);
            this.place_combobox.Name = "place_combobox";
            this.place_combobox.Size = new System.Drawing.Size(197, 24);
            this.place_combobox.TabIndex = 34;
            // 
            // add_to_list_bttn
            // 
            this.add_to_list_bttn.Font = new System.Drawing.Font("Georgia", 10F);
            this.add_to_list_bttn.Location = new System.Drawing.Point(858, 532);
            this.add_to_list_bttn.Name = "add_to_list_bttn";
            this.add_to_list_bttn.Size = new System.Drawing.Size(85, 34);
            this.add_to_list_bttn.TabIndex = 36;
            this.add_to_list_bttn.Text = "Создать";
            this.add_to_list_bttn.UseVisualStyleBackColor = true;
            this.add_to_list_bttn.Click += new System.EventHandler(this.add_to_list_bttn_Click);
            // 
            // save_bttn
            // 
            this.save_bttn.BackColor = System.Drawing.Color.LawnGreen;
            this.save_bttn.FlatAppearance.BorderSize = 0;
            this.save_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_bttn.Font = new System.Drawing.Font("Georgia", 10F);
            this.save_bttn.Location = new System.Drawing.Point(190, 532);
            this.save_bttn.Name = "save_bttn";
            this.save_bttn.Size = new System.Drawing.Size(90, 34);
            this.save_bttn.TabIndex = 37;
            this.save_bttn.Text = "Сохранить";
            this.save_bttn.UseVisualStyleBackColor = false;
            this.save_bttn.Click += new System.EventHandler(this.save_bttn_Click);
            // 
            // cancel_bttn
            // 
            this.cancel_bttn.BackColor = System.Drawing.Color.Brown;
            this.cancel_bttn.FlatAppearance.BorderSize = 0;
            this.cancel_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_bttn.Font = new System.Drawing.Font("Georgia", 10F);
            this.cancel_bttn.Location = new System.Drawing.Point(612, 532);
            this.cancel_bttn.Name = "cancel_bttn";
            this.cancel_bttn.Size = new System.Drawing.Size(85, 34);
            this.cancel_bttn.TabIndex = 37;
            this.cancel_bttn.Text = "Отменить";
            this.cancel_bttn.UseVisualStyleBackColor = false;
            this.cancel_bttn.Click += new System.EventHandler(this.cancel_bttn_Click);
            // 
            // type_of_lesson_combobox
            // 
            this.type_of_lesson_combobox.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.type_of_lesson_combobox.FormattingEnabled = true;
            this.type_of_lesson_combobox.Location = new System.Drawing.Point(1055, 588);
            this.type_of_lesson_combobox.Name = "type_of_lesson_combobox";
            this.type_of_lesson_combobox.Size = new System.Drawing.Size(197, 24);
            this.type_of_lesson_combobox.TabIndex = 34;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(13, 173);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(149, 496);
            this.panel1.TabIndex = 38;
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
            // Lessons
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cancel_bttn);
            this.Controls.Add(this.save_bttn);
            this.Controls.Add(this.add_to_list_bttn);
            this.Controls.Add(this.is_actual_box);
            this.Controls.Add(this.type_of_lesson_combobox);
            this.Controls.Add(this.place_combobox);
            this.Controls.Add(this.staff_comboBox);
            this.Controls.Add(this.lesson_time);
            this.Controls.Add(this.date_picker);
            this.Controls.Add(this.dogs_list);
            this.Controls.Add(this.lessons_list);
            this.Controls.Add(this.logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Lessons";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Занятия";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Lessons_FormClosing);
            this.Load += new System.EventHandler(this.Lessons_Load);
            this.Shown += new System.EventHandler(this.Lessons_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.ListView lessons_list;
        private System.Windows.Forms.DateTimePicker date_picker;
        private System.Windows.Forms.ComboBox staff_comboBox;
        private System.Windows.Forms.ListView dogs_list;
        private System.Windows.Forms.CheckBox is_actual_box;
        private System.Windows.Forms.DateTimePicker lesson_time;
        private System.Windows.Forms.ComboBox place_combobox;
        private System.Windows.Forms.Button add_to_list_bttn;
        private System.Windows.Forms.Button save_bttn;
        private System.Windows.Forms.Button cancel_bttn;
        private System.Windows.Forms.ComboBox type_of_lesson_combobox;
        private System.Windows.Forms.Panel panel1;
    }
}