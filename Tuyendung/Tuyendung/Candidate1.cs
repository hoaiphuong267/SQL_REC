using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuyendung
{
    public partial class Candidate1 : Form
    {
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
    }
}
