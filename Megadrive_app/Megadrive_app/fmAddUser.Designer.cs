namespace Megadrive_app
{
    partial class fmAddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmAddUser));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelCompanyName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxAddLogin = new System.Windows.Forms.TextBox();
            this.labelAddLogin = new System.Windows.Forms.Label();
            this.textBoxAddPassword = new System.Windows.Forms.TextBox();
            this.labelAddPassword = new System.Windows.Forms.Label();
            this.textBoxAddPasswordX2 = new System.Windows.Forms.TextBox();
            this.labelAddPasswordX2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAddClientID = new System.Windows.Forms.TextBox();
            this.labelAddClientID = new System.Windows.Forms.Label();
            this.comboBoxAddRole = new System.Windows.Forms.ComboBox();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(37)))), ((int)(((byte)(181)))));
            this.panel1.Controls.Add(this.pictureBoxLogo);
            this.panel1.Controls.Add(this.labelCompanyName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 50);
            this.panel1.TabIndex = 4;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::Megadrive_app.Properties.Resources.логотип;
            this.pictureBoxLogo.Location = new System.Drawing.Point(1, 1);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(50, 48);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 1;
            this.pictureBoxLogo.TabStop = false;
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.AutoSize = true;
            this.labelCompanyName.Font = new System.Drawing.Font("Gabriola", 20F);
            this.labelCompanyName.Location = new System.Drawing.Point(57, 1);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new System.Drawing.Size(226, 50);
            this.labelCompanyName.TabIndex = 0;
            this.labelCompanyName.Text = "Компания \"Мегадрайв\"";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(37)))), ((int)(((byte)(181)))));
            this.panel2.Controls.Add(this.buttonBack);
            this.panel2.Controls.Add(this.buttonAddUser);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 418);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(365, 50);
            this.panel2.TabIndex = 5;
            // 
            // textBoxAddLogin
            // 
            this.textBoxAddLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(192)))), ((int)(((byte)(190)))));
            this.textBoxAddLogin.Font = new System.Drawing.Font("Gabriola", 10F);
            this.textBoxAddLogin.Location = new System.Drawing.Point(199, 80);
            this.textBoxAddLogin.Name = "textBoxAddLogin";
            this.textBoxAddLogin.Size = new System.Drawing.Size(146, 30);
            this.textBoxAddLogin.TabIndex = 9;
            // 
            // labelAddLogin
            // 
            this.labelAddLogin.AutoSize = true;
            this.labelAddLogin.Font = new System.Drawing.Font("Gabriola", 20F);
            this.labelAddLogin.Location = new System.Drawing.Point(12, 66);
            this.labelAddLogin.Name = "labelAddLogin";
            this.labelAddLogin.Size = new System.Drawing.Size(75, 50);
            this.labelAddLogin.TabIndex = 8;
            this.labelAddLogin.Text = "Логин";
            // 
            // textBoxAddPassword
            // 
            this.textBoxAddPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(192)))), ((int)(((byte)(190)))));
            this.textBoxAddPassword.Font = new System.Drawing.Font("Gabriola", 10F);
            this.textBoxAddPassword.Location = new System.Drawing.Point(199, 136);
            this.textBoxAddPassword.Name = "textBoxAddPassword";
            this.textBoxAddPassword.Size = new System.Drawing.Size(146, 30);
            this.textBoxAddPassword.TabIndex = 11;
            // 
            // labelAddPassword
            // 
            this.labelAddPassword.AutoSize = true;
            this.labelAddPassword.Font = new System.Drawing.Font("Gabriola", 20F);
            this.labelAddPassword.Location = new System.Drawing.Point(12, 116);
            this.labelAddPassword.Name = "labelAddPassword";
            this.labelAddPassword.Size = new System.Drawing.Size(86, 50);
            this.labelAddPassword.TabIndex = 10;
            this.labelAddPassword.Text = "Пароль";
            // 
            // textBoxAddPasswordX2
            // 
            this.textBoxAddPasswordX2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(192)))), ((int)(((byte)(190)))));
            this.textBoxAddPasswordX2.Font = new System.Drawing.Font("Gabriola", 10F);
            this.textBoxAddPasswordX2.Location = new System.Drawing.Point(199, 201);
            this.textBoxAddPasswordX2.Name = "textBoxAddPasswordX2";
            this.textBoxAddPasswordX2.Size = new System.Drawing.Size(146, 30);
            this.textBoxAddPasswordX2.TabIndex = 13;
            // 
            // labelAddPasswordX2
            // 
            this.labelAddPasswordX2.AutoSize = true;
            this.labelAddPasswordX2.Font = new System.Drawing.Font("Gabriola", 20F);
            this.labelAddPasswordX2.Location = new System.Drawing.Point(12, 181);
            this.labelAddPasswordX2.Name = "labelAddPasswordX2";
            this.labelAddPasswordX2.Size = new System.Drawing.Size(193, 50);
            this.labelAddPasswordX2.TabIndex = 12;
            this.labelAddPasswordX2.Text = "Повторите пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gabriola", 20F);
            this.label3.Location = new System.Drawing.Point(12, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 50);
            this.label3.TabIndex = 14;
            this.label3.Text = "Роль";
            // 
            // textBoxAddClientID
            // 
            this.textBoxAddClientID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(192)))), ((int)(((byte)(190)))));
            this.textBoxAddClientID.Font = new System.Drawing.Font("Gabriola", 10F);
            this.textBoxAddClientID.Location = new System.Drawing.Point(199, 312);
            this.textBoxAddClientID.Name = "textBoxAddClientID";
            this.textBoxAddClientID.Size = new System.Drawing.Size(146, 30);
            this.textBoxAddClientID.TabIndex = 17;
            // 
            // labelAddClientID
            // 
            this.labelAddClientID.AutoSize = true;
            this.labelAddClientID.Font = new System.Drawing.Font("Gabriola", 20F);
            this.labelAddClientID.Location = new System.Drawing.Point(12, 292);
            this.labelAddClientID.Name = "labelAddClientID";
            this.labelAddClientID.Size = new System.Drawing.Size(122, 50);
            this.labelAddClientID.TabIndex = 16;
            this.labelAddClientID.Text = "Id Клиента";
            // 
            // comboBoxAddRole
            // 
            this.comboBoxAddRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(192)))), ((int)(((byte)(190)))));
            this.comboBoxAddRole.Font = new System.Drawing.Font("Gabriola", 10F);
            this.comboBoxAddRole.FormattingEnabled = true;
            this.comboBoxAddRole.Items.AddRange(new object[] {
            "Администратор",
            "Менеджер",
            "Клиент"});
            this.comboBoxAddRole.Location = new System.Drawing.Point(199, 242);
            this.comboBoxAddRole.Name = "comboBoxAddRole";
            this.comboBoxAddRole.Size = new System.Drawing.Size(146, 31);
            this.comboBoxAddRole.TabIndex = 18;
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(192)))), ((int)(((byte)(190)))));
            this.buttonAddUser.Font = new System.Drawing.Font("Gabriola", 14F);
            this.buttonAddUser.Location = new System.Drawing.Point(239, 6);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(114, 41);
            this.buttonAddUser.TabIndex = 19;
            this.buttonAddUser.Text = "Добавить";
            this.buttonAddUser.UseVisualStyleBackColor = false;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(192)))), ((int)(((byte)(190)))));
            this.buttonBack.Font = new System.Drawing.Font("Gabriola", 14F);
            this.buttonBack.Location = new System.Drawing.Point(3, 6);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(114, 41);
            this.buttonBack.TabIndex = 20;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // fmAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 468);
            this.Controls.Add(this.comboBoxAddRole);
            this.Controls.Add(this.textBoxAddClientID);
            this.Controls.Add(this.labelAddClientID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxAddPasswordX2);
            this.Controls.Add(this.labelAddPasswordX2);
            this.Controls.Add(this.textBoxAddPassword);
            this.Controls.Add(this.labelAddPassword);
            this.Controls.Add(this.textBoxAddLogin);
            this.Controls.Add(this.labelAddLogin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fmAddUser";
            this.Text = "Add User";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelCompanyName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxAddLogin;
        private System.Windows.Forms.Label labelAddLogin;
        private System.Windows.Forms.TextBox textBoxAddPassword;
        private System.Windows.Forms.Label labelAddPassword;
        private System.Windows.Forms.TextBox textBoxAddPasswordX2;
        private System.Windows.Forms.Label labelAddPasswordX2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAddClientID;
        private System.Windows.Forms.Label labelAddClientID;
        private System.Windows.Forms.ComboBox comboBoxAddRole;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonAddUser;
    }
}