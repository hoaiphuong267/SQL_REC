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
    public partial class FilterCandidate : Form
    {
       // SqlConnection cnn = new SqlConnection(@"Data Source = CHAOS-LORD\CHAOS;Initial Catalog=QLTD;Integrated Security=True");
        
        SqlConnection cnn = new SqlConnection(@"Data Source = .\SQLExpress;Initial Catalog=QLTD;Integrated Security=True");
        public FilterCandidate()
        {
            InitializeComponent();
        }

        private void btFilterCandidate_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvDSChoPV.Rows)
            {
                DataGridViewCheckBoxCell chk = row.Cells[0] as DataGridViewCheckBoxCell;

                if (chk.Selected == true)
                {

                    SqlDataAdapter da = new SqlDataAdapter("select CandidateName,CodeCandidate,DateBirthday,Gender,Phone,Email,CandidateHistory,Status,JobVancanyID from Candidate where Status ='P' ", cnn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvDSDat.DataSource = dt;
                }
                //MessageBox.Show("this cell checked");

            }
        }

        private void FilterCandidate_Load(object sender, EventArgs e)
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
                cb_Text.DisplayMember = "JobVancanyName";
                cb_Text.ValueMember = "JobVancanyID";
                cb_Text.DataSource = dt;
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void bTSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (cb_Text.Text != null)
                {
                    ketnoicsdl1();
                }
                else
                    ketnoicsdl();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ketnoicsdl()
        {
            cnn.Open();
            string sql = "select CandidateName,CodeCandidate,DateBirthday,Gender,Phone,Email,CandidateHistory,Status,JobVancanyID from Candidate where isdelete = '0' and Status ='E_NEW'";
            SqlCommand com = new SqlCommand(sql, cnn);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            dgvDSChoPV.DataSource = dt;
        }
        private void ketnoicsdl1()
        {
            try
            {
                cnn.Open();
                string sql = "select cc.CandidateName,cc.CodeCandidate,cc.DateBirthday,cc.Gender,cc.Phone,cc.Email,cc.CandidateHistory,cc.Status,jv.JobVancanyName from Candidate cc ,JobVancany jv where cc.JobVancanyID = jv.JobVancanyID and cc.isdelete = '0' and cc.Status ='E_NEW' and (jv.DateStart <= @ToDate and jv.DateEnd >= @FromDate) and cc.JobVancanyID ='" + Convert.ToInt32(cb_Text.SelectedValue) + "'";
                SqlCommand com = new SqlCommand(sql, cnn);
                com.Parameters.Add(new SqlParameter("@ToDate", Convert.ToDateTime(dtp_ToDate.Text)));
                com.Parameters.Add(new SqlParameter("@FromDate", Convert.ToDateTime(dtp_FromDate.Text)));
                com.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                //cnn.Close();
                dgvDSChoPV.DataSource = dt;
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


        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
