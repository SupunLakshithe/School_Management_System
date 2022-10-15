using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project01
{
    public partial class clubform : Form
    {
        public clubform()
        {
            InitializeComponent();
        }

        private void clubform_FormClosed(object sender, FormClosedEventArgs e)
        {
            home  home  =   new home();
            home.Show();
        }

        private void linklbl_logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          
        }
    }
}
