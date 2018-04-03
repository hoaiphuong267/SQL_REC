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
        //SqlConnection cnn = new SqlConnection(@"Data Source = CHAOS-LORD\CHAOS;Initial Catalog=QLTD;Integrated Security=True");

        SqlConnection cnn = new SqlConnection(@"Data Source = .\SQLExpress;Initial Catalog=QLTD;Integrated Security=True");
        //SqlConnection cnn = new SqlConnection(@"Data Source = .;Initial Catalog=QLTD;Integrated Security=True");
        string file = "";
        public Create_Candidate()
        {
            InitializeComponent();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }
        //button mo anh
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
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    //string filechoose = dlg.FileName;
                    //pic_1.Image = Image.FromFile(dlg.FileName);
                    file = dlg.FileName.ToString();
                    pic_1.ImageLocation = file;
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
            Menu frmcc = new Menu();
            this.Hide();
            frmcc.ShowDialog();
            this.Close();
        }
        //load du lieu len datagritview
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
        }
        //ham lam moi
        private void ClearAllText(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c is TextBox || c is ComboBox && c is DateTimePicker && (pic_1.Image != null))
                {
                    c.Text = "";
                    cb_Gender.SelectedIndex = -1;
                    cb_Language.SelectedIndex = -1;
                    cb_JobVancanyID.SelectedIndex = -1;
                    //this.dtime_DateOfbrith.CustomFormat = null;
                    pic_1.Image = null;
                }
                else
                    ClearAllText(c);
            }
        }
        //hàm lưu
        private void bt_Save_Click(object sender, EventArgs e)
        {
            //cnn.Open();
            if (txt_CandidateName.Text == String.Empty || txt_CodeCandidate.Text == String.Empty || dtime_DateOfbrith.Text == String.Empty || cb_Gender.Text == String.Empty || txt_Phone.Text == String.Empty || txt_Email.Text == String.Empty || cb_Language.Text == String.Empty )
            {
                MessageBox.Show("All fields are required!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    cnn.Open();
                    byte[] image = null;
                    FileStream str = new FileStream(file, FileMode.Open, FileAccess.Read);
                    BinaryReader brs = new BinaryReader(str);
                    image = brs.ReadBytes((int)str.Length);
                    string ins = "INSERT INTO Candidate(CandidateName,CodeCandidate,DateBirthday,Gender,Phone,Email,CandidateHistory,JobVancanyID,pic) VALUES ('" + txt_CandidateName.Text.Trim() + "','" + txt_CodeCandidate.Text.Replace(" ", String.Empty) + "','" + dtime_DateOfbrith.Value + "','" + cb_Gender.Text + "','" + txt_Phone.Text.Replace(" ", String.Empty) + "','" + txt_Email.Text.Replace(" ", String.Empty) + "','" + cb_Language.Text + "','" + Convert.ToInt32(cb_JobVancanyID.SelectedValue) + "',@image)";
                    SqlCommand cmd = new SqlCommand(ins, cnn);
                    cmd.Parameters.Add(new SqlParameter("@image", image));
                    //cmd.CommandType = CommandType.Text;             
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm Thành Cong");
                    cnn.Close();
                    ClearAllText(this);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thao tác không thành công");
                    MessageBox.Show(ex.Message);
                }
            }

        }
        private void txt_JobVancancyID_TextChanged(object sender, EventArgs e)
        {
        }
        private void pic_1_Click(object sender, EventArgs e)
        {
        }
        //ham load vi tri tuyen
        private void Create_Candidate_Load(object sender, EventArgs e)
        {
            cnn.Open();
            try
            {
                string strCmd = "select JobVancanyID,JobVancanyName from JobVancany";
                SqlCommand cmd = new SqlCommand(strCmd, cnn);
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                cb_JobVancanyID.DisplayMember = "JobVancanyName";
                cb_JobVancanyID.ValueMember = "JobVancanyID";
                cb_JobVancanyID.DataSource = dt;
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_Phone_TextChanged(object sender, EventArgs e)
        {

            if (System.Text.RegularExpressions.Regex.IsMatch(txt_Phone.Text, " ^[0-9]"))
            {
                txt_Phone.Text = "";
            }
        }

        private void txt_Phone_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
