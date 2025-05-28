
namespace NovaFlyClient
{
    partial class Shedule
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
            this.components = new System.ComponentModel.Container();
            this.Shed = new System.Windows.Forms.DataGridView();
            this.Обновить = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.ticketclk = new System.Windows.Forms.Button();
            this.tickets = new System.Windows.Forms.Button();
            this.DERFR = new System.Windows.Forms.ComboBox();
            this.ARRTO = new System.Windows.Forms.ComboBox();
            this.DEPD = new System.Windows.Forms.DateTimePicker();
            this.ARRD = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.InfoT = new System.Windows.Forms.TextBox();
            this.sheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Shed)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sheduleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Shed
            // 
            this.Shed.AllowUserToAddRows = false;
            this.Shed.AllowUserToResizeRows = false;
            this.Shed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Shed.Location = new System.Drawing.Point(275, 21);
            this.Shed.Name = "Shed";
            this.Shed.Size = new System.Drawing.Size(968, 460);
            this.Shed.TabIndex = 0;
            // 
            // Обновить
            // 
            this.Обновить.Location = new System.Drawing.Point(1249, 21);
            this.Обновить.Name = "Обновить";
            this.Обновить.Size = new System.Drawing.Size(83, 52);
            this.Обновить.TabIndex = 1;
            this.Обновить.Text = " Обновить расписание";
            this.Обновить.UseVisualStyleBackColor = true;
            this.Обновить.Click += new System.EventHandler(this.button1_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(64, 150);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(100, 45);
            this.Search.TabIndex = 2;
            this.Search.Text = "Найти";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // ticketclk
            // 
            this.ticketclk.Location = new System.Drawing.Point(1458, 21);
            this.ticketclk.Name = "ticketclk";
            this.ticketclk.Size = new System.Drawing.Size(75, 52);
            this.ticketclk.TabIndex = 3;
            this.ticketclk.Text = "Заказать билет";
            this.ticketclk.UseVisualStyleBackColor = true;
            this.ticketclk.Click += new System.EventHandler(this.ticketclk_Click);
            // 
            // tickets
            // 
            this.tickets.Location = new System.Drawing.Point(1458, 94);
            this.tickets.Name = "tickets";
            this.tickets.Size = new System.Drawing.Size(75, 52);
            this.tickets.TabIndex = 4;
            this.tickets.Text = "Просмотр билетов";
            this.tickets.UseVisualStyleBackColor = true;
            this.tickets.Click += new System.EventHandler(this.tickets_Click);
            // 
            // DERFR
            // 
            this.DERFR.FormattingEnabled = true;
            this.DERFR.Location = new System.Drawing.Point(6, 24);
            this.DERFR.Name = "DERFR";
            this.DERFR.Size = new System.Drawing.Size(121, 21);
            this.DERFR.TabIndex = 5;
            this.DERFR.SelectedIndexChanged += new System.EventHandler(this.DERFR_SelectedIndexChanged);
            // 
            // ARRTO
            // 
            this.ARRTO.FormattingEnabled = true;
            this.ARRTO.Location = new System.Drawing.Point(6, 51);
            this.ARRTO.Name = "ARRTO";
            this.ARRTO.Size = new System.Drawing.Size(121, 21);
            this.ARRTO.TabIndex = 6;
            this.ARRTO.SelectedIndexChanged += new System.EventHandler(this.ARRTO_SelectedIndexChanged);
            // 
            // DEPD
            // 
            this.DEPD.Location = new System.Drawing.Point(7, 78);
            this.DEPD.Name = "DEPD";
            this.DEPD.Size = new System.Drawing.Size(120, 20);
            this.DEPD.TabIndex = 7;
            this.DEPD.ValueChanged += new System.EventHandler(this.DEPD_ValueChanged);
            // 
            // ARRD
            // 
            this.ARRD.Location = new System.Drawing.Point(6, 104);
            this.ARRD.Name = "ARRD";
            this.ARRD.Size = new System.Drawing.Size(121, 20);
            this.ARRD.TabIndex = 8;
            this.ARRD.ValueChanged += new System.EventHandler(this.ARRD_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Откуда";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Куда";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Дата вылета";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Дата прилёта";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DERFR);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Search);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ARRTO);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.DEPD);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ARRD);
            this.groupBox1.Location = new System.Drawing.Point(21, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 207);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск рейса";
            // 
            // InfoT
            // 
            this.InfoT.BackColor = System.Drawing.Color.White;
            this.InfoT.Location = new System.Drawing.Point(1287, 155);
            this.InfoT.Multiline = true;
            this.InfoT.Name = "InfoT";
            this.InfoT.ReadOnly = true;
            this.InfoT.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.InfoT.Size = new System.Drawing.Size(246, 478);
            this.InfoT.TabIndex = 14;
            // 
            // sheduleBindingSource
            // 
            this.sheduleBindingSource.DataSource = typeof(NovaFlyClient.Shedule);
            // 
            // Shedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1545, 661);
            this.Controls.Add(this.InfoT);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tickets);
            this.Controls.Add(this.ticketclk);
            this.Controls.Add(this.Обновить);
            this.Controls.Add(this.Shed);
            this.Name = "Shedule";
            this.Text = "Shedule";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Shedule_FormClosing);
            this.Load += new System.EventHandler(this.Shedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Shed)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sheduleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Shed;
        private System.Windows.Forms.Button Обновить;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button ticketclk;
        private System.Windows.Forms.Button tickets;
        private System.Windows.Forms.ComboBox DERFR;
        private System.Windows.Forms.ComboBox ARRTO;
        private System.Windows.Forms.DateTimePicker DEPD;
        private System.Windows.Forms.DateTimePicker ARRD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource sheduleBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox InfoT;
    }
}