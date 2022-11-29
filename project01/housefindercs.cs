using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=LAPTOP-LENOVOI5\SQLEXPRESS;Initial Catalog=SkillsInternational;Integrated Security=True");
        
        private void frm_housefinder_Load(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter("select regno from student", sqlConnection);
                adapter.Fill(dt);
                sqlConnection.Close();
                cmbox_regno.DataSource = dt;
                cmbox_regno.DisplayMember = "regNo";
                cmbox_regno.ValueMember = "regNo";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ComboBox Error \n {ex}");
            }
            finally
            {
                sqlConnection.Close();
            }
            string house;
            int x = Convert.ToInt32(cmbox_regno.SelectedValue);
            calculatehome(x);
        }    

        private void btn_find_Click(object sender, EventArgs e)
        {
            int x = int.Parse(cmbox_regno.Text);
            calculatehome(x);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            home home = new home();
            home.Focus();
            this.Close();
        }

        private void cmbox_regno_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = cmbox_regno.SelectedValue.ToString();
            int o;
            if (int.TryParse(selectedValue, out o))
            {
                o = Convert.ToInt32(selectedValue);
                calculatehome(o);
            }
            else
            {

            }
        }
        private void calculatehome(int x)
        {
            string house;
            if (x % 4 == 0)
            {
                house = "Gryffindor";
                pic_house.BackColor = Color.Red;
            }
            else if (x % 4 == 1)
            {
                house = "Hufflepuff";
                pic_house.BackColor = Color.Yellow;
            }
            else if (x % 4 == 3)
            {
                house = "Shlydarin";
                pic_house.BackColor = Color.Green;
            }
            else
            {
                house = "Ravenclaw";
                pic_house.BackColor = Color.Purple ;
            }
            txt_house.Text = house;

        }
    }
}
