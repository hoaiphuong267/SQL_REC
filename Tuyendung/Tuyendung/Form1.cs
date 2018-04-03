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
    public partial class Form1 : Form
    {
        SqlConnection cnn = new SqlConnection(@"Data Source = .;Initial Catalog=QLTD;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void Form1_Load(object sender, EventArgs e)
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
            dgv_Filter.DataSource = dt;
        }
        private void ketnoicsdl1()
        {
            try
            {
                //cnn.Open();
                ////string sql = "select CandidateName,CodeCandidate,DateBirthday,Gender,Phone,Email,CandidateHistory,Status,JobVancanyID from Candidate where isdelete = '0' and Status ='E_NEW' and JobVancanyID ='" + Convert.ToInt32(cb_Text.SelectedValue) + "'";
                ////string sql = "select cc.CandidateName,cc.CodeCandidate,cc.DateBirthday,cc.Gender,cc.Phone,cc.Email,cc.CandidateHistory,cc.Status,jv.JobVancanyName from Candidate cc ,JobVancany jv where cc.JobVancanyID = jv.JobVancanyID and cc.isdelete = '0' and cc.Status ='E_NEW' and jv.DateStart <= @ToDate and jv.DateEnd >= @FromDate and cc.JobVancanyID ='" + Convert.ToInt32(cb_Text.SelectedValue) + "'";
                //string sql = "select * from Candidate cc ,JobVancany jv where cc.JobVancanyID = jv.JobVancanyID and cc.isdelete = '0' and jv.DateStart <= @ToDate and jv.DateEnd >= @FromDate ";
                //SqlCommand com = new SqlCommand(sql, cnn);
                //com.Parameters.Add("@ToDate", dtp_ToDate.Value);
                //com.Parameters.Add("@FromDate", dtp_FromDate);
                ////com.Parameters.Add("@ToDate", SqlDbType.DateTime).Value = dtp_ToDate;
                ////com.Parameters.Add("@FromDate", SqlDbType.DateTime).Value = dtp_FromDate;
                //com.CommandType = CommandType.Text;
                //SqlDataAdapter da = new SqlDataAdapter(com);
                //DataTable dt = new DataTable();
                //da.Fill(dt);
                //cnn.Close();
                //dgv_Filter.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
    }
}
