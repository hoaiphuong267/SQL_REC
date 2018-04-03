using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Tuyendung.General;

namespace Tuyendung
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            bool kayit;
            Employee emp = new Employee();

            emp.EmployeeFirstName = txtFirstName.Text;
            emp.EmployeeLastName = txtLastName.Text;
            emp.EmployeeUsername = txtUsername.Text;
            emp.EmployeePassword = txtPassword.Text;
            if (txtUsername.Text == String.Empty || txtFirstName.Text == String.Empty || txtLastName.Text == String.Empty || txtPassword.Text.Trim() == String.Empty || txtPassword2.Text.Trim() == String.Empty)
            {
                MessageBox.Show("All fields are required!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                kayit = emp.saveEmployee();

                if (kayit == false)
                {
                    MessageBox.Show("Username is used");
                }
                else
                {
                    if (txtPassword.Text.Trim() == txtPassword2.Text.Trim())
                        MessageBox.Show("Registration successful");
                    else
                        MessageBox.Show("Passwords are different");
                }
            }


            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtPassword.Text = "";
            txtPassword2.Text = "";
            txtUsername.Text = "";
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
        }
        private void label4_Click(object sender, EventArgs e)
        {
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
       

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtFirstName.Text, " [^\x20-\xaf]+"))
            {
                txtFirstName.Text = "";
            }
        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtLastName.Text, " [^\x20-\xaf]+"))
            {
                txtLastName.Text = "";
            }
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void bt_BackLogin_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }
    }
}
