
namespace NovaFlyClient
{
    partial class Ticket
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
            this.passang = new System.Windows.Forms.ComboBox();
            this.seat = new System.Windows.Forms.TextBox();
            this.ticke = new System.Windows.Forms.Button();
            this.Newpas = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.flight = new System.Windows.Forms.ComboBox();
            this.changpas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // passang
            // 
            this.passang.FormattingEnabled = true;
            this.passang.Location = new System.Drawing.Point(87, 104);
            this.passang.Name = "passang";
            this.passang.Size = new System.Drawing.Size(176, 21);
            this.passang.TabIndex = 0;
            // 
            // seat
            // 
            this.seat.Location = new System.Drawing.Point(87, 179);
            this.seat.Name = "seat";
            this.seat.Size = new System.Drawing.Size(177, 20);
            this.seat.TabIndex = 2;
            // 
            // ticke
            // 
            this.ticke.Location = new System.Drawing.Point(88, 263);
            this.ticke.Name = "ticke";
            this.ticke.Size = new System.Drawing.Size(120, 44);
            this.ticke.TabIndex = 3;
            this.ticke.Text = "Оформить билет";
            this.ticke.UseVisualStyleBackColor = true;
            this.ticke.Click += new System.EventHandler(this.ticke_Click);
            // 
            // Newpas
            // 
            this.Newpas.Location = new System.Drawing.Point(454, 154);
            this.Newpas.Name = "Newpas";
            this.Newpas.Size = new System.Drawing.Size(134, 45);
            this.Newpas.TabIndex = 4;
            this.Newpas.Text = "Добавить нового пассажира";
            this.Newpas.UseVisualStyleBackColor = true;
            this.Newpas.Click += new System.EventHandler(this.Newpas_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(454, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 46);
            this.button1.TabIndex = 5;
            this.button1.Text = "Обновить список пассажиров";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Пассажир*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Номер рейса*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Номер места*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Цена*";
            // 
            // flight
            // 
            this.flight.FormattingEnabled = true;
            this.flight.Location = new System.Drawing.Point(88, 139);
            this.flight.Name = "flight";
            this.flight.Size = new System.Drawing.Size(176, 21);
            this.flight.TabIndex = 11;
            // 
            // changpas
            // 
            this.changpas.Location = new System.Drawing.Point(454, 221);
            this.changpas.Name = "changpas";
            this.changpas.Size = new System.Drawing.Size(134, 45);
            this.changpas.TabIndex = 12;
            this.changpas.Text = "Изменить данные пассажира";
            this.changpas.UseVisualStyleBackColor = true;
            this.changpas.Click += new System.EventHandler(this.changpas_Click);
            // 
            // Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 450);
            this.Controls.Add(this.changpas);
            this.Controls.Add(this.flight);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Newpas);
            this.Controls.Add(this.ticke);
            this.Controls.Add(this.seat);
            this.Controls.Add(this.passang);
            this.Name = "Ticket";
            this.Text = "Ticket";
            this.Load += new System.EventHandler(this.Ticket_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox passang;
        private System.Windows.Forms.TextBox seat;
        private System.Windows.Forms.Button ticke;
        private System.Windows.Forms.Button Newpas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox flight;
        private System.Windows.Forms.Button changpas;
    }
}