﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interaksi_antar_Form
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            

            if (txtUsername.Text == "admin" && txtPassword.Text == "admin")
            {
                FrmMain frmMain = new FrmMain();
                frmMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
