
namespace NovaFlyClient
{
    partial class Registration
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
            this.Nam = new System.Windows.Forms.TextBox();
            this.Surname = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Cpass = new System.Windows.Forms.TextBox();
            this.ConfirmB = new System.Windows.Forms.Button();
            this.Имя = new System.Windows.Forms.Label();
            this.Фамилия = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Nam
            // 
            this.Nam.Location = new System.Drawing.Point(177, 93);
            this.Nam.Name = "Nam";
            this.Nam.Size = new System.Drawing.Size(100, 20);
            this.Nam.TabIndex = 0;
            // 
            // Surname
            // 
            this.Surname.Location = new System.Drawing.Point(177, 142);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(100, 20);
            this.Surname.TabIndex = 1;
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(177, 181);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(100, 20);
            this.Email.TabIndex = 2;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(177, 224);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(100, 20);
            this.Password.TabIndex = 3;
            // 
            // Cpass
            // 
            this.Cpass.Location = new System.Drawing.Point(177, 261);
            this.Cpass.Name = "Cpass";
            this.Cpass.Size = new System.Drawing.Size(100, 20);
            this.Cpass.TabIndex = 4;
            // 
            // ConfirmB
            // 
            this.ConfirmB.Location = new System.Drawing.Point(115, 333);
            this.ConfirmB.Name = "ConfirmB";
            this.ConfirmB.Size = new System.Drawing.Size(135, 34);
            this.ConfirmB.TabIndex = 5;
            this.ConfirmB.Text = "Зарегистрироваться";
            this.ConfirmB.UseVisualStyleBackColor = true;
            this.ConfirmB.Click += new System.EventHandler(this.ConfirmB_Click);
            // 
            // Имя
            // 
            this.Имя.AutoSize = true;
            this.Имя.Location = new System.Drawing.Point(62, 99);
            this.Имя.Name = "Имя";
            this.Имя.Size = new System.Drawing.Size(29, 13);
            this.Имя.TabIndex = 6;
            this.Имя.Text = "Имя";
            // 
            // Фамилия
            // 
            this.Фамилия.AutoSize = true;
            this.Фамилия.Location = new System.Drawing.Point(62, 149);
            this.Фамилия.Name = "Фамилия";
            this.Фамилия.Size = new System.Drawing.Size(56, 13);
            this.Фамилия.TabIndex = 7;
            this.Фамилия.Text = "Фамилия";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Почта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Повторный пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Пароль";
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Фамилия);
            this.Controls.Add(this.Имя);
            this.Controls.Add(this.ConfirmB);
            this.Controls.Add(this.Cpass);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.Nam);
            this.Name = "Registration";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Nam;
        private System.Windows.Forms.TextBox Surname;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Cpass;
        private System.Windows.Forms.Button ConfirmB;
        private System.Windows.Forms.Label Имя;
        private System.Windows.Forms.Label Фамилия;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}