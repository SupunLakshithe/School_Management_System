using System.Data;
using System.Data.SqlClient;

namespace project01
{
    public partial class teacher_register : Form
    {
        public teacher_register()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=LAPTOP-LENOVOI5\SQLEXPRESS;Initial Catalog=SkillsInternational;Integrated Security=True");

        private void btn_update_Click(object sender, EventArgs e)
        {
            string commandstring = @"UPDATE [dbo].[Teacher]
   SET [Regno] = Regno
      ,[Firstname] = Firstname
      ,[Lastname] = Lastname
      ,[Dateofbirth] = Dateofbirth
      ,[NIC] = NIC
      ,[Gender] = Gender
      ,[Address] = Address
      ,[Email] = Email
      ,[Mobilephone] = Mobilephone
      ,[Homephone] = Homephone
      ,[Section] = Section
      ,[Subject] = Subject
 WHERE regno  = @regno";

            SqlCommand command = new SqlCommand(commandstring, sqlConnection);
            command.Parameters.AddWithValue("@RegNo", cmbox_regno.Text);
            command.Parameters.AddWithValue("@FirstName", txt_firstname.Text);
            command.Parameters.AddWithValue("@LastName", txt_secondname.Text);
            command.Parameters.AddWithValue("@DateOfBirth", (dateTimePicker1.Text));
            command.Parameters.AddWithValue("@NIC", txt_NIC.Text);
            command.Parameters.AddWithValue("@gender", gender);
            command.Parameters.AddWithValue("@Address", txt_address.Text);
            command.Parameters.AddWithValue("@Email", txt_email.Text);
            command.Parameters.AddWithValue("@MobilePhone", txt_mobilenomber.Text);
            command.Parameters.AddWithValue("@HomePhone", txt_homenomber.Text);
            command.Parameters.AddWithValue("@section", section);
            command.Parameters.AddWithValue("@subject", subject);
            if (rdbtn_male.Checked == true)
            {
                gender = "Male";
            }
            else if (rdbtn_female.Checked == true)
            {
                gender = "Female";
            }
            if (chkbx_al.Checked == true && chkbx_ol.Checked == false)
            {
                section = "A";
            }
            else if (chkbx_al.Checked == false && chkbx_ol.Checked == true)
            {
                section = "O";
            }
            else if (chkbx_al.Checked == true && chkbx_ol.Checked == true)
            {
                section = "A&O";
            }
            if (rdbtn_maths.Checked == true)
            {
                subject = "Mathermatics";
            }
            else if (rdbtn_art.Checked == true)
            {
                subject = "Art";
            }
            else if (rdbtn_commerce.Checked == true)
            {
                subject = "Commerce";
            }
            else if (rdbtn_science.Checked == true)
            {
                subject = "Science";
            }
            else if (rdbtn_tech.Checked == true)
            {
                subject = "Tech";
            }
            else if (rdbtn_sport.Checked == true)
            {
                subject = "Sport";
            }
            try
            {
                sqlConnection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully", "Register Teacher", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                MessageBox.Show($"Update Record Failed \n Error is :- \n {error}", "Register Teacher", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlConnection.Close();
                clear();
            }
        }


        private void teacher_register_FormClosed(object sender, FormClosedEventArgs e)
        {
            home home = new home();
            home.Show();
        }
        string gender, section, subject;

        private void btn_register_Click(object sender, EventArgs e)
        {
            string commandstring = @"INSERT INTO[dbo].[Teacher]
           ([Regno]
           ,[Firstname]
           ,[Lastname]
           ,[Dateofbirth]
           ,[NIC]
           ,[Gender]
           ,[Address]
           ,[Email]
           ,[Mobilephone]
           ,[Homephone]
           ,[Section]
           ,[Subject])
     VALUES
(@Regno,@Firstname,@Lastname,@Dateofbirth,@NIC,@Gender,@Address,@Email,@Mobilephone,@Homephone,@Section,@Subject)";

            SqlCommand command = new SqlCommand(commandstring, sqlConnection);

            command.Parameters.AddWithValue("@Regno", cmbox_regno.Text);
            command.Parameters.AddWithValue("@Firstname", txt_firstname.Text);
            command.Parameters.AddWithValue("@Lastname", txt_secondname.Text);
            command.Parameters.AddWithValue("@Dateofbirth", dateTimePicker1.Text);
            command.Parameters.AddWithValue("@NIC", txt_NIC.Text);

            if (rdbtn_female.Checked == true)
            {
                gender = "Femail";
            }
            else if (rdbtn_male.Checked == true)
            {
                gender = "Mail";
            }
            command.Parameters.AddWithValue("@Gender", gender);
            command.Parameters.AddWithValue("@Address", txt_address.Text);
            command.Parameters.AddWithValue("@Email", txt_email.Text);
            command.Parameters.AddWithValue("@Mobilephone", txt_mobilenomber.Text);
            command.Parameters.AddWithValue("@Homephone", txt_homenomber.Text);

            if (chkbx_al.Checked == true && chkbx_ol.Checked == false)
            {
                section = "A";
            }
            else if (chkbx_al.Checked == false && chkbx_ol.Checked == true)
            {
                section = "O";
            }
            else if (chkbx_al.Checked == true && chkbx_ol.Checked == true)
            {
                section = "A&O";
            }

            command.Parameters.AddWithValue("@Section", section);

            if (rdbtn_maths.Checked == true)
            {
                subject = "Mathermatics";
            }
            else if (rdbtn_art.Checked == true)
            {
                subject = "Art";
            }
            else if (rdbtn_commerce.Checked == true)
            {
                subject = "Commerce";
            }
            else if (rdbtn_science.Checked == true)
            {
                subject = "Science";
            }
            else if (rdbtn_tech.Checked == true)
            {
                subject = "Tech";
            }
            else if (rdbtn_sport.Checked == true)
            {
                subject = "Sport";
            }
            command.Parameters.AddWithValue("@Subject", subject);


            try
            {
                sqlConnection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Record Added Successfully", "Add Rercord", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Add New Record Failed", "Register New Teacher", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlConnection.Close();
                clear();

            }
        }

