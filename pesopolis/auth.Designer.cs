
namespace pesopolis
{
    partial class Auth_form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Auth_form));
            this.auth_lbl = new System.Windows.Forms.Label();
            this.login_lbl = new System.Windows.Forms.Label();
            this.pswrd_lbl = new System.Windows.Forms.Label();
            this.login_box = new System.Windows.Forms.TextBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.logo_pic = new System.Windows.Forms.PictureBox();
            this.password_box = new System.Windows.Forms.TextBox();
            this.auth_bttn = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // auth_lbl
            // 
            this.auth_lbl.AutoSize = true;
            this.auth_lbl.Font = new System.Drawing.Font("Georgia", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.auth_lbl.Location = new System.Drawing.Point(426, 88);
            this.auth_lbl.Name = "auth_lbl";
            this.auth_lbl.Size = new System.Drawing.Size(422, 72);
            this.auth_lbl.TabIndex = 1;
            this.auth_lbl.Text = "Авторизация";
            // 
            // login_lbl
            // 
            this.login_lbl.AutoSize = true;
            this.login_lbl.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_lbl.Location = new System.Drawing.Point(217, 232);
            this.login_lbl.Margin = new System.Windows.Forms.Padding(0);
            this.login_lbl.Name = "login_lbl";
            this.login_lbl.Size = new System.Drawing.Size(165, 56);
            this.login_lbl.TabIndex = 2;
            this.login_lbl.Text = "Логин";
            // 
            // pswrd_lbl
            // 
            this.pswrd_lbl.AutoSize = true;
            this.pswrd_lbl.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pswrd_lbl.Location = new System.Drawing.Point(217, 373);
            this.pswrd_lbl.Name = "pswrd_lbl";
            this.pswrd_lbl.Size = new System.Drawing.Size(192, 56);
            this.pswrd_lbl.TabIndex = 3;
            this.pswrd_lbl.Text = "Пароль";
            // 
            // login_box
            // 
            this.login_box.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_box.Location = new System.Drawing.Point(432, 238);
            this.login_box.Name = "login_box";
            this.login_box.Size = new System.Drawing.Size(416, 62);
            this.login_box.TabIndex = 4;
            // 
            // logo
            // 
            this.logo.Image = global::pesopolis.Properties.Resources.logo;
            this.logo.Location = new System.Drawing.Point(13, 14);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(149, 153);
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // logo_pic
            // 
            this.logo_pic.Location = new System.Drawing.Point(31, 29);
            this.logo_pic.Name = "logo_pic";
            this.logo_pic.Size = new System.Drawing.Size(149, 153);
            this.logo_pic.TabIndex = 0;
            this.logo_pic.TabStop = false;
            // 
            // password_box
            // 
            this.password_box.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password_box.Location = new System.Drawing.Point(432, 378);
            this.password_box.Name = "password_box";
            this.password_box.Size = new System.Drawing.Size(416, 62);
            this.password_box.TabIndex = 5;
            // 
            // auth_bttn
            // 
            this.auth_bttn.BackColor = System.Drawing.Color.White;
            this.auth_bttn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.auth_bttn.Font = new System.Drawing.Font("Georgia", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.auth_bttn.Location = new System.Drawing.Point(374, 519);
            this.auth_bttn.Name = "auth_bttn";
            this.auth_bttn.Size = new System.Drawing.Size(532, 100);
            this.auth_bttn.TabIndex = 6;
            this.auth_bttn.Text = "Подтвердить";
            this.auth_bttn.UseVisualStyleBackColor = false;
            this.auth_bttn.Click += new System.EventHandler(this.auth_bttn_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Отобразить меню";
            this.notifyIcon1.Visible = true;
            // 
            // Auth_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.auth_bttn);
            this.Controls.Add(this.password_box);
            this.Controls.Add(this.login_box);
            this.Controls.Add(this.pswrd_lbl);
            this.Controls.Add(this.login_lbl);
            this.Controls.Add(this.auth_lbl);
            this.Controls.Add(this.logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Auth_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Авторизация";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label auth_lbl;
        private System.Windows.Forms.PictureBox logo_pic;
        private System.Windows.Forms.Label login_lbl;
        private System.Windows.Forms.Label pswrd_lbl;
        private System.Windows.Forms.TextBox login_box;
        private System.Windows.Forms.TextBox password_box;
        private System.Windows.Forms.Button auth_bttn;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

