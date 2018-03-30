namespace Tuyendung
{
    partial class FilterCandidate
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
            this.label7 = new System.Windows.Forms.Label();
            this.dtDateEnd = new System.Windows.Forms.DateTimePicker();
            this.dtDateStart = new System.Windows.Forms.DateTimePicker();
            this.lb_Date = new System.Windows.Forms.Label();
            this.btFilterCandidate = new System.Windows.Forms.Button();
            this.tabFilter = new System.Windows.Forms.TabControl();
            this.tabDS = new System.Windows.Forms.TabPage();
            this.dgvDSChoPV = new System.Windows.Forms.DataGridView();
            this.tabDSDat = new System.Windows.Forms.TabPage();
            this.dgvDSDat = new System.Windows.Forms.DataGridView();
            this.tabDSKDat = new System.Windows.Forms.TabPage();
            this.dgvDSKDat = new System.Windows.Forms.DataGridView();
            this.bTSearch = new System.Windows.Forms.Button();
            this.cbJobID = new System.Windows.Forms.ComboBox();
            this.tabFilter.SuspendLayout();
            this.tabDS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSChoPV)).BeginInit();
            this.tabDSDat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDat)).BeginInit();
            this.tabDSKDat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSKDat)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(44, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 23);
            this.label7.TabIndex = 15;
            this.label7.Text = "Vị trí tuyển";
            // 
            // dtDateEnd
            // 
            this.dtDateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDateEnd.Location = new System.Drawing.Point(290, 70);
            this.dtDateEnd.MinDate = new System.DateTime(2005, 1, 1, 0, 0, 0, 0);
            this.dtDateEnd.Name = "dtDateEnd";
            this.dtDateEnd.Size = new System.Drawing.Size(100, 20);
            this.dtDateEnd.TabIndex = 20;
            // 
            // dtDateStart
            // 
            this.dtDateStart.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDateStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDateStart.Location = new System.Drawing.Point(184, 70);
            this.dtDateStart.MinDate = new System.DateTime(2005, 1, 1, 0, 0, 0, 0);
            this.dtDateStart.Name = "dtDateStart";
            this.dtDateStart.Size = new System.Drawing.Size(100, 20);
            this.dtDateStart.TabIndex = 18;
            this.dtDateStart.UseWaitCursor = true;
            // 
            // lb_Date
            // 
            this.lb_Date.AutoSize = true;
            this.lb_Date.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Date.Location = new System.Drawing.Point(43, 71);
            this.lb_Date.Name = "lb_Date";
            this.lb_Date.Size = new System.Drawing.Size(99, 21);
            this.lb_Date.TabIndex = 17;
            this.lb_Date.Text = "Ngày  tuyển";
            // 
            // btFilterCandidate
            // 
            this.btFilterCandidate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFilterCandidate.Location = new System.Drawing.Point(154, 122);
            this.btFilterCandidate.Name = "btFilterCandidate";
            this.btFilterCandidate.Size = new System.Drawing.Size(104, 32);
            this.btFilterCandidate.TabIndex = 21;
            this.btFilterCandidate.Text = "Lọc";
            this.btFilterCandidate.UseVisualStyleBackColor = true;
            this.btFilterCandidate.Click += new System.EventHandler(this.btFilterCandidate_Click);
            // 
            // tabFilter
            // 
            this.tabFilter.Controls.Add(this.tabDS);
            this.tabFilter.Controls.Add(this.tabDSDat);
            this.tabFilter.Controls.Add(this.tabDSKDat);
            this.tabFilter.Location = new System.Drawing.Point(16, 173);
            this.tabFilter.Name = "tabFilter";
            this.tabFilter.SelectedIndex = 0;
            this.tabFilter.Size = new System.Drawing.Size(541, 233);
            this.tabFilter.TabIndex = 22;
            // 
            // tabDS
            // 
            this.tabDS.Controls.Add(this.dgvDSChoPV);
            this.tabDS.Location = new System.Drawing.Point(4, 22);
            this.tabDS.Name = "tabDS";
            this.tabDS.Padding = new System.Windows.Forms.Padding(3);
            this.tabDS.Size = new System.Drawing.Size(533, 207);
            this.tabDS.TabIndex = 2;
            this.tabDS.Text = "Danh Sách Chờ Phỏng Vấn";
            this.tabDS.UseVisualStyleBackColor = true;
            // 
            // dgvDSChoPV
            // 
            this.dgvDSChoPV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSChoPV.Location = new System.Drawing.Point(0, 0);
            this.dgvDSChoPV.Name = "dgvDSChoPV";
            this.dgvDSChoPV.Size = new System.Drawing.Size(533, 207);
            this.dgvDSChoPV.TabIndex = 0;
            // 
            // tabDSDat
            // 
            this.tabDSDat.Controls.Add(this.dgvDSDat);
            this.tabDSDat.Location = new System.Drawing.Point(4, 22);
            this.tabDSDat.Name = "tabDSDat";
            this.tabDSDat.Padding = new System.Windows.Forms.Padding(3);
            this.tabDSDat.Size = new System.Drawing.Size(533, 207);
            this.tabDSDat.TabIndex = 0;
            this.tabDSDat.Text = "Danh Sách Đạt";
            this.tabDSDat.UseVisualStyleBackColor = true;
            // 
            // dgvDSDat
            // 
            this.dgvDSDat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSDat.Location = new System.Drawing.Point(0, 0);
            this.dgvDSDat.Name = "dgvDSDat";
            this.dgvDSDat.Size = new System.Drawing.Size(533, 204);
            this.dgvDSDat.TabIndex = 0;
            // 
            // tabDSKDat
            // 
            this.tabDSKDat.Controls.Add(this.dgvDSKDat);
            this.tabDSKDat.Location = new System.Drawing.Point(4, 22);
            this.tabDSKDat.Name = "tabDSKDat";
            this.tabDSKDat.Padding = new System.Windows.Forms.Padding(3);
            this.tabDSKDat.Size = new System.Drawing.Size(533, 207);
            this.tabDSKDat.TabIndex = 1;
            this.tabDSKDat.Text = "Danh Sách Không Đạt";
            this.tabDSKDat.UseVisualStyleBackColor = true;
            // 
            // dgvDSKDat
            // 
            this.dgvDSKDat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSKDat.Location = new System.Drawing.Point(3, 0);
            this.dgvDSKDat.Name = "dgvDSKDat";
            this.dgvDSKDat.Size = new System.Drawing.Size(530, 207);
            this.dgvDSKDat.TabIndex = 0;
            // 
            // bTSearch
            // 
            this.bTSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTSearch.Location = new System.Drawing.Point(20, 122);
            this.bTSearch.Name = "bTSearch";
            this.bTSearch.Size = new System.Drawing.Size(107, 32);
            this.bTSearch.TabIndex = 23;
            this.bTSearch.Text = "Tìm Kiếm";
            this.bTSearch.UseVisualStyleBackColor = true;
            this.bTSearch.Click += new System.EventHandler(this.bTSearch_Click);
            // 
            // cbJobID
            // 
            this.cbJobID.FormattingEnabled = true;
            this.cbJobID.Location = new System.Drawing.Point(184, 33);
            this.cbJobID.Name = "cbJobID";
            this.cbJobID.Size = new System.Drawing.Size(206, 21);
            this.cbJobID.TabIndex = 24;
            // 
            // FilterCandidate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 409);
            this.Controls.Add(this.cbJobID);
            this.Controls.Add(this.bTSearch);
            this.Controls.Add(this.tabFilter);
            this.Controls.Add(this.btFilterCandidate);
            this.Controls.Add(this.dtDateEnd);
            this.Controls.Add(this.dtDateStart);
            this.Controls.Add(this.lb_Date);
            this.Controls.Add(this.label7);
            this.Name = "FilterCandidate";
            this.Text = "FilterCandidate";
            this.Load += new System.EventHandler(this.FilterCandidate_Load);
            this.tabFilter.ResumeLayout(false);
            this.tabDS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSChoPV)).EndInit();
            this.tabDSDat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDat)).EndInit();
            this.tabDSKDat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSKDat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtDateEnd;
        private System.Windows.Forms.DateTimePicker dtDateStart;
        private System.Windows.Forms.Label lb_Date;
        private System.Windows.Forms.Button btFilterCandidate;
        private System.Windows.Forms.TabControl tabFilter;
        private System.Windows.Forms.TabPage tabDSDat;
        private System.Windows.Forms.DataGridView dgvDSDat;
        private System.Windows.Forms.TabPage tabDSKDat;
        private System.Windows.Forms.DataGridView dgvDSKDat;
        private System.Windows.Forms.Button bTSearch;
        private System.Windows.Forms.TabPage tabDS;
        private System.Windows.Forms.DataGridView dgvDSChoPV;
        private System.Windows.Forms.ComboBox cbJobID;
    }
}