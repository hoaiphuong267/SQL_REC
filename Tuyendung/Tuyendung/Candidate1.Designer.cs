namespace Tuyendung
{
    partial class Candidate1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Candidate1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_JobVancanyID1 = new System.Windows.Forms.ComboBox();
            this.cb_Gender1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.bt_Filter = new System.Windows.Forms.Button();
            this.btDel = new System.Windows.Forms.Button();
            this.bt_addCandidate = new System.Windows.Forms.Button();
            this.txt_Phone1 = new System.Windows.Forms.TextBox();
            this.dt_DateOfBirth1 = new System.Windows.Forms.DateTimePicker();
            this.txt_Code1 = new System.Windows.Forms.TextBox();
            this.txt_CandidateName1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_createCandidate = new System.Windows.Forms.DataGridView();
            this.CandidateName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodeCandidate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateBirthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CandidateHistory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobVancanyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_createCandidate)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_JobVancanyID1);
            this.groupBox1.Controls.Add(this.cb_Gender1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.bt_Filter);
            this.groupBox1.Controls.Add(this.btDel);
            this.groupBox1.Controls.Add(this.bt_addCandidate);
            this.groupBox1.Controls.Add(this.txt_Phone1);
            this.groupBox1.Controls.Add(this.dt_DateOfBirth1);
            this.groupBox1.Controls.Add(this.txt_Code1);
            this.groupBox1.Controls.Add(this.txt_CandidateName1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(943, 227);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hồ sơ ứng viên";
            // 
            // cb_JobVancanyID1
            // 
            this.cb_JobVancanyID1.FormattingEnabled = true;
            this.cb_JobVancanyID1.Location = new System.Drawing.Point(532, 109);
            this.cb_JobVancanyID1.Name = "cb_JobVancanyID1";
            this.cb_JobVancanyID1.Size = new System.Drawing.Size(222, 31);
            this.cb_JobVancanyID1.TabIndex = 22;
            // 
            // cb_Gender1
            // 
            this.cb_Gender1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_Gender1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_Gender1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Gender1.FormattingEnabled = true;
            this.cb_Gender1.Items.AddRange(new object[] {
            "Nam",
            "Nữ ",
            "Khác"});
            this.cb_Gender1.Location = new System.Drawing.Point(530, 36);
            this.cb_Gender1.Name = "cb_Gender1";
            this.cb_Gender1.Size = new System.Drawing.Size(225, 31);
            this.cb_Gender1.TabIndex = 21;
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(513, 182);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 41);
            this.button2.TabIndex = 20;
            this.button2.Text = "Đánh giá";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // bt_Filter
            // 
            this.bt_Filter.Image = ((System.Drawing.Image)(resources.GetObject("bt_Filter.Image")));
            this.bt_Filter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Filter.Location = new System.Drawing.Point(386, 182);
            this.bt_Filter.Name = "bt_Filter";
            this.bt_Filter.Size = new System.Drawing.Size(121, 41);
            this.bt_Filter.TabIndex = 19;
            this.bt_Filter.Text = "Tìm kiếm";
            this.bt_Filter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Filter.UseVisualStyleBackColor = true;
            this.bt_Filter.Click += new System.EventHandler(this.bt_Filter_Click);
            // 
            // btDel
            // 
            this.btDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btDel.Image = ((System.Drawing.Image)(resources.GetObject("btDel.Image")));
            this.btDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDel.Location = new System.Drawing.Point(259, 182);
            this.btDel.Name = "btDel";
            this.btDel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btDel.Size = new System.Drawing.Size(121, 41);
            this.btDel.TabIndex = 16;
            this.btDel.Text = "Xóa";
            this.btDel.UseVisualStyleBackColor = true;
            // 
            // bt_addCandidate
            // 
            this.bt_addCandidate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_addCandidate.Image = ((System.Drawing.Image)(resources.GetObject("bt_addCandidate.Image")));
            this.bt_addCandidate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_addCandidate.Location = new System.Drawing.Point(132, 182);
            this.bt_addCandidate.Name = "bt_addCandidate";
            this.bt_addCandidate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_addCandidate.Size = new System.Drawing.Size(121, 41);
            this.bt_addCandidate.TabIndex = 15;
            this.bt_addCandidate.Text = "Tạo mới";
            this.bt_addCandidate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_addCandidate.UseVisualStyleBackColor = true;
            this.bt_addCandidate.Click += new System.EventHandler(this.bt_addCandidate_Click);
            // 
            // txt_Phone1
            // 
            this.txt_Phone1.Location = new System.Drawing.Point(530, 73);
            this.txt_Phone1.Name = "txt_Phone1";
            this.txt_Phone1.Size = new System.Drawing.Size(225, 32);
            this.txt_Phone1.TabIndex = 12;
            // 
            // dt_DateOfBirth1
            // 
            this.dt_DateOfBirth1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_DateOfBirth1.Location = new System.Drawing.Point(135, 112);
            this.dt_DateOfBirth1.MinDate = new System.DateTime(2005, 1, 1, 0, 0, 0, 0);
            this.dt_DateOfBirth1.Name = "dt_DateOfBirth1";
            this.dt_DateOfBirth1.Size = new System.Drawing.Size(131, 32);
            this.dt_DateOfBirth1.TabIndex = 10;
            // 
            // txt_Code1
            // 
            this.txt_Code1.Location = new System.Drawing.Point(135, 76);
            this.txt_Code1.Name = "txt_Code1";
            this.txt_Code1.Size = new System.Drawing.Size(245, 32);
            this.txt_Code1.TabIndex = 9;
            // 
            // txt_CandidateName1
            // 
            this.txt_CandidateName1.Location = new System.Drawing.Point(135, 41);
            this.txt_CandidateName1.Name = "txt_CandidateName1";
            this.txt_CandidateName1.Size = new System.Drawing.Size(245, 32);
            this.txt_CandidateName1.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(422, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 23);
            this.label7.TabIndex = 7;
            this.label7.Text = "Vị trí tuyển";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(422, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Điện thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(422, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giới tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên ứng viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã ứng viên";
            // 
            // dgv_createCandidate
            // 
            this.dgv_createCandidate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_createCandidate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CandidateName,
            this.CodeCandidate,
            this.DateBirthday,
            this.Gender,
            this.Phone,
            this.Email,
            this.CandidateHistory,
            this.JobVancanyID,
            this.Status});
            this.dgv_createCandidate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_createCandidate.Location = new System.Drawing.Point(0, 229);
            this.dgv_createCandidate.Name = "dgv_createCandidate";
            this.dgv_createCandidate.Size = new System.Drawing.Size(943, 280);
            this.dgv_createCandidate.TabIndex = 2;
            // 
            // CandidateName
            // 
            this.CandidateName.DataPropertyName = "CandidateName";
            this.CandidateName.HeaderText = "Tên ứng viên";
            this.CandidateName.Name = "CandidateName";
            // 
            // CodeCandidate
            // 
            this.CodeCandidate.DataPropertyName = "CodeCandidate";
            this.CodeCandidate.HeaderText = "Mã";
            this.CodeCandidate.Name = "CodeCandidate";
            // 
            // DateBirthday
            // 
            this.DateBirthday.DataPropertyName = "DateBirthday";
            this.DateBirthday.HeaderText = "Ngày sinh";
            this.DateBirthday.Name = "DateBirthday";
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "Giới tính";
            this.Gender.Name = "Gender";
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "ĐT";
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
            this.CandidateHistory.HeaderText = "Ngoại ngữ";
            this.CandidateHistory.Name = "CandidateHistory";
            // 
            // JobVancanyID
            // 
            this.JobVancanyID.DataPropertyName = "JobVancanyID";
            this.JobVancanyID.HeaderText = "Vị trí tuyển";
            this.JobVancanyID.Name = "JobVancanyID";
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Trạng thái";
            this.Status.Name = "Status";
            // 
            // Candidate1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 509);
            this.Controls.Add(this.dgv_createCandidate);
            this.Controls.Add(this.groupBox1);
            this.Name = "Candidate1";
            this.Text = "Candidate1";
            this.Load += new System.EventHandler(this.Candidate1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_createCandidate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_Filter;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.Button bt_addCandidate;
        private System.Windows.Forms.TextBox txt_Phone1;
        private System.Windows.Forms.DateTimePicker dt_DateOfBirth1;
        private System.Windows.Forms.TextBox txt_Code1;
        private System.Windows.Forms.TextBox txt_CandidateName1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgv_createCandidate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CandidateName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeCandidate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateBirthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn CandidateHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobVancanyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.ComboBox cb_JobVancanyID1;
        private System.Windows.Forms.ComboBox cb_Gender1;
    }
}