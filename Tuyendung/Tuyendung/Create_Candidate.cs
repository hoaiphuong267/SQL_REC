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
        //private void ketnoicsdl()
        //{
        //    cnn.Open();
        //    string sql = "select * from Candidate"; 
        //    SqlCommand com = new SqlCommand(sql, cnn); 
        //    com.CommandType = CommandType.Text;
        //    SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
        //    DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
        //    da.Fill(dt);  // đổ dữ liệu vào kho
        //    cnn.Close();  // đóng kết nối
        //    dgv_createCandidate.DataSource = dt;
        //}
        //ham lam moi
        private void ClearAllText(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
                else
                    ClearAllText(c);
            }
        }
        private void bt_Save_Click(object sender, EventArgs e)
        {
            try
            {
                MemoryStream st = new MemoryStream();
                pic_1.Image.Save(st, ImageFormat.Jpeg);
                //anh luu xuong database bat buoc con nhung field khac?
                MyImgDataContext myDB = new MyImgDataContext();
                Candidate cd = new Candidate();
                cd.CandidateName = txt_CandidateName.Text;
                cd.CodeCandidate = txt_CodeCandidate.Text;
                cd.DateBirthday = dtime_DateOfbrith.Value;
                cd.Genth = txt_Gender.Text;
                cd.Phone = txt_Phone.Text;
                cd.Img = st.ToArray();
                myDB.Candidates.InsertOnSubmit(cd);
                myDB.SubmitChanges();
                MessageBox.Show("Thao tác thành công");
                ClearAllText(this);
            }
            catch (Exception)
            {
                MessageBox.Show("Thao tác không thành công");
            }       
        }     
    }
}
