﻿
namespace NovaFlyClient
{
    partial class Passanger
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
            this.na = new System.Windows.Forms.TextBox();
            this.sur = new System.Windows.Forms.TextBox();
            this.patr = new System.Windows.Forms.TextBox();
            this.doc_num = new System.Windows.Forms.TextBox();
            this.brthday = new System.Windows.Forms.DateTimePicker();
            this.Confirm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // na
            // 
            this.na.Location = new System.Drawing.Point(96, 76);
            this.na.Name = "na";
            this.na.Size = new System.Drawing.Size(100, 20);
            this.na.TabIndex = 0;
            // 
            // sur
            // 
            this.sur.Location = new System.Drawing.Point(96, 112);
            this.sur.Name = "sur";
            this.sur.Size = new System.Drawing.Size(100, 20);
            this.sur.TabIndex = 1;
            // 
            // patr
            // 
            this.patr.Location = new System.Drawing.Point(96, 151);
            this.patr.Name = "patr";
            this.patr.Size = new System.Drawing.Size(100, 20);
            this.patr.TabIndex = 2;
            // 
            // doc_num
            // 
            this.doc_num.Location = new System.Drawing.Point(96, 189);
            this.doc_num.Name = "doc_num";
            this.doc_num.Size = new System.Drawing.Size(100, 20);
            this.doc_num.TabIndex = 3;
            // 
            // brthday
            // 
            this.brthday.Location = new System.Drawing.Point(96, 225);
            this.brthday.Name = "brthday";
            this.brthday.Size = new System.Drawing.Size(120, 20);
            this.brthday.TabIndex = 4;
            this.brthday.ValueChanged += new System.EventHandler(this.brthday_ValueChanged);
            // 
            // Confirm
            // 
            this.Confirm.Location = new System.Drawing.Point(186, 328);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(104, 60);
            this.Confirm.TabIndex = 5;
            this.Confirm.Text = "OK";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Имя*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Фамилия*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Номер документа*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(222, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Дата рождения*";
            // 
            // Passanger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.brthday);
            this.Controls.Add(this.doc_num);
            this.Controls.Add(this.patr);
            this.Controls.Add(this.sur);
            this.Controls.Add(this.na);
            this.Name = "Passanger";
            this.Text = "Passanger";
            this.Load += new System.EventHandler(this.Passanger_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox na;
        private System.Windows.Forms.TextBox sur;
        private System.Windows.Forms.TextBox patr;
        private System.Windows.Forms.TextBox doc_num;
        private System.Windows.Forms.DateTimePicker brthday;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}