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
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.cbJobID = new System.Windows.Forms.ComboBox();
            this.bTSearch = new System.Windows.Forms.Button();
            this.tabFilter = new System.Windows.Forms.TabControl();
            this.tabDS = new System.Windows.Forms.TabPage();
            this.dgvDSChoPV = new System.Windows.Forms.DataGridView();
            this.checkboxfilter = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabDSDat = new System.Windows.Forms.TabPage();
            this.dgvDSDat = new System.Windows.Forms.DataGridView();
            this.CodeCandidate2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CandidateName2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateBirthday2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CandidateHistory2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabDSKDat = new System.Windows.Forms.TabPage();
            this.dgvDSKDat = new System.Windows.Forms.DataGridView();
            this.CodeCandidate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CandidateName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateBirthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CandidateHistory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btFilterCandidate = new System.Windows.Forms.Button();
            this.tabFilter.SuspendLayout();
            this.tabDS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSChoPV)).BeginInit();
            this.tabDSDat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDat)).BeginInit();
            this.tabDSKDat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSKDat)).BeginInit();
            this.SuspendLayout();
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(322, 26);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(253, 20);
            this.txtsearch.TabIndex = 31;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // cbJobID
            // 
            this.cbJobID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbJobID.FormattingEnabled = true;
            this.cbJobID.Items.AddRange(new object[] {
            "Mã ứng viên",
            "Tên ứng viên",
            "Giới Tính",
            "Ngôn Ngữ",
            "Vị Trí Tuyển dụng"});
            this.cbJobID.Location = new System.Drawing.Point(86, 27);
            this.cbJobID.Name = "cbJobID";
            this.cbJobID.Size = new System.Drawing.Size(206, 21);
            this.cbJobID.TabIndex = 30;
            // 
            // bTSearch
            // 
            this.bTSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTSearch.Location = new System.Drawing.Point(59, 106);
            this.bTSearch.Name = "bTSearch";
            this.bTSearch.Size = new System.Drawing.Size(107, 32);
            this.bTSearch.TabIndex = 29;
            this.bTSearch.Text = "Tìm Kiếm";
            this.bTSearch.UseVisualStyleBackColor = true;
            this.bTSearch.Click += new System.EventHandler(this.bTSearch_Click);
            // 
            // tabFilter
            // 
            this.tabFilter.Controls.Add(this.tabDS);
            this.tabFilter.Controls.Add(this.tabDSDat);
            this.tabFilter.Controls.Add(this.tabDSKDat);
            this.tabFilter.Location = new System.Drawing.Point(55, 157);
            this.tabFilter.Name = "tabFilter";
            this.tabFilter.SelectedIndex = 0;
            this.tabFilter.Size = new System.Drawing.Size(842, 295);
            this.tabFilter.TabIndex = 28;
            // 
            // tabDS
            // 
            this.tabDS.Controls.Add(this.dgvDSChoPV);
            this.tabDS.Location = new System.Drawing.Point(4, 22);
            this.tabDS.Name = "tabDS";
            this.tabDS.Padding = new System.Windows.Forms.Padding(3);
            this.tabDS.Size = new System.Drawing.Size(834, 269);
            this.tabDS.TabIndex = 2;
            this.tabDS.Text = "Danh Sách Chờ Phỏng Vấn";
            this.tabDS.UseVisualStyleBackColor = true;
            // 
            // dgvDSChoPV
            // 
            this.dgvDSChoPV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSChoPV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkboxfilter,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dgvDSChoPV.Location = new System.Drawing.Point(-4, -2);
            this.dgvDSChoPV.Name = "dgvDSChoPV";
            this.dgvDSChoPV.Size = new System.Drawing.Size(840, 263);
            this.dgvDSChoPV.TabIndex = 1;
            // 
            // checkboxfilter
            // 
            this.checkboxfilter.HeaderText = "";
            this.checkboxfilter.Name = "checkboxfilter";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CodeCandidate";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã ứng viên";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CandidateName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên ứng viên";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DateBirthday";
            this.dataGridViewTextBoxColumn3.HeaderText = "Ngày sinh ";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Gender";
            this.dataGridViewTextBoxColumn4.HeaderText = "Giới Tính";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Phone";
            this.dataGridViewTextBoxColumn5.HeaderText = "Điện Thoại";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn6.HeaderText = "Email";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "CandidateHistory";
            this.dataGridViewTextBoxColumn7.HeaderText = "Ngôn Ngữ";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // tabDSDat
            // 
            this.tabDSDat.Controls.Add(this.dgvDSDat);
            this.tabDSDat.Location = new System.Drawing.Point(4, 22);
            this.tabDSDat.Name = "tabDSDat";
            this.tabDSDat.Padding = new System.Windows.Forms.Padding(3);
            this.tabDSDat.Size = new System.Drawing.Size(834, 269);
            this.tabDSDat.TabIndex = 0;
            this.tabDSDat.Text = "Danh Sách Đạt";
            this.tabDSDat.UseVisualStyleBackColor = true;
            // 
            // dgvDSDat
            // 
            this.dgvDSDat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSDat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodeCandidate2,
            this.CandidateName2,
            this.DateBirthday2,
            this.Gender2,
            this.Phone2,
            this.Email2,
            this.CandidateHistory2,
            this.Status2});
            this.dgvDSDat.Location = new System.Drawing.Point(2, 0);
            this.dgvDSDat.Name = "dgvDSDat";
            this.dgvDSDat.Size = new System.Drawing.Size(942, 269);
            this.dgvDSDat.TabIndex = 1;
            // 
            // CodeCandidate2
            // 
            this.CodeCandidate2.HeaderText = "Mã ứng viên";
            this.CodeCandidate2.Name = "CodeCandidate2";
            // 
            // CandidateName2
            // 
            this.CandidateName2.HeaderText = "Tên ứng viên";
            this.CandidateName2.Name = "CandidateName2";
            // 
            // DateBirthday2
            // 
            this.DateBirthday2.HeaderText = "Ngày sinh";
            this.DateBirthday2.Name = "DateBirthday2";
            // 
            // Gender2
            // 
            this.Gender2.HeaderText = "Giới Tính";
            this.Gender2.Name = "Gender2";
            // 
            // Phone2
            // 
            this.Phone2.HeaderText = "Điện Thoại";
            this.Phone2.Name = "Phone2";
            // 
            // Email2
            // 
            this.Email2.HeaderText = "Email";
            this.Email2.Name = "Email2";
            // 
            // CandidateHistory2
            // 
            this.CandidateHistory2.HeaderText = "Ngôn Ngữ";
            this.CandidateHistory2.Name = "CandidateHistory2";
            // 
            // Status2
            // 
            this.Status2.HeaderText = "Tình Trạng";
            this.Status2.Name = "Status2";
            // 
            // tabDSKDat
            // 
            this.tabDSKDat.Controls.Add(this.dgvDSKDat);
            this.tabDSKDat.Location = new System.Drawing.Point(4, 22);
            this.tabDSKDat.Name = "tabDSKDat";
            this.tabDSKDat.Padding = new System.Windows.Forms.Padding(3);
            this.tabDSKDat.Size = new System.Drawing.Size(834, 269);
            this.tabDSKDat.TabIndex = 1;
            this.tabDSKDat.Text = "Danh Sách Không Đạt";
            this.tabDSKDat.UseVisualStyleBackColor = true;
            // 
            // dgvDSKDat
            // 
            this.dgvDSKDat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSKDat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodeCandidate,
            this.CandidateName,
            this.DateBirthday,
            this.Gender,
            this.Phone,
            this.Email,
            this.CandidateHistory,
            this.Status});
            this.dgvDSKDat.Location = new System.Drawing.Point(3, 3);
            this.dgvDSKDat.Name = "dgvDSKDat";
            this.dgvDSKDat.Size = new System.Drawing.Size(940, 260);
            this.dgvDSKDat.TabIndex = 1;
            // 
            // CodeCandidate
            // 
            this.CodeCandidate.DataPropertyName = "CodeCandidate";
            this.CodeCandidate.HeaderText = "Mã ứng viên";
            this.CodeCandidate.Name = "CodeCandidate";
            // 
            // CandidateName
            // 
            this.CandidateName.DataPropertyName = "CandidateName";
            this.CandidateName.HeaderText = "Tên ứng viên";
            this.CandidateName.Name = "CandidateName";
            // 
            // DateBirthday
            // 
            this.DateBirthday.DataPropertyName = "DateBirthday";
            this.DateBirthday.HeaderText = "Ngày sinh ";
            this.DateBirthday.Name = "DateBirthday";
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "Giới Tính";
            this.Gender.Name = "Gender";
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "Điện Thoại";
            this.Phone.Name = "Phone";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // CandidateHistory
            // 
            this.CandidateHistory.DataPropertyName = "CandidateHistory";
            this.CandidateHistory.HeaderText = "Ngôn Ngữ";
            this.CandidateHistory.Name = "CandidateHistory";
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Tình Trạng";
            this.Status.Name = "Status";
            // 
            // btFilterCandidate
            // 
            this.btFilterCandidate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFilterCandidate.Location = new System.Drawing.Point(193, 106);
            this.btFilterCandidate.Name = "btFilterCandidate";
            this.btFilterCandidate.Size = new System.Drawing.Size(104, 32);
            this.btFilterCandidate.TabIndex = 27;
            this.btFilterCandidate.Text = "Lọc";
            this.btFilterCandidate.UseVisualStyleBackColor = true;
            // 
            // FilterCandidate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 478);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.cbJobID);
            this.Controls.Add(this.bTSearch);
            this.Controls.Add(this.tabFilter);
            this.Controls.Add(this.btFilterCandidate);
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
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.ComboBox cbJobID;
        private System.Windows.Forms.Button bTSearch;
        private System.Windows.Forms.TabControl tabFilter;
        private System.Windows.Forms.TabPage tabDS;
        private System.Windows.Forms.DataGridView dgvDSChoPV;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkboxfilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.TabPage tabDSDat;
        private System.Windows.Forms.DataGridView dgvDSDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeCandidate2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CandidateName2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateBirthday2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CandidateHistory2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status2;
        private System.Windows.Forms.TabPage tabDSKDat;
        private System.Windows.Forms.DataGridView dgvDSKDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeCandidate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CandidateName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateBirthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn CandidateHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Button btFilterCandidate;
    }
}