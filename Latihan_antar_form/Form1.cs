using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_antar_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (username.Text == "admin" && passwrd.Text == "admin")
            {
                Formmain formmain = new Formmain();
                formmain.Show();
                this.Hide();
            }
            else 
            {
                MessageBox.Show("Anda salah Menginput Username atau Password00");
            }
        }
    }
}
