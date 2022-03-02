
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
            this.logo = new System.Windows.Forms.PictureBox();
            this.lessons_list = new System.Windows.Forms.ListView();
            this.date_picker = new System.Windows.Forms.DateTimePicker();
            this.staff_comboBox = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.is_actual_box = new System.Windows.Forms.CheckBox();
            this.lesson_time = new System.Windows.Forms.DateTimePicker();
            this.place_combobox = new System.Windows.Forms.ComboBox();
            this.type_of_lesson = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            // lessons_list
            // 
            this.lessons_list.HideSelection = false;
            this.lessons_list.Location = new System.Drawing.Point(221, 154);
            this.lessons_list.Name = "lessons_list";
            this.lessons_list.Size = new System.Drawing.Size(349, 372);
            this.lessons_list.TabIndex = 32;
            this.lessons_list.UseCompatibleStateImageBehavior = false;
            // 
            // date_picker
            // 
            this.date_picker.Checked = false;
            this.date_picker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_picker.Location = new System.Drawing.Point(478, 128);
            this.date_picker.Name = "date_picker";
            this.date_picker.Size = new System.Drawing.Size(92, 20);
            this.date_picker.TabIndex = 33;
            // 
            // staff_comboBox
            // 
            this.staff_comboBox.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.staff_comboBox.FormattingEnabled = true;
            this.staff_comboBox.Location = new System.Drawing.Point(221, 124);
            this.staff_comboBox.Name = "staff_comboBox";
            this.staff_comboBox.Size = new System.Drawing.Size(251, 24);
            this.staff_comboBox.TabIndex = 34;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(903, 154);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(349, 372);
            this.listView1.TabIndex = 32;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // is_actual_box
            // 
            this.is_actual_box.AutoSize = true;
            this.is_actual_box.Checked = true;
            this.is_actual_box.CheckState = System.Windows.Forms.CheckState.Checked;
            this.is_actual_box.Location = new System.Drawing.Point(903, 133);
            this.is_actual_box.Name = "is_actual_box";
            this.is_actual_box.Size = new System.Drawing.Size(138, 17);
            this.is_actual_box.TabIndex = 35;
            this.is_actual_box.Text = "Выбранного кинолога";
            this.is_actual_box.UseVisualStyleBackColor = true;
            // 
            // lesson_time
            // 
            this.lesson_time.CalendarFont = new System.Drawing.Font("Georgia", 10F);
            this.lesson_time.Checked = false;
            this.lesson_time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.lesson_time.Location = new System.Drawing.Point(786, 154);
            this.lesson_time.Name = "lesson_time";
            this.lesson_time.Size = new System.Drawing.Size(111, 20);
            this.lesson_time.TabIndex = 33;
            // 
            // place_combobox
            // 
            this.place_combobox.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.place_combobox.FormattingEnabled = true;
            this.place_combobox.Location = new System.Drawing.Point(646, 180);
            this.place_combobox.Name = "place_combobox";
            this.place_combobox.Size = new System.Drawing.Size(251, 24);
            this.place_combobox.TabIndex = 34;
            // 
            // type_of_lesson
            // 
            this.type_of_lesson.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.type_of_lesson.FormattingEnabled = true;
            this.type_of_lesson.Location = new System.Drawing.Point(646, 210);
            this.type_of_lesson.Name = "type_of_lesson";
            this.type_of_lesson.Size = new System.Drawing.Size(251, 24);
            this.type_of_lesson.TabIndex = 34;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Georgia", 10F);
            this.button1.Location = new System.Drawing.Point(903, 532);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 36;
            this.button1.Text = "Создать";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LawnGreen;
            this.button2.Font = new System.Drawing.Font("Georgia", 10F);
            this.button2.Location = new System.Drawing.Point(221, 532);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 34);
            this.button2.TabIndex = 37;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Brown;
            this.button3.Font = new System.Drawing.Font("Georgia", 10F);
            this.button3.Location = new System.Drawing.Point(485, 532);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 34);
            this.button3.TabIndex = 37;
            this.button3.Text = "Отменить";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // Lessons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.is_actual_box);
            this.Controls.Add(this.type_of_lesson);
            this.Controls.Add(this.place_combobox);
            this.Controls.Add(this.staff_comboBox);
            this.Controls.Add(this.lesson_time);
            this.Controls.Add(this.date_picker);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lessons_list);
            this.Controls.Add(this.logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Lessons";
            this.Text = "Lessons";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.ListView lessons_list;
        private System.Windows.Forms.DateTimePicker date_picker;
        private System.Windows.Forms.ComboBox staff_comboBox;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.CheckBox is_actual_box;
        private System.Windows.Forms.DateTimePicker lesson_time;
        private System.Windows.Forms.ComboBox place_combobox;
        private System.Windows.Forms.ComboBox type_of_lesson;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}