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
        SqlConnection cnn = new SqlConnection(@"Data Source = CHAOS-LORD\CHAOS;Initial Catalog=QLTD;Integrated Security=True");
        
        //SqlConnection cnn = new SqlConnection(@"Data Source = .\SQLExpress;Initial Catalog=QLTD;Integrated Security=True");
        public FilterCandidate()
        {
            InitializeComponent();
        }

        private void btFilterCandidate_Click(object sender, EventArgs e)
        {

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
                cbJobID.DisplayMember = "JobVancanyName";
                cbJobID.ValueMember = "JobVancanyID";
                cbJobID.DataSource = dt;
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bTSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
