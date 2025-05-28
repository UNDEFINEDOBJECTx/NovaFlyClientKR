
namespace NovaFlyClient
{
    partial class Login
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
            this.LoginB = new System.Windows.Forms.Button();
            this.Email = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Имя = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginB
            // 
            this.LoginB.Location = new System.Drawing.Point(139, 244);
            this.LoginB.Name = "LoginB";
            this.LoginB.Size = new System.Drawing.Size(75, 23);
            this.LoginB.TabIndex = 0;
            this.LoginB.Text = "Войти";
            this.LoginB.UseVisualStyleBackColor = true;
            this.LoginB.Click += new System.EventHandler(this.LoginB_Click);
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(139, 94);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(100, 20);
            this.Email.TabIndex = 1;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(139, 143);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(100, 20);
            this.Password.TabIndex = 2;
            // 
            // Имя
            // 
            this.Имя.AutoSize = true;
            this.Имя.Location = new System.Drawing.Point(65, 97);
            this.Имя.Name = "Имя";
            this.Имя.Size = new System.Drawing.Size(37, 13);
            this.Имя.TabIndex = 7;
            this.Имя.Text = "Почта";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Пароль";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 437);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Имя);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.LoginB);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginB;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label Имя;
        private System.Windows.Forms.Label label1;
    }
}