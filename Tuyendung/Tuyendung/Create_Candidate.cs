using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Data.SqlClient;

namespace Tuyendung
{
    public partial class Create_Candidate : Form
    {
        SqlConnection cnn = new SqlConnection(@"Data Source = .\SQLExpress;Initial Catalog=QLTD;Integrated Security=True");
        public Create_Candidate()
        {
            InitializeComponent();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }
        private void bt_Image_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "Image file (*.jpg;*jpeg;*.gif;*.bmp;*.png)|*.jpg;*jpeg;*.gì;*.bmp;*.png|"
                    + "jpeg file (*.jpeg,*.jpg)|*.jpeg,*.jpg|"
                    + "gif file (*.gif)|*.gif|"
                    + "bmp file (*.bmp)|*.bmp|"
                    + "png file (*.png)|*.png|"
                    + "All file (*.*)|*.*";
                if(dlg.ShowDialog() == DialogResult.OK)
                {
                    string filechoose = dlg.FileName;
                    pic_1.Image = Image.FromFile(dlg.FileName);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("À", "eRORN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
        }
        private void bt_Filter_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {  
        }
        private void bt_Comeback_candidate_Click(object sender, EventArgs e)
        {
            Candidate1 frmcc = new Candidate1();
            this.Hide();
            frmcc.ShowDialog();
            this.Close();
        }
        private void ketnoicsdl()
        {
            cnn.Open();
            string sql = "select * from Candidate"; 
            SqlCommand com = new SqlCommand(sql, cnn); 
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            cnn.Close();  // đóng kết nối
            dgv_createCandidate.DataSource = dt;
          
            //dgv_.DataSource = dt; //đổ dữ liệu vào datagridview
            //txtMVTT.Enabled = false;
            //txtMVTT.Text = "ID Autonumber";
            //txtMDKTuyen.Enabled = false;
            //txtMDKTuyen.Text = "ID Autonumber";

        }
        private void bt_Save_Click(object sender, EventArgs e)
        {
            //SaveFileDialog dlg1 = new SaveFileDialog();
            //dlg1.Filter = "Image file (*.jpg;*jpeg;*.gif;*.bmp;*.png)|*.jpg;*jpeg;*.gì;*.bmp;*.png|"
            //        + "jpeg file (*.jpeg,*.jpg)|*.jpeg,*.jpg|"
            //        + "gif file (*.gif)|*.gif|"
            //        + "bmp file (*.bmp)|*.bmp|"
            //        + "png file (*.png)|*.png|"
            //        + "All file (*.*)|*.*";
            ////mac dinh load là png
            //ImageFormat fomat = ImageFormat.Png;
            //if (dlg1.ShowDialog() == DialogResult.OK)
            //{
            //    string ex = Path.GetExtension(dlg1.FileName);
            //    switch (ex)
            //    {
            //        case ".jpg":
            //            fomat = ImageFormat.Jpeg;
            //            break;
            //        case ".jpeg":
            //            fomat = ImageFormat.Jpeg;
            //            break;
            //        case ".git":
            //            fomat = ImageFormat.Gif;
            //            break;
            //        case ".png":
            //            fomat = ImageFormat.Png;
            //            break;
            //        case ".bmp":
            //            fomat = ImageFormat.Bmp;
            //            break;
            //    }
            //    pic_1.Image.Save(dlg1.FileName, fomat);
            //}
            cnn.Open();
           // string ins = "INSERT INTO JobVancany(DateStart, DateEnd, Soluong ,LevelInterview , JobVancanyName ) VALUES ('" + dtDateStart.Value + "','" + dtDateEnd.Value + "','" + txtSoluong.Text + "','" + txtSoVongTuyen.Text + "','" + txtTenVT.Text + "')";
            //SqlCommand cmd = new SqlCommand(ins, cnn);
            MessageBox.Show("Thao tác thành công");
            cnn.Close();

            
        }

       

    }
}
