
namespace NovaFlyClient
{
    partial class ChangePassenger
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
            this.pascol = new System.Windows.Forms.ComboBox();
            this.n1 = new System.Windows.Forms.TextBox();
            this.ptr1 = new System.Windows.Forms.TextBox();
            this.ptr2 = new System.Windows.Forms.TextBox();
            this.sn2 = new System.Windows.Forms.TextBox();
            this.sn1 = new System.Windows.Forms.TextBox();
            this.n2 = new System.Windows.Forms.TextBox();
            this.dn1 = new System.Windows.Forms.TextBox();
            this.dn2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chang = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pascol
            // 
            this.pascol.FormattingEnabled = true;
            this.pascol.Location = new System.Drawing.Point(108, 58);
            this.pascol.Name = "pascol";
            this.pascol.Size = new System.Drawing.Size(121, 21);
            this.pascol.TabIndex = 0;
            this.pascol.SelectedIndexChanged += new System.EventHandler(this.pascol_SelectedIndexChanged);
            // 
            // n1
            // 
            this.n1.BackColor = System.Drawing.Color.White;
            this.n1.Location = new System.Drawing.Point(327, 150);
            this.n1.Name = "n1";
            this.n1.ReadOnly = true;
            this.n1.Size = new System.Drawing.Size(100, 20);
            this.n1.TabIndex = 1;
            // 
            // ptr1
            // 
            this.ptr1.BackColor = System.Drawing.Color.White;
            this.ptr1.Location = new System.Drawing.Point(327, 230);
            this.ptr1.Name = "ptr1";
            this.ptr1.ReadOnly = true;
            this.ptr1.Size = new System.Drawing.Size(100, 20);
            this.ptr1.TabIndex = 2;
            // 
            // ptr2
            // 
            this.ptr2.Location = new System.Drawing.Point(497, 230);
            this.ptr2.Name = "ptr2";
            this.ptr2.Size = new System.Drawing.Size(100, 20);
            this.ptr2.TabIndex = 3;
            // 
            // sn2
            // 
            this.sn2.Location = new System.Drawing.Point(497, 189);
            this.sn2.Name = "sn2";
            this.sn2.Size = new System.Drawing.Size(100, 20);
            this.sn2.TabIndex = 4;
            // 
            // sn1
            // 
            this.sn1.BackColor = System.Drawing.Color.White;
            this.sn1.Location = new System.Drawing.Point(327, 189);
            this.sn1.Name = "sn1";
            this.sn1.ReadOnly = true;
            this.sn1.Size = new System.Drawing.Size(100, 20);
            this.sn1.TabIndex = 5;
            // 
            // n2
            // 
            this.n2.Location = new System.Drawing.Point(497, 150);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(100, 20);
            this.n2.TabIndex = 6;
            // 
            // dn1
            // 
            this.dn1.BackColor = System.Drawing.Color.White;
            this.dn1.Location = new System.Drawing.Point(327, 268);
            this.dn1.Name = "dn1";
            this.dn1.ReadOnly = true;
            this.dn1.Size = new System.Drawing.Size(100, 20);
            this.dn1.TabIndex = 7;
            // 
            // dn2
            // 
            this.dn2.Location = new System.Drawing.Point(497, 268);
            this.dn2.Name = "dn2";
            this.dn2.Size = new System.Drawing.Size(100, 20);
            this.dn2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Номер документа";
            // 
            // chang
            // 
            this.chang.Location = new System.Drawing.Point(433, 360);
            this.chang.Name = "chang";
            this.chang.Size = new System.Drawing.Size(75, 23);
            this.chang.TabIndex = 13;
            this.chang.Text = "Изменить";
            this.chang.UseVisualStyleBackColor = true;
            this.chang.Click += new System.EventHandler(this.chang_Click);
            // 
            // ChangePassenger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dn2);
            this.Controls.Add(this.dn1);
            this.Controls.Add(this.n2);
            this.Controls.Add(this.sn1);
            this.Controls.Add(this.sn2);
            this.Controls.Add(this.ptr2);
            this.Controls.Add(this.ptr1);
            this.Controls.Add(this.n1);
            this.Controls.Add(this.pascol);
            this.Name = "ChangePassenger";
            this.Text = "ChangePassenger";
            this.Load += new System.EventHandler(this.ChangePassenger_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox pascol;
        private System.Windows.Forms.TextBox n1;
        private System.Windows.Forms.TextBox ptr1;
        private System.Windows.Forms.TextBox ptr2;
        private System.Windows.Forms.TextBox sn2;
        private System.Windows.Forms.TextBox sn1;
        private System.Windows.Forms.TextBox n2;
        private System.Windows.Forms.TextBox dn1;
        private System.Windows.Forms.TextBox dn2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button chang;
    }
}