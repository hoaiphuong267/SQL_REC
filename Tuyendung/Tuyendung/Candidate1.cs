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
    public partial class Candidate1 : Form
    {
        // SqlConnection cnn = new SqlConnection(@"Data Source = CHAOS-LORD\CHAOS;Initial Catalog=QLTD;Integrated Security=True");

        SqlConnection cnn = new SqlConnection(@"Data Source = .\SQLExpress;Initial Catalog=QLTD;Integrated Security=True");
        //SqlConnection cnn = new SqlConnection(@"Data Source = .;Initial Catalog=QLTD;Integrated Security=True");
        public Candidate1()
        {
            InitializeComponent();
        }
        private void bt_addCandidate_Click(object sender, EventArgs e)
        {
            
                Create_Candidate cc = new Create_Candidate();
                this.Hide();
                cc.ShowDialog();
                this.Close();
            
           
        }
        private void bt_Filter_Click(object sender, EventArgs e)
        {
            //if (txt_CandidateName1.Text ="" and txt_)
            //{
            //     ketnoicsdl();
            //}


            var sb = new StringBuilder("select CandidateName,CodeCandidate,DateBirthday,Gender,Phone,Email,CandidateHistory,Status,JobVancanyID from Candidate");
            if (!string.IsNullOrEmpty(txt_CandidateName1.Text))
                sb.Append(" AND CandidateName like '%" + txt_CandidateName1.Text + "%'");
            //if (!string.IsNullOrEmpty(dtDateStart.Text))
            //    sb.Append(" AND DateStart like '%" + dtDateStart.Text + "%'");
            ////if (!string.IsNullOrEmpty(dtDateEnd.Text))
            ////    sb.Append(" OR DateEnd like '%" + dtDateEnd.Text+ "%'");
            //if (!string.IsNullOrEmpty(txtSoluong.Text))
            //    sb.Append(" AND Soluong like '%" + txtSoluong.Text + "%'");
            //if (!string.IsNullOrEmpty(txtSoVongTuyen.Text))
            //    sb.Append(" AND LevelInterview like '%" + txtSoVongTuyen.Text + "%'");
            //sb.Append(";");
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sb.ToString(), cnn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dgv_createCandidate.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //load combox vi tri tuyen
        private void Candidate1_Load(object sender, EventArgs e)
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
                cb_JobVancanyID1.DisplayMember = "JobVancanyName";
                cb_JobVancanyID1.ValueMember = "JobVancanyID";
                cb_JobVancanyID1.DataSource = dt;
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        // button danh gia
        private void btDanhGia_Click(object sender, EventArgs e)
        {
            FilterCandidate fc = new FilterCandidate();
            this.Hide();
            fc.ShowDialog();
            this.Close();
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            try
            {
                cnn.Open();
                DialogResult result = MessageBox.Show("Bạn muốn xóa?", "Yes or No", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string ins = "UPDATE Candidate SET isdelete = '1' WHERE CodeCandidate ='" + txt_CandidateName1.Text + "' ";
                    SqlCommand cmd = new SqlCommand(ins, cnn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa Thành Cong");
                    cnn.Close();
                    ketnoicsdl();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // ham load du lieu trên datagriview
        private void ketnoicsdl()
        {
            cnn.Open();
            string sql = "select CandidateName,CodeCandidate,DateBirthday,Gender,Phone,Email,CandidateHistory,Status,JobVancanyID from Candidate where isdelete = '0'";
            SqlCommand com = new SqlCommand(sql, cnn);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            dgv_createCandidate.DataSource = dt;
        }
        private void dgv_createCandidate_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_createCandidate.Rows[e.RowIndex];
                txt_CandidateName1.Text = row.Cells[0].Value.ToString();
                txt_Code1.Text = row.Cells[1].Value.ToString();
                //dt_DateOfBirth1.Value = Convert.ToDateTime(row.Cells[2].Value.ToString());
                cb_Gender1.Text = row.Cells[3].Value.ToString();
                txt_Phone1.Text = row.Cells[4].Value.ToString();
                cb_JobVancanyID1.Text = Convert.ToString(row.Cells[7].Value);
            }
        }
    }
}
