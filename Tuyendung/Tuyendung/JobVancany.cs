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
    public partial class JobVancany : Form
    {
        SqlConnection cnn = new SqlConnection(@"Data Source = .\SQLExpress;Initial Catalog=QLTD;Integrated Security=True");
        public JobVancany()
        {
            InitializeComponent();
        }

        private void ketnoicsdl()
        {
            cnn.Open();
            string sql = "select * from JobVancany";  // lay het du lieu trong bang sinh vien
            SqlCommand com = new SqlCommand(sql, cnn); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            cnn.Close();  // đóng kết nối
            dgvJobVancany.DataSource = dt; //đổ dữ liệu vào datagridview
            txtMVTT.Enabled = false;
            txtMVTT.Text = "ID Autonumber";
            txtMDKTuyen.Enabled = false;
            txtMDKTuyen.Text = "ID Autonumber";

        }

        private void JobVancany_Load(object sender, EventArgs e)
        {
            ketnoicsdl();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cnn.Open();
            string ins = "INSERT INTO JobVancany(DateStart, DateEnd, Soluong ,LevelInterview , JobVancanyName ) VALUES ('" + dtDateStart.Value + "','" + dtDateEnd.Value + "','" + txtSoluong.Text + "','" + txtSoVongTuyen.Text + "','" + txtTenVT.Text + "')";
            SqlCommand cmd = new SqlCommand(ins, cnn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Thêm Thành Cong");
            cnn.Close();
            ketnoicsdl();

        }

        private void dgvJobVancany_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvJobVancany.Rows[e.RowIndex];
                txtMVTT.Text = row.Cells[0].Value.ToString();
                txtTenVT.Text = row.Cells[1].Value.ToString();
                dtDateStart.Value = Convert.ToDateTime(row.Cells[2].Value.ToString());
                dtDateEnd.Value = Convert.ToDateTime(row.Cells[3].Value.ToString());
                txtSoluong.Text = row.Cells[4].Value.ToString();
                txtSoVongTuyen.Text = row.Cells[5].Value.ToString();
                txtMDKTuyen.Text = row.Cells[6].Value.ToString();



            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            cnn.Open();
            string ins1 = "UPDATE JobVancany SET DateStart='" + dtDateStart.Value + "', DateEnd='" + dtDateEnd.Value + "',Soluong = '" + txtSoluong.Text + "', LevelInterview='" + txtSoVongTuyen.Text + "', JobVancanyName='" + txtTenVT.Text + "' WHERE JobVancanyID= '" + txtMVTT.Text + "'";
            SqlCommand cmd = new SqlCommand(ins1, cnn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Sửa Thành Cong");
            cnn.Close();
            ketnoicsdl();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            cnn.Open();
            string ins1 = "UPDATE JobVancany SET DateStart='" + dtDateStart.Value + "', DateEnd='" + dtDateEnd.Value + "',Soluong = '" + txtSoluong.Text + "', LevelInterview='" + txtSoVongTuyen.Text + "', JobVancanyName='" + txtTenVT.Text + "' WHERE JobVancanyID= '" + txtMVTT.Text + "' AND isdelete = 0 ";
            SqlCommand cmd = new SqlCommand(ins1, cnn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Sửa Thành Cong");
            cnn.Close();
            ketnoicsdl();
        }
    }
}
