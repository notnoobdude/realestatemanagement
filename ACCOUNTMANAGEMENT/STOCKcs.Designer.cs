﻿namespace ACCOUNTMANAGEMENT
{
    partial class STOCKcs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(STOCKcs));
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.lblpath = new System.Windows.Forms.Label();
            this.dgvinstallment = new System.Windows.Forms.DataGridView();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.ITEMID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ITEMNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTALINQTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTALOUTQTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CURRENTSTOCK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvinstallment)).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.CustomFormat = "dd/MMM/yyyy";
            this.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateTo.Location = new System.Drawing.Point(142, 42);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.Size = new System.Drawing.Size(120, 20);
            this.dtpDateTo.TabIndex = 244;
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.CustomFormat = "dd/MMM/yyyy";
            this.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateFrom.Location = new System.Drawing.Point(6, 42);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.Size = new System.Drawing.Size(120, 20);
            this.dtpDateFrom.TabIndex = 244;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.dtpDateTo);
            this.GroupBox2.Controls.Add(this.dtpDateFrom);
            this.GroupBox2.Controls.Add(this.btnSearch);
            this.GroupBox2.Controls.Add(this.Label4);
            this.GroupBox2.Controls.Add(this.Label2);
            this.GroupBox2.Location = new System.Drawing.Point(20, 17);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(349, 90);
            this.GroupBox2.TabIndex = 246;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Search By Check IN Date :";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(143, 23);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(26, 13);
            this.Label4.TabIndex = 10;
            this.Label4.Text = "To :";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(10, 23);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(36, 13);
            this.Label2.TabIndex = 9;
            this.Label2.Text = "From :";
            // 
            // lblpath
            // 
            this.lblpath.AutoSize = true;
            this.lblpath.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblpath.Location = new System.Drawing.Point(1130, 15);
            this.lblpath.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblpath.Name = "lblpath";
            this.lblpath.Size = new System.Drawing.Size(0, 13);
            this.lblpath.TabIndex = 245;
            // 
            // dgvinstallment
            // 
            this.dgvinstallment.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvinstallment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvinstallment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ITEMID,
            this.ITEMNAME,
            this.TOTALINQTY,
            this.TOTALOUTQTY,
            this.CURRENTSTOCK});
            this.dgvinstallment.Location = new System.Drawing.Point(12, 126);
            this.dgvinstallment.Name = "dgvinstallment";
            this.dgvinstallment.Size = new System.Drawing.Size(1229, 429);
            this.dgvinstallment.TabIndex = 244;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.btn_close);
            this.GroupBox1.Controls.Add(this.btnView);
            this.GroupBox1.Controls.Add(this.btnReset);
            this.GroupBox1.Controls.Add(this.btnExportExcel);
            this.GroupBox1.Location = new System.Drawing.Point(818, 15);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(423, 90);
            this.GroupBox1.TabIndex = 247;
            this.GroupBox1.TabStop = false;
            // 
            // ITEMID
            // 
            this.ITEMID.HeaderText = "ITEM ID";
            this.ITEMID.Name = "ITEMID";
            // 
            // ITEMNAME
            // 
            this.ITEMNAME.HeaderText = "ITEM NAME";
            this.ITEMNAME.Name = "ITEMNAME";
            // 
            // TOTALINQTY
            // 
            this.TOTALINQTY.HeaderText = "TOTAL IN QTY";
            this.TOTALINQTY.Name = "TOTALINQTY";
            // 
            // TOTALOUTQTY
            // 
            this.TOTALOUTQTY.HeaderText = "TOTAL OUT QTY";
            this.TOTALOUTQTY.Name = "TOTALOUTQTY";
            // 
            // CURRENTSTOCK
            // 
            this.CURRENTSTOCK.HeaderText = "CURRENT STOCK";
            this.CURRENTSTOCK.Name = "CURRENTSTOCK";
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(267, 30);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 39);
            this.btnSearch.TabIndex = 108;
            this.btnSearch.Text = "&Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnView
            // 
            this.btnView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Image = ((System.Drawing.Image)(resources.GetObject("btnView.Image")));
            this.btnView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnView.Location = new System.Drawing.Point(12, 27);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(100, 39);
            this.btnView.TabIndex = 6;
            this.btnView.Text = "&View Report";
            this.btnView.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnReset
            // 
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(121, 27);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(82, 39);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "&Reset";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExportExcel.Image")));
            this.btnExportExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportExcel.Location = new System.Drawing.Point(212, 27);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(104, 39);
            this.btnExportExcel.TabIndex = 5;
            this.btnExportExcel.Text = "&Export Excel";
            this.btnExportExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportExcel.UseVisualStyleBackColor = true;
            // 
            // btn_close
            // 
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_close.Location = new System.Drawing.Point(322, 28);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(83, 36);
            this.btn_close.TabIndex = 270;
            this.btn_close.Text = "&Close";
            this.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // STOCKcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1267, 593);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.lblpath);
            this.Controls.Add(this.dgvinstallment);
            this.Controls.Add(this.GroupBox1);
            this.Name = "STOCKcs";
            this.Text = "STOCKcs";
            this.Load += new System.EventHandler(this.STOCKcs_Load);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvinstallment)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DateTimePicker dtpDateTo;
        internal System.Windows.Forms.DateTimePicker dtpDateFrom;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Button btnSearch;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label2;
        public System.Windows.Forms.Label lblpath;
        private System.Windows.Forms.DataGridView dgvinstallment;
        internal System.Windows.Forms.Button btnView;
        internal System.Windows.Forms.Button btnReset;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITEMID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITEMNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTALINQTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTALOUTQTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn CURRENTSTOCK;
        internal System.Windows.Forms.Button btn_close;
    }
}