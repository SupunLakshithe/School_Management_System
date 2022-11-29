using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace project01
{
    public partial class student_register : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-LENOVOI5\SQLEXPRESS;Initial Catalog=SkillsInternational;Integrated Security=True");
        public student_register()
        {
            InitializeComponent();
        }
        string gender;

        private void linklbl_exit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            home home = new home();
            home.Show();
        }

        private void student_register_FormClosed(object sender, FormClosedEventArgs e)
        {
 //           home home = new home();
 //           home.Show();

        }

        private void student_register_Load(object sender, EventArgs e)
        {
            PopulateRegNo();
            int regNo = Convert.ToInt32(cmbox_regno.SelectedValue);
            PopulateControl(regNo);
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            string commandstring = @"INSERT INTO[dbo].[Student]
           ([RegNo]
           ,[FirstName]
           ,[LastName]
           ,[DateOfBirth]
           ,[Gender]
           ,[Address]
           ,[Email]
           ,[MobilePhone]
           ,[HomePhone]
           ,[ParentName]
           ,[NIC]
           ,[ContactNumber])
     VALUES
(@RegNo,@FirstName,@LastName,@DateOfBirth,@Gender,@Address,@Email,@MobilePhone,@HomePhone,@ParentName,@NIC,@ContactNumber)";

            SqlCommand cmd = new SqlCommand(commandstring, con);
            cmd.Parameters.AddWithValue("@RegNo", cmbox_regno.Text);
            cmd.Parameters.AddWithValue("@FirstName", txt_firstname.Text);
            cmd.Parameters.AddWithValue("@LastName", txt_secondname.Text);
            cmd.Parameters.AddWithValue("@DateOfBirth", (dateTimePicker1.Text));
            cmd.Parameters.AddWithValue("@Address", txt_address.Text);
            cmd.Parameters.AddWithValue("@Email", txt_email.Text);
            cmd.Parameters.AddWithValue("@MobilePhone", txt_mobilenomber.Text);
            cmd.Parameters.AddWithValue("@HomePhone", txt_homenomber.Text);
            cmd.Parameters.AddWithValue("@ParentName", txt_parentname.Text);
            cmd.Parameters.AddWithValue("@NIC", txt_parentnic.Text);
            cmd.Parameters.AddWithValue("@ContactNumber", txt_parentnomber.Text);


            if (rdbtn_male.Checked == true)
            {
                gender = "Male";
            }
            else if (rdbtn_female.Checked == true)
            {
                gender = "Female";
            }
            cmd.Parameters.AddWithValue("@Gender", gender);




            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Added Successfully", "ADD RECORD", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception )
            {
                MessageBox.Show("Add New Record Faild", "Register Student", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                con.Close();
                clear();
            }


        }

        private void txt_secondname_TextChanged(object sender, EventArgs e)
        {

        }

        public void clear()
        {
            PopulateRegNo();
            cmbox_regno.Text = "";
            txt_firstname.Clear();
            txt_secondname.Clear();
            dateTimePicker1.ResetText(); 
            rdbtn_male.Checked = false;
            rdbtn_female.Checked = false;
            txt_address.Clear();
            txt_email.Clear();
            txt_mobilenomber.Clear();
            txt_homenomber.Clear();
            txt_parentname.Clear();
            txt_parentnic.Clear();
            txt_parentnomber.Clear();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void PopulateRegNo()
        {
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter("select regno from Student", con);
                adapter.Fill(dt);
                con.Close();
                cmbox_regno.DataSource = dt;
                cmbox_regno.DisplayMember = "regNo";
                cmbox_regno.ValueMember =  "regNo";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ComboBox Error \n {ex}");
            }
            finally
            {
                con.Close();
            }

        }

        private void PopulateControl(int regNo)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * From student where regNo=@regNo", con);
                cmd.Parameters.AddWithValue("@regNo", regNo);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            } catch (Exception error)
            {
                MessageBox.Show($"Fail to popualte controls \n Error is :- \n {error}");
            }
            finally
            {
                con.Close();
            }


            txt_firstname.Text = dt.Rows[0]["FirstName"].ToString();
            txt_secondname.Text = dt.Rows[0]["LastName"].ToString();
            txt_email.Text = dt.Rows[0]["Email"].ToString();
            txt_address.Text = dt.Rows[0]["Address"].ToString();
            txt_mobilenomber.Text = dt.Rows[0]["MobilePhone"].ToString();
            txt_homenomber.Text = dt.Rows[0]["HomePhone"].ToString();
            txt_parentname.Text = dt.Rows[0]["ParentName"].ToString();
            txt_parentnomber.Text = dt.Rows[0]["ContactNumber"].ToString();
            txt_parentnic.Text = dt.Rows[0]["NIC"].ToString();
            dateTimePicker1.Text = dt.Rows[0]["DateOfBirth"].ToString();
            gender = dt.Rows[0]["Gender"].ToString();

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
        }

        private void cmbox_regno_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = cmbox_regno.SelectedValue.ToString();
            int regNo;
            if (int.TryParse(selectedValue, out regNo))
            {
                regNo = Convert.ToInt32(selectedValue);
                PopulateControl(regNo);
            }
            else
            {

            }

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to delete this record..? ", "Delete Student", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                string commandString = @"DELETE FROM [dbo].[Student] WHERE RegNo=@regNo";
                SqlCommand cmd = new SqlCommand(commandString, con);
                cmd.Parameters.AddWithValue("@regNo",cmbox_regno.Text);
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Deteted Successfully", "Delete Student", MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                catch (Exception )
                {

                    MessageBox.Show("Delete Record Failed", "Delete Student", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                    clear();
                }
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string commandstring = @"UPDATE [dbo].[Student]
   SET [FirstName] = @FirstName
      ,[LastName] = @LastName
      ,[DateOfBirth] = @DateOfBirth
      ,[Gender] = @Gender
      ,[Address] = @Address
      ,[Email] = @Email
      ,[MobilePhone] = @MobilePhone
      ,[HomePhone] = @HomePhone
      ,[ParentName] = @ParentName
      ,[NIC] = @NIC
      ,[ContactNumber] = @ContactNumber
      WHERE RegNo = @RegNo";



            SqlCommand cmd = new SqlCommand(commandstring, con);
            cmd.Parameters.AddWithValue("@RegNo", cmbox_regno.Text);
            cmd.Parameters.AddWithValue("@FirstName", txt_firstname.Text);
            cmd.Parameters.AddWithValue("@LastName", txt_secondname.Text);
            cmd.Parameters.AddWithValue("@DateOfBirth", (dateTimePicker1.Text));
            cmd.Parameters.AddWithValue("@Address", txt_address.Text);
            cmd.Parameters.AddWithValue("@Email", txt_email.Text);
            cmd.Parameters.AddWithValue("@MobilePhone", txt_mobilenomber.Text);
            cmd.Parameters.AddWithValue("@HomePhone", txt_homenomber.Text);
            cmd.Parameters.AddWithValue("@ParentName", txt_parentname.Text);
            cmd.Parameters.AddWithValue("@NIC", txt_parentnic.Text);
            cmd.Parameters.AddWithValue("@ContactNumber", txt_parentnomber.Text);

            if (rdbtn_male.Checked == true)
            {
                gender = "Male";
            }
            else if (rdbtn_female.Checked == true)
            {
                gender = "Female";
            }
            cmd.Parameters.AddWithValue("@Gender", gender);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Update Successfully", "Register Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception )
            {
                MessageBox.Show("Update Record Failed", "Register Student", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
                clear();
            }

            

        }

        private void linklbl_logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure, Do you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                frm_login frm_Login = new frm_login();
                frm_Login.Show();
            }
        }
    }    
}
