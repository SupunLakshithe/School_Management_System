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
    public partial class frm_housefinder : Form
    {
        public frm_housefinder()
        {
            InitializeComponent();
        }

        private void frm_housefinder_Load(object sender, EventArgs e)
        {

        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            int x = int.Parse(cmbox_regno.Text);
            string house;
            if (x % 4 == 0)
            {
                house = "Vijaya";
                pic_house.BackColor = Color.Red;
            } else if (x % 4 == 1)
            {
                house = "Parakrama";
                pic_house.BackColor= Color.Yellow;
            } else if (x % 4 == 3)
            {
                house = "Dutugamunu";
                pic_house.BackColor = Color.Green;
            }
            else
            {
                house = "Abhaya";
                pic_house.BackColor = Color.Pink;
            }
            txt_house.Text = house;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            home home = new home();
            home.Focus();
            this.Close();
        }
    }
}
