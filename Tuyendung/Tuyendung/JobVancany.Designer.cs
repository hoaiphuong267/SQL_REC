namespace Tuyendung
{
    partial class JobVancany
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtMVTT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMDKTuyen = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSoVongTuyen = new System.Windows.Forms.TextBox();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.dtDateEnd = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtTenVT = new System.Windows.Forms.TextBox();
            this.dtDateStart = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_Date = new System.Windows.Forms.Label();
            this.dgvJobVancany = new System.Windows.Forms.DataGridView();
            this.JobVancanyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobVancanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LevelInterview = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobConditionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabJobVancacy = new System.Windows.Forms.TabPage();
            this.tabCandidate = new System.Windows.Forms.TabPage();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobVancany)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabJobVancacy.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDel);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.txtMVTT);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtMDKTuyen);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtSoVongTuyen);
            this.groupBox1.Controls.Add(this.txtSoluong);
            this.groupBox1.Controls.Add(this.dtDateEnd);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtTenVT);
            this.groupBox1.Controls.Add(this.dtDateStart);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lb_Date);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(974, 226);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin tuyển dụng";
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(796, 190);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(105, 30);
            this.btnDel.TabIndex = 19;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(685, 190);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(105, 30);
            this.btnEdit.TabIndex = 18;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtMVTT
            // 
            this.txtMVTT.Location = new System.Drawing.Point(128, 64);
            this.txtMVTT.Name = "txtMVTT";
            this.txtMVTT.Size = new System.Drawing.Size(200, 32);
            this.txtMVTT.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "Mã Vị Trí Tuyển";
            // 
            // txtMDKTuyen
            // 
            this.txtMDKTuyen.Location = new System.Drawing.Point(479, 64);
            this.txtMDKTuyen.Name = "txtMDKTuyen";
            this.txtMDKTuyen.Size = new System.Drawing.Size(173, 32);
            this.txtMDKTuyen.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(346, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Mã Điều kiện tuyển";
            // 
            // txtSoVongTuyen
            // 
            this.txtSoVongTuyen.Location = new System.Drawing.Point(774, 117);
            this.txtSoVongTuyen.Name = "txtSoVongTuyen";
            this.txtSoVongTuyen.Size = new System.Drawing.Size(192, 32);
            this.txtSoVongTuyen.TabIndex = 12;
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(479, 117);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(173, 32);
            this.txtSoluong.TabIndex = 11;
            // 
            // dtDateEnd
            // 
            this.dtDateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDateEnd.Location = new System.Drawing.Point(128, 162);
            this.dtDateEnd.Name = "dtDateEnd";
            this.dtDateEnd.Size = new System.Drawing.Size(200, 32);
            this.dtDateEnd.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(658, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Số vòng tuyển";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(346, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Số lượng tuyển";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ngày kết thúc";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(563, 190);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(105, 30);
            this.btnTimKiem.TabIndex = 6;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(443, 190);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(105, 30);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Tạo mới";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtTenVT
            // 
            this.txtTenVT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTenVT.Location = new System.Drawing.Point(774, 57);
            this.txtTenVT.Name = "txtTenVT";
            this.txtTenVT.Size = new System.Drawing.Size(190, 32);
            this.txtTenVT.TabIndex = 4;
            // 
            // dtDateStart
            // 
            this.dtDateStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDateStart.Location = new System.Drawing.Point(128, 117);
            this.dtDateStart.Name = "dtDateStart";
            this.dtDateStart.Size = new System.Drawing.Size(200, 32);
            this.dtDateStart.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(658, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Vị Trí Tuyển";
            // 
            // lb_Date
            // 
            this.lb_Date.AutoSize = true;
            this.lb_Date.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Date.Location = new System.Drawing.Point(6, 117);
            this.lb_Date.Name = "lb_Date";
            this.lb_Date.Size = new System.Drawing.Size(111, 19);
            this.lb_Date.TabIndex = 0;
            this.lb_Date.Text = "Ngày đăng tuyển";
            // 
            // dgvJobVancany
            // 
            this.dgvJobVancany.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJobVancany.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.JobVancanyID,
            this.JobVancanyName,
            this.DateStart,
            this.DateEnd,
            this.Soluong,
            this.LevelInterview,
            this.JobConditionID});
            this.dgvJobVancany.Location = new System.Drawing.Point(121, 238);
            this.dgvJobVancany.Name = "dgvJobVancany";
            this.dgvJobVancany.Size = new System.Drawing.Size(743, 270);
            this.dgvJobVancany.TabIndex = 2;
            this.dgvJobVancany.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJobVancany_CellClick);
            this.dgvJobVancany.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvJobVancany_UserDeletingRow);
            // 
            // JobVancanyID
            // 
            this.JobVancanyID.DataPropertyName = "JobVancanyID";
            this.JobVancanyID.HeaderText = "Mã Vị Trí Tuyển";
            this.JobVancanyID.Name = "JobVancanyID";
            // 
            // JobVancanyName
            // 
            this.JobVancanyName.DataPropertyName = "JobVancanyName";
            this.JobVancanyName.HeaderText = "Tên Vị Trí Tuyển";
            this.JobVancanyName.Name = "JobVancanyName";
            // 
            // DateStart
            // 
            this.DateStart.DataPropertyName = "DateStart";
            this.DateStart.HeaderText = "Ngày đăng tuyển";
            this.DateStart.Name = "DateStart";
            // 
            // DateEnd
            // 
            this.DateEnd.DataPropertyName = "DateEnd";
            this.DateEnd.HeaderText = "Ngày kết thúc";
            this.DateEnd.Name = "DateEnd";
            // 
            // Soluong
            // 
            this.Soluong.DataPropertyName = "Soluong";
            this.Soluong.HeaderText = "Số Lượng";
            this.Soluong.Name = "Soluong";
            // 
            // LevelInterview
            // 
            this.LevelInterview.DataPropertyName = "LevelInterview";
            this.LevelInterview.HeaderText = "Số vòng phỏng vấn";
            this.LevelInterview.Name = "LevelInterview";
            // 
            // JobConditionID
            // 
            this.JobConditionID.DataPropertyName = "JobConditionID";
            this.JobConditionID.HeaderText = "Mã ĐK Tuyển";
            this.JobConditionID.Name = "JobConditionID";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabJobVancacy);
            this.tabControl1.Controls.Add(this.tabCandidate);
            this.tabControl1.Location = new System.Drawing.Point(-1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(995, 540);
            this.tabControl1.TabIndex = 3;
            // 
            // tabJobVancacy
            // 
            this.tabJobVancacy.Controls.Add(this.groupBox1);
            this.tabJobVancacy.Controls.Add(this.dgvJobVancany);
            this.tabJobVancacy.Location = new System.Drawing.Point(4, 22);
            this.tabJobVancacy.Name = "tabJobVancacy";
            this.tabJobVancacy.Padding = new System.Windows.Forms.Padding(3);
            this.tabJobVancacy.Size = new System.Drawing.Size(987, 514);
            this.tabJobVancacy.TabIndex = 0;
            this.tabJobVancacy.Text = "Yêu cầu Tuyển Dụng";
            this.tabJobVancacy.UseVisualStyleBackColor = true;
            // 
            // tabCandidate
            // 
            this.tabCandidate.Location = new System.Drawing.Point(4, 22);
            this.tabCandidate.Name = "tabCandidate";
            this.tabCandidate.Padding = new System.Windows.Forms.Padding(3);
            this.tabCandidate.Size = new System.Drawing.Size(987, 514);
            this.tabCandidate.TabIndex = 1;
            this.tabCandidate.Text = "Hồ Sơ Ứng Viên";
            this.tabCandidate.UseVisualStyleBackColor = true;
            // 
            // JobVancany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 538);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "JobVancany";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JobVancany";
            this.Load += new System.EventHandler(this.JobVancany_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobVancany)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabJobVancacy.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvJobVancany;
        private System.Windows.Forms.TextBox txtTenVT;
        private System.Windows.Forms.DateTimePicker dtDateStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_Date;
        private System.Windows.Forms.TextBox txtSoVongTuyen;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.DateTimePicker dtDateEnd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMDKTuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobVancanyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobVancanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn LevelInterview;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobConditionID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMVTT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabJobVancacy;
        private System.Windows.Forms.TabPage tabCandidate;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDel;
    }
}