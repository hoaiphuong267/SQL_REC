﻿using System;
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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

       

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += 5;
            if (label1.Left >= (this.Width - 50))
            {
                timer1.Enabled = false;
                label1.Left = 0;
                timer1.Enabled = true;
            }
        }

        private void btnHosotrungtuyen_Click(object sender, EventArgs e)
        {

        }

        private void btnJobVancany_Click(object sender, EventArgs e)
        {
            JobVancany frmJobVancacy = new JobVancany();
            frmJobVancacy.TopLevel = false;
            tabJobVancacy.Controls.Add(frmJobVancacy);
            frmJobVancacy.Dock = DockStyle.Fill;
            frmJobVancacy.Show();
        }
    }
}
