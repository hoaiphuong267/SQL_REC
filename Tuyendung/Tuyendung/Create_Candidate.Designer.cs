namespace Tuyendung
{
    partial class Create_Candidate
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
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_Image = new System.Windows.Forms.Button();
            this.pic_1 = new System.Windows.Forms.PictureBox();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.dtime_DateOfbrith = new System.Windows.Forms.DateTimePicker();
            this.txt_CandidateName = new System.Windows.Forms.TextBox();
            this.txt_CodeCandidate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_Save = new System.Windows.Forms.Button();
            this.bt_Comeback_candidate = new System.Windows.Forms.Button();
            this.cb_JobVancanyID = new System.Windows.Forms.ComboBox();
            this.cb_Gender = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_Language = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_Language);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cb_Gender);
            this.groupBox1.Controls.Add(this.cb_JobVancanyID);
            this.groupBox1.Controls.Add(this.txt_Email);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.bt_Image);
            this.groupBox1.Controls.Add(this.pic_1);
            this.groupBox1.Controls.Add(this.txt_Phone);
            this.groupBox1.Controls.Add(this.dtime_DateOfbrith);
            this.groupBox1.Controls.Add(this.txt_CandidateName);
            this.groupBox1.Controls.Add(this.txt_CodeCandidate);
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
            this.groupBox1.Size = new System.Drawing.Size(707, 340);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tạo mới Hồ sơ ứng viên";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(135, 252);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(225, 32);
            this.txt_Email.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 23);
            this.label3.TabIndex = 22;
            this.label3.Text = "Email";
            // 
            // bt_Image
            // 
            this.bt_Image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_Image.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Image.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Image.Location = new System.Drawing.Point(479, 203);
            this.bt_Image.Name = "bt_Image";
            this.bt_Image.Size = new System.Drawing.Size(156, 26);
            this.bt_Image.TabIndex = 18;
            this.bt_Image.Text = "Chọn ảnh";
            this.bt_Image.UseVisualStyleBackColor = true;
            this.bt_Image.Click += new System.EventHandler(this.bt_Image_Click);
            // 
            // pic_1
            // 
            this.pic_1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pic_1.Location = new System.Drawing.Point(430, 29);
            this.pic_1.Name = "pic_1";
            this.pic_1.Size = new System.Drawing.Size(249, 168);
            this.pic_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_1.TabIndex = 17;
            this.pic_1.TabStop = false;
            this.pic_1.Click += new System.EventHandler(this.pic_1_Click);
            // 
            // txt_Phone
            // 
            this.txt_Phone.Location = new System.Drawing.Point(135, 180);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(225, 32);
            this.txt_Phone.TabIndex = 12;
            // 
            // dtime_DateOfbrith
            // 
            this.dtime_DateOfbrith.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtime_DateOfbrith.Location = new System.Drawing.Point(135, 108);
            this.dtime_DateOfbrith.Name = "dtime_DateOfbrith";
            this.dtime_DateOfbrith.Size = new System.Drawing.Size(156, 32);
            this.dtime_DateOfbrith.TabIndex = 10;
            // 
            // txt_CandidateName
            // 
            this.txt_CandidateName.Location = new System.Drawing.Point(135, 35);
            this.txt_CandidateName.Name = "txt_CandidateName";
            this.txt_CandidateName.Size = new System.Drawing.Size(245, 32);
            this.txt_CandidateName.TabIndex = 9;
            // 
            // txt_CodeCandidate
            // 
            this.txt_CodeCandidate.Location = new System.Drawing.Point(135, 70);
            this.txt_CodeCandidate.Name = "txt_CodeCandidate";
            this.txt_CodeCandidate.Size = new System.Drawing.Size(245, 32);
            this.txt_CodeCandidate.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 23);
            this.label7.TabIndex = 7;
            this.label7.Text = "Vị trí tuyển";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 180);
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
            this.label4.Location = new System.Drawing.Point(16, 145);
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
            // bt_Save
            // 
            this.bt_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Save.Location = new System.Drawing.Point(195, 346);
            this.bt_Save.Name = "bt_Save";
            this.bt_Save.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_Save.Size = new System.Drawing.Size(121, 41);
            this.bt_Save.TabIndex = 21;
            this.bt_Save.Text = "Lưu";
            this.bt_Save.UseVisualStyleBackColor = true;
            this.bt_Save.Click += new System.EventHandler(this.bt_Save_Click);
            // 
            // bt_Comeback_candidate
            // 
            this.bt_Comeback_candidate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_Comeback_candidate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Comeback_candidate.Location = new System.Drawing.Point(324, 346);
            this.bt_Comeback_candidate.Name = "bt_Comeback_candidate";
            this.bt_Comeback_candidate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_Comeback_candidate.Size = new System.Drawing.Size(121, 41);
            this.bt_Comeback_candidate.TabIndex = 19;
            this.bt_Comeback_candidate.Text = "Quay về ";
            this.bt_Comeback_candidate.UseVisualStyleBackColor = true;
            this.bt_Comeback_candidate.Click += new System.EventHandler(this.bt_Comeback_candidate_Click);
            // 
            // cb_JobVancanyID
            // 
            this.cb_JobVancanyID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_JobVancanyID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_JobVancanyID.FormattingEnabled = true;
            this.cb_JobVancanyID.Location = new System.Drawing.Point(135, 216);
            this.cb_JobVancanyID.Name = "cb_JobVancanyID";
            this.cb_JobVancanyID.Size = new System.Drawing.Size(224, 31);
            this.cb_JobVancanyID.TabIndex = 24;
            // 
            // cb_Gender
            // 
            this.cb_Gender.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_Gender.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_Gender.FormattingEnabled = true;
            this.cb_Gender.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cb_Gender.Location = new System.Drawing.Point(136, 145);
            this.cb_Gender.Name = "cb_Gender";
            this.cb_Gender.Size = new System.Drawing.Size(224, 31);
            this.cb_Gender.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 295);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 23);
            this.label8.TabIndex = 26;
            this.label8.Text = "Ngoại ngữ";
            // 
            // cb_Language
            // 
            this.cb_Language.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_Language.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_Language.FormattingEnabled = true;
            this.cb_Language.Items.AddRange(new object[] {
            "Anh văn bằng B",
            "Anh văn bằng C",
            "Toeic 300",
            "Toeic 350",
            "Toeic 400",
            "Toeic 450",
            "Toeic 500",
            "Toeic 550",
            "Toeic 600",
            "Toeic 650",
            "Toeic 700",
            "Toeic 750",
            "Toeic 800",
            "Toeic 850",
            "Toeic 900",
            "Toeic 950",
            "Tiếng Nhật B1",
            "Tiếng Pháp"});
            this.cb_Language.Location = new System.Drawing.Point(135, 292);
            this.cb_Language.Name = "cb_Language";
            this.cb_Language.Size = new System.Drawing.Size(224, 31);
            this.cb_Language.TabIndex = 27;
            // 
            // Create_Candidate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 399);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_Save);
            this.Controls.Add(this.bt_Comeback_candidate);
            this.Name = "Create_Candidate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Candidate";
            this.Load += new System.EventHandler(this.Create_Candidate_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Phone;
        private System.Windows.Forms.DateTimePicker dtime_DateOfbrith;
        private System.Windows.Forms.TextBox txt_CandidateName;
        private System.Windows.Forms.TextBox txt_CodeCandidate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pic_1;
        private System.Windows.Forms.Button bt_Image;
        private System.Windows.Forms.Button bt_Comeback_candidate;
        private System.Windows.Forms.Button bt_Save;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_JobVancanyID;
        private System.Windows.Forms.ComboBox cb_Language;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_Gender;
    }
}