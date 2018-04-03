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
            //cnn.Open();
            //try
            //{
            //    string strCmd = "select JobVancanyID,JobVancanyName from JobVancany";
            //    SqlCommand cmd = new SqlCommand(strCmd, cnn);
            //    SqlDataReader reader;
            //    reader = cmd.ExecuteReader();
            //    DataTable dt = new DataTable();
            //    dt.Load(reader);
            //    cbJobID.DisplayMember = "JobVancanyName";
            //    cbJobID.ValueMember = "JobVancanyID";
            //    cbJobID.DataSource = dt;
            //    cnn.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void bTSearch_Click(object sender, EventArgs e)
        {

        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            cnn.Open();
            if (cbJobID.Text == "Mã ứng viên")
            {
                SqlDataAdapter da = new SqlDataAdapter("select CandidateName,CodeCandidate,DateBirthday,Gender,Phone,Email,CandidateHistory,Status,JobVancanyID from Candidate where CodeCandidate like '" + txtsearch.Text + "%' ", cnn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvDSChoPV.DataSource = dt;
            }
            else if (cbJobID.Text == " Tên ứng viên")
            {
                SqlDataAdapter da = new SqlDataAdapter("select CandidateName,CodeCandidate,DateBirthday,Gender,Phone,Email,CandidateHistory,Status,JobVancanyID from Candidate where  CandidateName like '" + txtsearch.Text + "%' ", cnn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvDSChoPV.DataSource = dt;
            }
            else if (cbJobID.Text == "Giới Tính")
            {
                SqlDataAdapter da = new SqlDataAdapter("select CandidateName,CodeCandidate,DateBirthday,Gender,Phone,Email,CandidateHistory,Status,JobVancanyID from Candidate where  Gender like '" + txtsearch.Text + "%' ", cnn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvDSChoPV.DataSource = dt;
            }
            else if (cbJobID.Text == "Ngôn Ngữ")
            {
                SqlDataAdapter da = new SqlDataAdapter("select CandidateName,CodeCandidate,DateBirthday,Gender,Phone,Email,CandidateHistory,Status,JobVancanyID from Candidate where  CandidateHistory like '" + txtsearch.Text + "%' ", cnn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvDSChoPV.DataSource = dt;
            }

            else if (cbJobID.Text == "Vị Trí Tuyển dụng")
            {
                SqlDataAdapter da = new SqlDataAdapter("select CandidateName,CodeCandidate,DateBirthday,Gender,Phone,Email,CandidateHistory,Status,JobVancanyID from Candidate where  JobVancanyID like '" + txtsearch.Text + "%' ", cnn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvDSChoPV.DataSource = dt;
            }
            cnn.Close();
        }
    }
}
