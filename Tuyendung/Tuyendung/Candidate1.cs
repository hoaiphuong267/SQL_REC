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
            ketnoicsdl();

            //sb = new StringBuilder("select JobVancanyName,DateStart,DateEnd,Soluong,LevelInterview from JobVancany WHERE 1=1");
            //if (!string.IsNullOrEmpty(txtTenVT.Text))
            //    sb.Append(" AND JobVancanyName like '%" + txtTenVT.Text + "%'");
            //if (!string.IsNullOrEmpty(dtDateStart.Text))
            //    sb.Append(" AND DateStart like '%" + dtDateStart.Text + "%'");
            ////if (!string.IsNullOrEmpty(dtDateEnd.Text))
            ////    sb.Append(" OR DateEnd like '%" + dtDateEnd.Text+ "%'");
            //if (!string.IsNullOrEmpty(txtSoluong.Text))
            //    sb.Append(" AND Soluong like '%" + txtSoluong.Text + "%'");
            //if (!string.IsNullOrEmpty(txtSoVongTuyen.Text))
            //    sb.Append(" AND LevelInterview like '%" + txtSoVongTuyen.Text + "%'");
            //sb.Append(";");
            //try
            //{
            //    SqlDataAdapter da = new SqlDataAdapter(sb.ToString(), cnn);
            //    DataSet ds = new DataSet();
            //    da.Fill(ds);
            //    dgvJobVancany.DataSource = ds.Tables[0];
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
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
           
            //txtMVTT.Enabled = false;
            //khong cho nhap 
            //txtMVTT.Text = "ID Autonumber";
            //txtMDKTuyen.Enabled = false;
            //khong cho nhap 
            //txtMDKTuyen.Text = "ID Autonumber";
        }

        private void Candidate1_Load(object sender, EventArgs e)
        {          
        }
       

    }
}
