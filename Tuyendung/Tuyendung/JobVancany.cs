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
       // SqlConnection cnn = new SqlConnection(@"Data Source = CHAOS-LORD\CHAOS;Initial Catalog=QLTD;Integrated Security=True");
        
        SqlConnection cnn = new SqlConnection(@"Data Source = .\SQLExpress;Initial Catalog=QLTD;Integrated Security=True");
        //SqlConnection cnn = new SqlConnection(@"Data Source = .;Initial Catalog=QLTD;Integrated Security=True");
        //DataTable dt;
        public JobVancany()
        {
            InitializeComponent();
        }
       
        private void ketnoicsdl()
        {
            cnn.Open();
            string sql = "select CodeJobVancany, JobVancanyName,DateStart, DateEnd, Soluong ,LevelInterview ,CandidateHistory,Gender from JobVancany where isdelete = '0'"; 
            SqlCommand com = new SqlCommand(sql, cnn); 
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable(); 
            da.Fill(dt); 
            cnn.Close();  
            dgvJobVancany.DataSource = dt; 
        }

        private void JobVancany_Load(object sender, EventArgs e)
        {
            
            ketnoicsdl();
            

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabNew);
          


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
                cb_Language.Text = row.Cells[6].Value.ToString();
                cbGT.Text = row.Cells[7].Value.ToString();


            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            cnn.Open();
            string ins1 = "UPDATE JobVancany SET  CodeJobVancany='" + txtMVTT.Text + "',DateStart='" + dtDateStart.Value + "', DateEnd='" + dtDateEnd.Value + "',Soluong = '" + txtSoluong.Text + "', LevelInterview='" + txtSoVongTuyen.Text + "', JobVancanyName='" + txtTenVT.Text + "', CandidateHistory ='" + cb_Language.Text + "', Gender='" + cbGT.Text + "' WHERE isdelete = '0'";
            SqlCommand cmd = new SqlCommand(ins1, cnn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Sửa Thành Cong");
            cnn.Close();
            ketnoicsdl();
        }

        private void ClearAllText(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c is TextBox || c is ComboBox)
                {
                    c.Text = "";

                }
                else
                    ClearAllText(c);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            cnn.Open();
            try
            {
                DialogResult result = MessageBox.Show("Bạn muốn xóa?", "Yes or No", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string ins = "UPDATE JobVancany SET isdelete = '1' WHERE CodeJobVancany='" + txtMVTT.Text + "' ";
                    SqlCommand cmd = new SqlCommand(ins, cnn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa Thành Cong");
                    cnn.Close();    
                    ketnoicsdl();
                    ClearAllText(this);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
        
           
        

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            
            try
            {
                cnn.Open();
                var sb = new StringBuilder("select JobVancanyName,DateStart,DateEnd,Soluong,LevelInterview from JobVancany WHERE isdelete = '0'");
                if (!string.IsNullOrEmpty(txtTenVT.Text))
                    sb.Append(" AND JobVancanyName like '%" + txtTenVT.Text + "%'");
                if (!string.IsNullOrEmpty(dtDateStart.Text))
                    sb.Append(" AND DateStart <=" + Convert.ToDateTime(dtDateEnd.Text) + "");
                if (!string.IsNullOrEmpty(dtDateEnd.Text))
                    sb.Append(" AND DateEnd >=" + Convert.ToDateTime(dtDateStart.Text) + "");
                if (!string.IsNullOrEmpty(txtSoluong.Text))
                    sb.Append(" AND Soluong like '%" + txtSoluong.Text + "%'");
                if (!string.IsNullOrEmpty(txtSoVongTuyen.Text))
                    sb.Append(" AND LevelInterview like '%" + txtSoVongTuyen.Text + "%'");
                if (!string.IsNullOrEmpty(cbGT.Text))
                    sb.Append(" AND Gender like '%" + cbGT.Text + "%'");

                SqlDataAdapter da = new SqlDataAdapter(sb.ToString(), cnn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                cnn.Close();
                dgvJobVancany.DataSource = ds.Tables[0];
                ClearAllText(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

          

        }


        private void dgvJobVancany_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
           
        }

        private void btNew_Click(object sender, EventArgs e)
        {
           
            //SqlCommand check_User_Name = new SqlCommand("SELECT * FROM JobVancany WHERE (CodeJobVancany= @CodeJobVancany)", cnn);
            //check_User_Name.Parameters.AddWithValue("@CodeJobVancany", txtCodeJob.Text);
            //int UserExist = (int)check_User_Name.ExecuteScalar();
            //if (UserExist > 0)
            //{
            //    MessageBox.Show("Vi Tri Tuyen da ton tai");

            //}
            //else
            //{
            if (txtCodeJob.Text == String.Empty || dtDateStart.Text == String.Empty || dtDateEnd.Text == String.Empty || txtSL.Text == String.Empty || txtSoVong.Text == String.Empty || txtName.Text == String.Empty || cb_Language1.Text == String.Empty || cbGioiTinh.Text == String.Empty)
            {
                MessageBox.Show("All fields are required!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    cnn.Open();
                    string ins = "INSERT INTO JobVancany(CodeJobVancany,DateStart, DateEnd, Soluong ,LevelInterview , JobVancanyName,CandidateHistory,Gender ) VALUES ('" + txtCodeJob.Text + "','" + dtStart.Value + "','" + dtEnd.Value + "','" + txtSL.Text + "','" + txtSoVong.Text + "','" + txtName.Text + "','" + cb_Language1.Text + "','" + cbGioiTinh.Text + "')";
                    SqlCommand cmd1 = new SqlCommand(ins, cnn);
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Thêm Thành Cong");
                    cnn.Close();
                    ketnoicsdl();
                    ClearAllText(this);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            //}
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabJobVancacy);

        }
    }
}