        private void teacher_register_Load(object sender, EventArgs e)
        {
            populateRegNo();
            int regno = Convert.ToInt32(cmbox_regno.SelectedValue);
            populatecontrol(regno);
        }

        private void clear()
        {
            populateRegNo();
            cmbox_regno.Text = "";
            txt_firstname.Clear();
            txt_secondname.Clear();
            dateTimePicker1.Text = "";
            txt_NIC.Clear();
            rdbtn_male.Checked = false;
            rdbtn_female.Checked = false;
            txt_address.Clear();
            txt_email.Clear();
            txt_mobilenomber.Clear();
            txt_homenomber.Clear();
            chkbx_al.Checked = false;
            chkbx_ol.Checked = false;
            rdbtn_art.Checked = false;
            rdbtn_commerce.Checked = false;
            rdbtn_maths.Checked = false;
            rdbtn_science.Checked = false;
            rdbtn_sport.Checked = false;
            rdbtn_tech.Checked = false;

        }

        private void cmbox_regno_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = cmbox_regno.SelectedValue.ToString();
            int regNo;
            if (int.TryParse(selectedValue, out regNo))
            {
                regNo = Convert.ToInt32(selectedValue);
                populatecontrol(regNo);
            }
            else
            {

            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to delete this record..? ", "Delete Teacher", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                string commandString = @"DELETE FROM [dbo].[teacher] WHERE RegNo=@regNo";
                SqlCommand cmd = new SqlCommand(commandString, sqlConnection);
                cmd.Parameters.AddWithValue("@regNo", cmbox_regno.Text);
                try
                {
                    sqlConnection.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Deteted Successfully", "Delete Teacher", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {

                    MessageBox.Show("Delete Record Failed", "Delete Teacher", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sqlConnection.Close();
                    clear();
                }
            }
        }

        private void lnklbl_exit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            home home = new home();
            home.Show();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void linklbl_logout_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure, Do you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                frm_login frm_Login = new frm_login();
                frm_Login.Show();
            }
        }

        private void populateRegNo()
        {
            try
            {
                sqlConnection.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter("select regno from Teacher", sqlConnection);
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
        }
        private void populatecontrol(int regNo)
        {
            DataTable dt = new DataTable();
            try
            {
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("Select * From teacher  where Regno=@regNo", sqlConnection);
                cmd.Parameters.AddWithValue("@regNo", regNo);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception error)
            {
                MessageBox.Show($"Fail to popualte controls \n Error is :- \n {error}");
            }
            finally
            {
                sqlConnection.Close();
            }

            txt_firstname.Text = dt.Rows[0]["FirstName"].ToString();
            txt_secondname.Text = dt.Rows[0]["LastName"].ToString();
            dateTimePicker1.Text = dt.Rows[0]["DateOfBirth"].ToString();
            txt_NIC.Text = dt.Rows[0]["NIC"].ToString();
            gender = dt.Rows[0]["Gender"].ToString();
            txt_address.Text = dt.Rows[0]["Address"].ToString();
            txt_email.Text = dt.Rows[0]["Email"].ToString();
            txt_mobilenomber.Text = dt.Rows[0]["MobilePhone"].ToString();
            txt_homenomber.Text = dt.Rows[0]["HomePhone"].ToString();
            section = dt.Rows[0]["section"].ToString();
            subject = dt.Rows[0]["subject"].ToString();

            if (gender == "Male")
            {
                rdbtn_male.Checked = true;
                rdbtn_female.Checked = false;
            }
            else
            {
                rdbtn_male.Checked = false;
                rdbtn_female.Checked = true;
            }
            if (section == "A")
            {
                chkbx_al.Checked = true;
                chkbx_ol.Checked = false;
            }
            else if (section == "O")
            {
                chkbx_al.Checked = false;
                chkbx_ol.Checked = true;
            }
            else if (section == "A&O")
            {
                chkbx_al.Checked = true;
                chkbx_ol.Checked = true;
            }
            else
            {
                chkbx_al.Checked = false;
                chkbx_ol.Checked = false;
            }
            if (subject == "Mathermatics")
            {
                rdbtn_maths.Checked = true;
            }
            else if (subject == "Art")
            {
                rdbtn_art.Checked = true;
            }
            else if (subject == "Commerce")
            {
                rdbtn_commerce.Checked = true;
            }
            else if (subject == "Science")
            {
                rdbtn_science.Checked = true;
            }
            else if (subject == "Tech")
            {
                rdbtn_tech.Checked = true;
            }
            else if (subject == "Sport")
            {
                rdbtn_sport.Checked = true;
            }
        }
    }
}