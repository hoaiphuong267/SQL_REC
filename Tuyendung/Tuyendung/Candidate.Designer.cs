﻿namespace Tuyendung
{
    partial class Candidate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Candidate));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_Filter = new System.Windows.Forms.Button();
            this.bt_Image = new System.Windows.Forms.Button();
            this.pic_1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bt_addCandidate = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txt_CodeCandidate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_Filter);
            this.groupBox1.Controls.Add(this.bt_Image);
            this.groupBox1.Controls.Add(this.pic_1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.bt_addCandidate);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.txt_CodeCandidate);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1214, 215);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu > Tuyển Dụng > Hồ sơ ứng viên";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // bt_Filter
            // 
            this.bt_Filter.Image = ((System.Drawing.Image)(resources.GetObject("bt_Filter.Image")));
            this.bt_Filter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Filter.Location = new System.Drawing.Point(264, 151);
            this.bt_Filter.Name = "bt_Filter";
            this.bt_Filter.Size = new System.Drawing.Size(130, 41);
            this.bt_Filter.TabIndex = 19;
            this.bt_Filter.Text = "Đánh giá";
            this.bt_Filter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Filter.UseVisualStyleBackColor = true;
            this.bt_Filter.Click += new System.EventHandler(this.bt_Filter_Click);
            // 
            // bt_Image
            // 
            this.bt_Image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_Image.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Image.Image = ((System.Drawing.Image)(resources.GetObject("bt_Image.Image")));
            this.bt_Image.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Image.Location = new System.Drawing.Point(524, 154);
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
            this.pic_1.Location = new System.Drawing.Point(695, 24);
            this.pic_1.Name = "pic_1";
            this.pic_1.Size = new System.Drawing.Size(249, 168);
            this.pic_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_1.TabIndex = 17;
            this.pic_1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(127, 154);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(131, 41);
            this.button1.TabIndex = 16;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_addCandidate
            // 
            this.bt_addCandidate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_addCandidate.Image = ((System.Drawing.Image)(resources.GetObject("bt_addCandidate.Image")));
            this.bt_addCandidate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_addCandidate.Location = new System.Drawing.Point(0, 151);
            this.bt_addCandidate.Name = "bt_addCandidate";
            this.bt_addCandidate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_addCandidate.Size = new System.Drawing.Size(121, 41);
            this.bt_addCandidate.TabIndex = 15;
            this.bt_addCandidate.Text = "Tạo mới";
            this.bt_addCandidate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_addCandidate.UseVisualStyleBackColor = true;
            this.bt_addCandidate.Click += new System.EventHandler(this.bt_addCandidate_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(524, 116);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(156, 32);
            this.textBox5.TabIndex = 14;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(524, 70);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(156, 32);
            this.textBox3.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(524, 31);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(156, 32);
            this.textBox2.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(137, 116);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(153, 32);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(135, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 32);
            this.textBox1.TabIndex = 9;
            // 
            // txt_CodeCandidate
            // 
            this.txt_CodeCandidate.Location = new System.Drawing.Point(135, 38);
            this.txt_CodeCandidate.Name = "txt_CodeCandidate";
            this.txt_CodeCandidate.Size = new System.Drawing.Size(156, 32);
            this.txt_CodeCandidate.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(384, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 23);
            this.label7.TabIndex = 7;
            this.label7.Text = "Vị trí tuyển";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(384, 79);
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
            this.label4.Location = new System.Drawing.Point(384, 38);
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 224);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1001, 287);
            this.dataGridView1.TabIndex = 1;
            // 
            // Candidate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 511);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Candidate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Candidate";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bt_addCandidate;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txt_CodeCandidate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pic_1;
        private System.Windows.Forms.Button bt_Image;
        private System.Windows.Forms.Button bt_Filter;
    }
}