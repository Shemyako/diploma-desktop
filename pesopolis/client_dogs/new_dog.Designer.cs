
namespace pesopolis
{
    partial class New_dog
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
            this.save_bttn = new System.Windows.Forms.Button();
            this.breed_textbox = new System.Windows.Forms.TextBox();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.staff_comboBox = new System.Windows.Forms.ComboBox();
            this.place_comboBox = new System.Windows.Forms.ComboBox();
            this.cours_comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.dogs_list = new System.Windows.Forms.ListView();
            this.phone_textBox = new System.Windows.Forms.TextBox();
            this.find_user_bttn = new System.Windows.Forms.Button();
            this.change_mod_bttn = new System.Windows.Forms.Button();
            this.is_actual_box = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // save_bttn
            // 
            this.save_bttn.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save_bttn.Location = new System.Drawing.Point(217, 391);
            this.save_bttn.Name = "save_bttn";
            this.save_bttn.Size = new System.Drawing.Size(159, 51);
            this.save_bttn.TabIndex = 14;
            this.save_bttn.Text = "Сохранить";
            this.save_bttn.UseVisualStyleBackColor = true;
            this.save_bttn.Click += new System.EventHandler(this.save_bttn_Click);
            // 
            // breed_textbox
            // 
            this.breed_textbox.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.breed_textbox.Location = new System.Drawing.Point(217, 142);
            this.breed_textbox.Name = "breed_textbox";
            this.breed_textbox.Size = new System.Drawing.Size(251, 23);
            this.breed_textbox.TabIndex = 10;
            this.breed_textbox.Text = "Порода";
            // 
            // name_textbox
            // 
            this.name_textbox.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_textbox.Location = new System.Drawing.Point(217, 97);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(251, 23);
            this.name_textbox.TabIndex = 9;
            this.name_textbox.Text = "Кличка";
            // 
            // staff_comboBox
            // 
            this.staff_comboBox.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.staff_comboBox.FormattingEnabled = true;
            this.staff_comboBox.Location = new System.Drawing.Point(217, 195);
            this.staff_comboBox.Name = "staff_comboBox";
            this.staff_comboBox.Size = new System.Drawing.Size(251, 24);
            this.staff_comboBox.TabIndex = 15;
            // 
            // place_comboBox
            // 
            this.place_comboBox.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.place_comboBox.FormattingEnabled = true;
            this.place_comboBox.Location = new System.Drawing.Point(217, 248);
            this.place_comboBox.Name = "place_comboBox";
            this.place_comboBox.Size = new System.Drawing.Size(251, 24);
            this.place_comboBox.TabIndex = 16;
            // 
            // cours_comboBox
            // 
            this.cours_comboBox.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cours_comboBox.FormattingEnabled = true;
            this.cours_comboBox.Location = new System.Drawing.Point(217, 306);
            this.cours_comboBox.Name = "cours_comboBox";
            this.cours_comboBox.Size = new System.Drawing.Size(251, 24);
            this.cours_comboBox.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Menu";
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
            // dogs_list
            // 
            this.dogs_list.HideSelection = false;
            this.dogs_list.Location = new System.Drawing.Point(542, 94);
            this.dogs_list.Name = "dogs_list";
            this.dogs_list.Size = new System.Drawing.Size(710, 372);
            this.dogs_list.TabIndex = 30;
            this.dogs_list.UseCompatibleStateImageBehavior = false;
            this.dogs_list.DoubleClick += new System.EventHandler(this.dogs_list_DoubleClick);
            // 
            // phone_textBox
            // 
            this.phone_textBox.Enabled = false;
            this.phone_textBox.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phone_textBox.Location = new System.Drawing.Point(542, 65);
            this.phone_textBox.Name = "phone_textBox";
            this.phone_textBox.Size = new System.Drawing.Size(251, 23);
            this.phone_textBox.TabIndex = 9;
            this.phone_textBox.Text = "Телефон";
            // 
            // find_user_bttn
            // 
            this.find_user_bttn.Enabled = false;
            this.find_user_bttn.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.find_user_bttn.Location = new System.Drawing.Point(799, 65);
            this.find_user_bttn.Name = "find_user_bttn";
            this.find_user_bttn.Size = new System.Drawing.Size(137, 23);
            this.find_user_bttn.TabIndex = 14;
            this.find_user_bttn.Text = "Найти";
            this.find_user_bttn.UseVisualStyleBackColor = true;
            this.find_user_bttn.Click += new System.EventHandler(this.find_bttn_Click);
            // 
            // change_mod_bttn
            // 
            this.change_mod_bttn.Enabled = false;
            this.change_mod_bttn.Font = new System.Drawing.Font("Georgia", 10F);
            this.change_mod_bttn.Location = new System.Drawing.Point(1093, 45);
            this.change_mod_bttn.Name = "change_mod_bttn";
            this.change_mod_bttn.Size = new System.Drawing.Size(159, 43);
            this.change_mod_bttn.TabIndex = 31;
            this.change_mod_bttn.Text = "Добавить хозяев";
            this.change_mod_bttn.UseVisualStyleBackColor = true;
            this.change_mod_bttn.Click += new System.EventHandler(this.button1_Click);
            // 
            // is_actual_box
            // 
            this.is_actual_box.AutoSize = true;
            this.is_actual_box.Checked = true;
            this.is_actual_box.CheckState = System.Windows.Forms.CheckState.Checked;
            this.is_actual_box.Location = new System.Drawing.Point(217, 74);
            this.is_actual_box.Name = "is_actual_box";
            this.is_actual_box.Size = new System.Drawing.Size(79, 17);
            this.is_actual_box.TabIndex = 34;
            this.is_actual_box.Text = "Обучается";
            this.is_actual_box.UseVisualStyleBackColor = true;
            // 
            // New_dog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.is_actual_box);
            this.Controls.Add(this.change_mod_bttn);
            this.Controls.Add(this.dogs_list);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cours_comboBox);
            this.Controls.Add(this.place_comboBox);
            this.Controls.Add(this.staff_comboBox);
            this.Controls.Add(this.find_user_bttn);
            this.Controls.Add(this.save_bttn);
            this.Controls.Add(this.breed_textbox);
            this.Controls.Add(this.phone_textBox);
            this.Controls.Add(this.name_textbox);
            this.Controls.Add(this.logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "New_dog";
            this.Text = "Редактор собак";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.New_dog_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button save_bttn;
        private System.Windows.Forms.TextBox breed_textbox;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.ComboBox staff_comboBox;
        private System.Windows.Forms.ComboBox place_comboBox;
        private System.Windows.Forms.ComboBox cours_comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView dogs_list;
        private System.Windows.Forms.TextBox phone_textBox;
        private System.Windows.Forms.Button find_user_bttn;
        private System.Windows.Forms.Button change_mod_bttn;
        private System.Windows.Forms.CheckBox is_actual_box;
    }
}