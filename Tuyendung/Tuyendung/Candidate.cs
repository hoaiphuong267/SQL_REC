using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace Tuyendung
{
    public partial class Candidate : Form
    {
        public Candidate()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void bt_Image_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "Image file (*.jpg;*jpeg;*.gif;*.bmp;*.png)|*.jpg;*jpeg;*.gì;*.bmp;*.png|"
                    + "jpeg file (*.jpeg,*.jpg)|*.jpeg,*.jpg|"
                    + "gif file (*.gif)|*.gif|"
                    + "bmp file (*.bmp)|*.bmp|"
                    + "png file (*.png)|*.png|"
                    + "All file (*.*)|*.*";
                if(dlg.ShowDialog() == DialogResult.OK)
                {
                    string filechoose = dlg.FileName;
                    pic_1.Image = Image.FromFile(dlg.FileName);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("À", "eRORN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
        }

        private void bt_Filter_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void bt_addCandidate_Click(object sender, EventArgs e)
        {

        }

    }
}
