﻿using System;
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

            kayit = emp.saveEmployee();

            if (kayit == false)
            {
                MessageBox.Show("Username is used");
            }
            else
            {
                if (txtPassword.Text == txtPassword2.Text)
                    MessageBox.Show("Registration successful");
                else
                    MessageBox.Show("Passwords are different");
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
        private void bt_BackLogin_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            frm.Show();
            this.Close();
        }
    }
}
