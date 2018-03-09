namespace Tuyendung
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHosotrungtuyen = new System.Windows.Forms.Button();
            this.bt_Interview = new System.Windows.Forms.Button();
            this.bt_InterviewCampaign = new System.Windows.Forms.Button();
            this.btnJobVancany = new System.Windows.Forms.Button();
            this.bt_Candidate = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumBlue;
            this.panel2.Controls.Add(this.btnHosotrungtuyen);
            this.panel2.Controls.Add(this.bt_Interview);
            this.panel2.Controls.Add(this.bt_InterviewCampaign);
            this.panel2.Controls.Add(this.btnJobVancany);
            this.panel2.Controls.Add(this.bt_Candidate);
            this.panel2.Location = new System.Drawing.Point(1, 131);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(273, 503);
            this.panel2.TabIndex = 1;
            // 
            // btnHosotrungtuyen
            // 
            this.btnHosotrungtuyen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHosotrungtuyen.BackgroundImage")));
            this.btnHosotrungtuyen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHosotrungtuyen.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHosotrungtuyen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnHosotrungtuyen.Location = new System.Drawing.Point(28, 320);
            this.btnHosotrungtuyen.Name = "btnHosotrungtuyen";
            this.btnHosotrungtuyen.Size = new System.Drawing.Size(227, 65);
            this.btnHosotrungtuyen.TabIndex = 2;
            this.btnHosotrungtuyen.Text = "Hồ sơ trúng tuyển";
            this.btnHosotrungtuyen.UseVisualStyleBackColor = true;
            this.btnHosotrungtuyen.Click += new System.EventHandler(this.btnHosotrungtuyen_Click);
            // 
            // bt_Interview
            // 
            this.bt_Interview.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_Interview.BackgroundImage")));
            this.bt_Interview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_Interview.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Interview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bt_Interview.Location = new System.Drawing.Point(28, 249);
            this.bt_Interview.Name = "bt_Interview";
            this.bt_Interview.Size = new System.Drawing.Size(227, 65);
            this.bt_Interview.TabIndex = 2;
            this.bt_Interview.Text = "Phỏng vấn";
            this.bt_Interview.UseVisualStyleBackColor = true;
            // 
            // bt_InterviewCampaign
            // 
            this.bt_InterviewCampaign.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_InterviewCampaign.BackgroundImage")));
            this.bt_InterviewCampaign.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_InterviewCampaign.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_InterviewCampaign.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bt_InterviewCampaign.Location = new System.Drawing.Point(28, 178);
            this.bt_InterviewCampaign.Name = "bt_InterviewCampaign";
            this.bt_InterviewCampaign.Size = new System.Drawing.Size(227, 65);
            this.bt_InterviewCampaign.TabIndex = 2;
            this.bt_InterviewCampaign.Text = "Chờ lịch phỏng vấn";
            this.bt_InterviewCampaign.UseVisualStyleBackColor = true;
            // 
            // btnJobVancany
            // 
            this.btnJobVancany.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnJobVancany.BackgroundImage")));
            this.btnJobVancany.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnJobVancany.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJobVancany.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnJobVancany.Location = new System.Drawing.Point(28, 36);
            this.btnJobVancany.Name = "btnJobVancany";
            this.btnJobVancany.Size = new System.Drawing.Size(227, 65);
            this.btnJobVancany.TabIndex = 2;
            this.btnJobVancany.Text = "Yêu cầu Tuyển dụng";
            this.btnJobVancany.UseVisualStyleBackColor = true;
            this.btnJobVancany.Click += new System.EventHandler(this.btnJobVancany_Click);
            // 
            // bt_Candidate
            // 
            this.bt_Candidate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_Candidate.BackgroundImage")));
            this.bt_Candidate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_Candidate.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Candidate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bt_Candidate.Location = new System.Drawing.Point(28, 107);
            this.bt_Candidate.Name = "bt_Candidate";
            this.bt_Candidate.Size = new System.Drawing.Size(227, 65);
            this.bt_Candidate.TabIndex = 2;
            this.bt_Candidate.Text = "Hồ sơ ứng viên";
            this.bt_Candidate.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aqua;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1272, 131);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(429, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(719, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "CHƯƠNG TRÌNH QUẢN LÝ TUYỂN DỤNG";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Tuyendung.Properties.Resources._1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 128);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Location = new System.Drawing.Point(276, 133);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(997, 501);
            this.panel3.TabIndex = 4;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 648);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm tuyển dụng";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

       
       
        private System.Windows.Forms.Panel panel2;
      
        private System.Windows.Forms.Button btnHosotrungtuyen;
        private System.Windows.Forms.Button bt_Interview;
        private System.Windows.Forms.Button bt_InterviewCampaign;
        private System.Windows.Forms.Button btnJobVancany;
        private System.Windows.Forms.Button bt_Candidate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
    }
}