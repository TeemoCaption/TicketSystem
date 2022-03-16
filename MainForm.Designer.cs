﻿namespace TicketSystem
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cboEnd = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboStart = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvTicket = new System.Windows.Forms.DataGridView();
            this.ticket_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.runTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmlBuy = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicket)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpDate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboEnd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboStart);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1330, 166);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查詢條件";
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "yyyy/MM/dd";
            this.dtpDate.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDate.Location = new System.Drawing.Point(853, 73);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(248, 38);
            this.dtpDate.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(714, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "出發日期：";
            // 
            // cboEnd
            // 
            this.cboEnd.FormattingEnabled = true;
            this.cboEnd.Items.AddRange(new object[] {
            "彰化",
            "屏東",
            "雲林",
            "左營"});
            this.cboEnd.Location = new System.Drawing.Point(503, 65);
            this.cboEnd.Name = "cboEnd";
            this.cboEnd.Size = new System.Drawing.Size(182, 49);
            this.cboEnd.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(377, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "終點站：";
            // 
            // cboStart
            // 
            this.cboStart.FormattingEnabled = true;
            this.cboStart.Items.AddRange(new object[] {
            "彰化",
            "屏東",
            "雲林",
            "左營"});
            this.cboStart.Location = new System.Drawing.Point(154, 65);
            this.cboStart.Name = "cboStart";
            this.cboStart.Size = new System.Drawing.Size(182, 49);
            this.cboStart.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(28, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "起始站：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1170, 65);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(97, 52);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "查詢";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvTicket
            // 
            this.dgvTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTicket.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ticket_id,
            this.ticketNo,
            this.runTime,
            this.startStation,
            this.endStation,
            this.price,
            this.ticketNum});
            this.dgvTicket.Location = new System.Drawing.Point(58, 200);
            this.dgvTicket.Name = "dgvTicket";
            this.dgvTicket.RowHeadersWidth = 62;
            this.dgvTicket.RowTemplate.Height = 32;
            this.dgvTicket.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTicket.Size = new System.Drawing.Size(1177, 409);
            this.dgvTicket.TabIndex = 1;
            this.dgvTicket.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvTicket.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTicket_CellMouseDown);
            // 
            // ticket_id
            // 
            this.ticket_id.DataPropertyName = "ticket_id";
            this.ticket_id.HeaderText = "編號";
            this.ticket_id.MinimumWidth = 8;
            this.ticket_id.Name = "ticket_id";
            this.ticket_id.Width = 150;
            // 
            // ticketNo
            // 
            this.ticketNo.DataPropertyName = "ticketNo";
            this.ticketNo.HeaderText = "車次";
            this.ticketNo.MinimumWidth = 8;
            this.ticketNo.Name = "ticketNo";
            this.ticketNo.Width = 150;
            // 
            // runTime
            // 
            this.runTime.DataPropertyName = "runTime";
            this.runTime.HeaderText = "發車時間";
            this.runTime.MinimumWidth = 8;
            this.runTime.Name = "runTime";
            this.runTime.Width = 150;
            // 
            // startStation
            // 
            this.startStation.DataPropertyName = "startStation";
            this.startStation.HeaderText = "起始站";
            this.startStation.MinimumWidth = 8;
            this.startStation.Name = "startStation";
            this.startStation.Width = 150;
            // 
            // endStation
            // 
            this.endStation.DataPropertyName = "endStation";
            this.endStation.HeaderText = "終點站";
            this.endStation.MinimumWidth = 8;
            this.endStation.Name = "endStation";
            this.endStation.Width = 150;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "票價";
            this.price.MinimumWidth = 8;
            this.price.Name = "price";
            this.price.Width = 150;
            // 
            // ticketNum
            // 
            this.ticketNum.DataPropertyName = "ticketNum";
            this.ticketNum.HeaderText = "剩餘車票";
            this.ticketNum.MinimumWidth = 8;
            this.ticketNum.Name = "ticketNum";
            this.ticketNum.Width = 150;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmlBuy});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(117, 34);
            // 
            // tsmlBuy
            // 
            this.tsmlBuy.Name = "tsmlBuy";
            this.tsmlBuy.Size = new System.Drawing.Size(240, 30);
            this.tsmlBuy.Text = "購買";
            this.tsmlBuy.Click += new System.EventHandler(this.tsmlBuy_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 621);
            this.Controls.Add(this.dgvTicket);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicket)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Button btnSearch;
        private DateTimePicker dtpDate;
        private Label label3;
        private ComboBox cboEnd;
        private Label label2;
        private ComboBox cboStart;
        private DataGridView dgvTicket;
        private DataGridViewTextBoxColumn ticket_id;
        private DataGridViewTextBoxColumn ticketNo;
        private DataGridViewTextBoxColumn runTime;
        private DataGridViewTextBoxColumn startStation;
        private DataGridViewTextBoxColumn endStation;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn ticketNum;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem tsmlBuy;
    }
}