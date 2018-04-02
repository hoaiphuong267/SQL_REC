using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Tuyendung
{
    public partial class Interview_Creation : Form
    {
        SqlConnection cnn = new SqlConnection(@"Data Source = CHAOS-LORD\CHAOS;Initial Catalog=QLTD;Integrated Security=True");
        //SqlConnection cnn = new SqlConnection(@"Data Source = .\SQLExpress;Initial Catalog=QLTD;Integrated Security=True");
        public Interview_Creation()
        {
            InitializeComponent();
        }
      
        private void btSearch_Click_1(object sender, EventArgs e)
        {
            try
            {
                cnn.Open();
                string sql = "SELECT InterviewID AS 'Mã Phỏng vấn', CandidateID AS 'Mã Ứng viên', JobVancanyName AS 'Vị trí Ứng tuyển', InterviewerName1 AS 'Giám khảo 1', InterviewerName2 AS 'Giám khảo 2', InterviewerName3 AS 'Giám khảo 3', Result1 AS ' Kết quả Cuối cùng' FROM Interview WHERE Result1 = 1 AND Result2 = 1 AND Result3 = 1";  // lay het du lieu trong bang sinh vien
                //string sql = "SELECT InterviewID AS 'Mã Phỏng vấn', CandidateID AS 'Mã Ứng viên', JobVancanyName AS 'Vị trí Ứng tuyển', InterviewerName1 AS 'Giám khảo 1', InterviewerName2 AS 'Giám khảo 2', InterviewerName3 AS 'Giám khảo 3', Result1 AS ' Kết quả Cuối cùng' FROM Interview";  // lay het du lieu trong bang sinh vien
                SqlCommand com = new SqlCommand(sql, cnn); //bat dau truy van
                //com.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
                DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
                da.Fill(dt);  // đổ dữ liệu vào kho
                cnn.Close();  // đóng kết nối
                dgvInterview.DataSource = dt;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Interview_Creation_Load(object sender, EventArgs e)
        {

        }

        private void btCreate_Click(object sender, EventArgs e)
        {
            cnn.Open();
            //string sql = "SELECT InterviewID AS 'Mã Phỏng vấn', CandidateID AS 'Mã Ứng viên', JobVancanyName AS 'Vị trí Ứng tuyển', InterviewerName1 AS 'Giám khảo 1', InterviewerName2 AS 'Giám khảo 2', InterviewerName3 AS 'Giám khảo 3', Result1 AS ' Kết quả Cuối cùng' FROM Interview WHERE Result1 = 1 AND Result2 = 1 AND Result3 = 1";  // lay het du lieu trong bang sinh vien
            string sql = "SELECT InterviewID AS 'Mã Phỏng vấn', CandidateID AS 'Mã Ứng viên', JobVancanyName AS 'Vị trí Ứng tuyển', InterviewerName1 AS 'Giám khảo 1', InterviewerName2 AS 'Giám khảo 2', InterviewerName3 AS 'Giám khảo 3', Result1 AS ' Kết quả Cuối cùng' FROM Interview";  // lay het du lieu trong bang sinh vien
            SqlCommand com = new SqlCommand(sql, cnn); //bat dau truy van
            //com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            cnn.Close();  // đóng kết nối
            dgvInterview.DataSource = dt;
            //////////////////////////////////
            
            if (!btCancel.Enabled)
            { 
                btSearch.Enabled = false;
                btCancel.Enabled = true;
                /////

                checkBox1.Checked = false; checkBox3.Checked = true;
                checkBox4.Checked = false; checkBox6.Checked = true;
                checkBox7.Checked = false; checkBox9.Checked = true;
                

            }
            else if (!btSearch.Enabled)
            {

                if (txtCanidateID.Text == "" || txtCanidateName.Text == "" || txtJobVancany.Text == "" || txtInterviewerNo1.Text == "" || txtInterviewerNo2.Text == "" || txtInterviewerNo3.Text == "" || cbHours.Text == "" || cbMinutes.Text == "")
                {
                    MessageBox.Show("Empty Space. Typo Required!");
                }
                
                else
                ////////
                {
                    try
                    {
                        cnn.Open();
                        string ins = "INSERT INTO Interview (CandidateID, CanidateName, JobVancanyName, InterviewerName1, InterviewerName2, InterviewerName3, Result1, Result2, Result3, InterviewDate, InterviewTime) VALUES ('" + txtCanidateID.Text + "','" + txtCanidateName.Text + "','" + txtJobVancany.Text + "','" + txtInterviewerNo1.Text + "','" + txtInterviewerNo2.Text + "','" + txtInterviewerNo3.Text + "','" + 0 + "','" + 0 + "','" + 0 + "','" + dtpInterviewDate.Value.Date + "','" + cbHours.Text + ':' + cbMinutes.Text + "')";
                        SqlCommand cmd = new SqlCommand(ins, cnn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm Thành Công");
                        cnn.Close();
                        //ketnoicsdl();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        cnn.Close();
                    }
                }

            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            btSearch.Enabled = true;
            btCancel.Enabled = false;
            /////
            checkBox3.Checked = false; checkBox1.Checked = true;
            checkBox6.Checked = false; checkBox4.Checked = true;
            checkBox9.Checked = false; checkBox7.Checked = true; 
            /////
            txtCanidateName.Clear(); txtInterviewerNo1.Clear(); txtInterviewerNo2.Clear(); txtInterviewerNo3.Clear();
            txtCanidateID.Clear(); txtJobVancany.Clear();
            //////
            dgvInterview.DataSource = null;

        }

        private void txtCanidateID_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            /*if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }*/
        }

        private void txtCanidateName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }
        
    }
}

