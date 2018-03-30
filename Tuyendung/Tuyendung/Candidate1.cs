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
        SqlConnection cnn = new SqlConnection(@"Data Source = .\SQLExpress;Initial Catalog=QLTD;Integrated Security=True");
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
        private void ketnoicsdl()
        {
            cnn.Open();
            string sql = "select * from Candidate";
            SqlCommand com = new SqlCommand(sql, cnn);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            dgv_createCandidate.DataSource = dt;
                      
        }

        private void Candidate1_Load(object sender, EventArgs e)
        {
           // ketnoicsdl();

        }
       

    }
}
