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
            string sql = "select * from JobVancany"; 
            SqlCommand com = new SqlCommand(sql, cnn); 
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable(); 
            da.Fill(dt); 
            cnn.Close();  
            dgvJobVancany.DataSource = dt; 
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
            try
            {
                DialogResult result = MessageBox.Show("Bạn muốn xóa?", "Yes or No", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    
                    string ins1 = " UPDATE JobVancany SET isdelete = 1 WHERE JobVancanyID= '" + txtMVTT.Text + "'";
                    SqlCommand cmd = new SqlCommand(ins1, cnn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa Thành Cong");
                    //this.dgvJobVancany.Rows[index].Visible = false;
                    cnn.Close();
                    ketnoicsdl();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
           
        

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            //cnn.Open();
            var sb = new StringBuilder("select JobVancanyName,DateStart,DateEnd,Soluong,LevelInterview from JobVancany WHERE 1=1");
            if (!string.IsNullOrEmpty(txtTenVT.Text))
                sb.Append(" AND JobVancanyName like '%" + txtTenVT.Text + "%'");
            if (!string.IsNullOrEmpty(dtDateStart.Text))
                sb.Append(" AND DateStart like '%" + dtDateStart.Text + "%'");
            //if (!string.IsNullOrEmpty(dtDateEnd.Text))
            //    sb.Append(" OR DateEnd like '%" + dtDateEnd.Text+ "%'");
            if (!string.IsNullOrEmpty(txtSoluong.Text))
                sb.Append(" AND Soluong like '%" + txtSoluong.Text + "%'");
            if (!string.IsNullOrEmpty(txtSoVongTuyen.Text))
                sb.Append(" AND LevelInterview like '%" + txtSoVongTuyen.Text + "%'");
            //sb.Append(";");
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sb.ToString(), cnn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dgvJobVancany.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
       

        private void dgvJobVancany_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            e.Cancel = true;
            e.Row.Visible = false;
            //((JobVancany)e.Row.DataBoundItem).isDeleted = true;
        }

        
    }
}
