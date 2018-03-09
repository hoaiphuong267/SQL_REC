using Tuyendung.General;
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
    public partial class Login : Form
    {
       
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm register = new RegisterForm();
            this.Hide();
            register.ShowDialog();
            this.Close();
        } 
        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserLogin user = UserLogin.getUser();
            if (txtUsername1.Text == "" || txtPassword1.Text == "")
            {
                MessageBox.Show("Please fill in the fields!!!");
            }
            else
            {
                if (user.Login(txtUsername1.Text, txtPassword1.Text) == true)
                {
                    Menu frmUser = new Menu();
                    this.Hide();
                    frmUser.ShowDialog();
                    this.Close();
               
                }
                else
                {
                    MessageBox.Show("User not found!");
                }
            }
        }

        private void txtUsername1_TextChanged(object sender, EventArgs e)
        {
        }

      
    }
}
