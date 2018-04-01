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
                string sql = "SELECT InterviewID AS 'Mã Phỏng vấn', CandidateID AS 'Mã Ứng viên', JobVancanyName AS 'Vị trí Ứng tuyển', InterviewerName1 AS 'Giám khảo 1', Result1 AS ' Kết quả 1', InterviewerName2 AS 'Giám khảo 2', Result2 AS ' Kết quả 2', InterviewerName3 AS 'Giám khảo 3', Result3 AS ' Kết quả 3' FROM Interview WHERE Result1 = 1 AND Result2 = 1 AND Result3 = 1";  // lay het du lieu trong bang sinh vien
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
            if (!btCancel.Enabled)
            { 
                btSearch.Enabled = false;
                btCancel.Enabled = true;

            }
            else if (btCancel.Enabled)
            {
                var boxes = Controls.OfType<TextBox>(); 
                foreach (var box in boxes)
                {
                    if (string.IsNullOrWhiteSpace(box.Text))
                    {
                        errorProvider1.SetError(box, "Ô còn trống, làm ơn điền vào!");
                    }
                }
                ////////
                cnn.Open();
                string ins = "INSERT INTO Interview (CandidateID, txtCanidateName) VALUES ('" + txtCanidateID.Text + "','" + txtCanidateName.Text + "','" + dateTimePicker2.Value.Date + "')";
                SqlCommand cmd = new SqlCommand(ins, cnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm Thành Cong");
                cnn.Close();
                //ketnoicsdl();
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            btSearch.Enabled = true;
            btCancel.Enabled = false;
        }
    }
}
