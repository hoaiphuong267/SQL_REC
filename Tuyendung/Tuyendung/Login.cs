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
            register.ShowDialog();
        }
      
        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserLogin user = UserLogin.getUser();
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please fill in the fields!!!");
            }
            else
            {
                if (user.Login(txtUsername.Text, txtPassword.Text) == true)
                {
                    Menu frmUser = new Menu();
                    frmUser.ShowDialog();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("User not found!");
                }

            }

        }
    }
}
