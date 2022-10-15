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
    public partial class teacher_register : Form
    {
        public teacher_register()
        {
            InitializeComponent();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void group_subjects_Enter(object sender, EventArgs e)
        {

        }

        private void teacher_register_FormClosed(object sender, FormClosedEventArgs e)
        {
            home home = new home();
            home.Show();
        }
    }
}
