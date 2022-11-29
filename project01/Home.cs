using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project01
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private    void btn_logout_Click(object sender, EventArgs e)
        {
            frm_login  frm_Login = new frm_login();
            DialogResult dialogResult = MessageBox.Show ("Are you sure, Do you want to logout?", "Logout",MessageBoxButtons.YesNo ,MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                frm_Login.Show();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clubform clubform = new clubform();
            this.Close ();
            clubform.Show();
        }

        private void btn_TeachRegister_Click(object sender, EventArgs e)
        {
            teacher_register teacher_Register = new teacher_register();
            this.Close();
            teacher_Register.Show();
        }

        private void btn_StudRegister_Click(object sender, EventArgs e)
        {
            student_register student_Register = new student_register();
            this.Close();
            student_Register.Show();
        }

        private void btn_housefinder_Click(object sender, EventArgs e)
        {
            frm_housefinder frm_housefinder = new frm_housefinder();
            frm_housefinder.Show();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure, Do you really want to Exit...?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        private void home_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm_login login = new frm_login();
            login.Show();
        }

        private void lnklbl_aboutus_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            info info = new info();
            info.Show();
        }

        private void btn_club_Click(object sender, EventArgs e)
        {
            clubform clubform = new clubform();
            this.Close();
            clubform.Show();
        }

        private void home_Load(object sender, EventArgs e)
        {

        }
    }
}
