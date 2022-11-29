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
    public partial class clubform : Form
    {
        public clubform()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=LAPTOP-LENOVOI5\SQLEXPRESS;Initial Catalog=SkillsInternational;Integrated Security=True");
        string game, cook, photo, astro, foreignlan, chess;

        private void btn_register_Click_1(object sender, EventArgs e)
        {
            
            string cmdstring = @"INSERT INTO [dbo].[Club]
           ([Regno]
           ,[Videogame]
           ,[Cooking]
           ,[Photography]
           ,[AStronomy]
           ,[Foreignlanguage]
           ,[Chess])
     VALUES
(@Regno,@Videogame,@Cooking,@Photography,@AStronomy,@Foreignlanguage,@Chess)";

            SqlCommand Command = new SqlCommand(cmdstring, sqlConnection);

            Command.Parameters.AddWithValue("@Regno", cmbox_regno.Text);
            if (chbox_gaming.Checked == true)
            {
                game = "1";
            }
            else
            {
                game = "0";
            }
            Command.Parameters.AddWithValue("@Videogame", game);
            if (chbox_cooking.Checked == true)
            {
                cook = "1";                
            }
            else
            {
                cook = "0";
            }
            Command.Parameters.AddWithValue("@Cooking", cook);
            if (chbox_photography.Checked == true)
            {
                photo = "1";                
            }
            else
            {
                photo = "0";    
            }
            Command.Parameters.AddWithValue("@Photography", photo);
            if (chbox_astro.Checked == true)
            {
                astro = "1";                
            }
            else
            {
                astro = "0";
            }
            Command.Parameters.AddWithValue("@AStronomy", astro);
            if (chbox_frlanguage.Checked == true)
            {
                foreignlan = "1";               
            }
            else
            {
                foreignlan = "0";
            }
            Command.Parameters.AddWithValue("@Foreignlanguage", foreignlan);
            if (chbox_chess.Checked == true)
            {
                chess = "1";                
            }
            else
            {
                chess = "0";
            }
            Command.Parameters.AddWithValue("@Chess", chess);

            try
            {
                sqlConnection.Open();
                Command.ExecuteNonQuery();
                MessageBox.Show("Record Added Successfully","Add Record",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                MessageBox.Show("Add New Record Failed", "Club Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlConnection.Close();
                btn_clear_Click(sender, e);

            }

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string commandstring = @"UPDATE [dbo].[Club]
   SET [Videogame] = @Videogame
      ,[Cooking] = @Cooking
      ,[Photography] = @Photography
      ,[AStronomy] = @AStronomy
      ,[Foreignlanguage] = @Foreignlanguage
      ,[Chess] = @Chess
 WHERE Regno=@regno";
            
            SqlCommand cmd = new SqlCommand(commandstring,sqlConnection);
            cmd.Parameters.AddWithValue("@regno", cmbox_regno.SelectedValue);
            if (chbox_gaming.Checked == true)
            {
                game = "1";
            }
            else
            {
                game = "0";
            }
            cmd.Parameters.AddWithValue("@Videogame", game);
            
            if (chbox_cooking.Checked == true)
            {
                cook = "1";
            }
            else
            {
                cook = "0";
            }
            cmd.Parameters.AddWithValue("@Cooking", cook);
            
            if (chbox_photography.Checked == true)
            {
                photo = "1";
            }
            else
            {
                photo = "0";
            }
            cmd.Parameters.AddWithValue("@Photography", photo);
            
            if (chbox_astro.Checked == true)
            {
                astro = "1";
            }
            else
            {
                astro = "0";
            }
            cmd.Parameters.AddWithValue("@AStronomy", astro);
            
            if (chbox_frlanguage.Checked == true)
            {
                foreignlan = "1";
            }
            else
            {
                foreignlan = "0";
            }
            cmd.Parameters.AddWithValue("@Foreignlanguage", foreignlan);
            
            if (chbox_chess.Checked == true)
            {
                chess = "1";
            }
            else
            {
                chess = "0";
            }
            cmd.Parameters.AddWithValue("@chess",chess );
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            try
            {

                MessageBox.Show("Record Updated Successfully","Club Register",MessageBoxButtons.OK ,MessageBoxIcon.Information);
            }catch(Exception error)
            {
                MessageBox.Show($"Update Record Failde \n Error is :- \n {error}", "Club Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlConnection .Close();
                btn_clear_Click(sender, e);
            }
        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            populateregno ();
            cmbox_regno.Text = "";
            chbox_astro.Checked = false ;
            chbox_chess.Checked = false ;
            chbox_cooking.Checked = false;
            chbox_frlanguage.Checked = false ;
            chbox_gaming.Checked = false ;
            chbox_photography.Checked = false ;
        }

        private void clubform_Load(object sender, EventArgs e)
        {
            populateregno();
            int regno = Convert.ToInt32(cmbox_regno.SelectedValue);
            populatacontrol(regno);
        }

        private void cmbox_regno_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectdrvalue = cmbox_regno.SelectedValue.ToString();
            int regno;
            if (int.TryParse(selectdrvalue, out regno))
            {
                regno = Convert.ToInt32(regno);
                populatacontrol(regno);
            }
        
        }

        private void linklbl_exit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            home home = new home();
            home.Show();
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

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this Club record ? ","Delete Club REcord",MessageBoxButtons.YesNo,MessageBoxIcon.Question  );
            if (dialogResult == DialogResult.Yes)
            {
                string cmdstring = @"DELETE FROM [dbo].[Club] WHERE RegNo=@regno";
                SqlCommand sqlCommand = new SqlCommand(cmdstring, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@regno", cmbox_regno.Text);

                try
                {
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Record Deleted Successfully", "Delete Club Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception error)
                {
                    MessageBox.Show($"Record Delete Failed \n Error is \n {error}", " Delete Club Record ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sqlConnection.Close();
                    btn_clear_Click(sender, e);
                }
            }
        }

        private void clubform_FormClosed(object sender, FormClosedEventArgs e)
        {
            home  home  =   new home();
            home.Show();
        }
        private void populateregno()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("select regno from club", sqlConnection);
                sqlConnection.Open();
                dataAdapter.Fill(dt);
                sqlConnection.Close();
                cmbox_regno.DataSource = dt;
                cmbox_regno.DisplayMember = "regno";
                cmbox_regno.ValueMember = "regno";
            }
            catch(Exception error)
            {
                MessageBox.Show ($"combobox error \n Error is :- \n {error}");
            }
            finally{}
        }

        private void populatacontrol(int regno)
        {
            DataTable dataTable = new DataTable();
            try
            {
                SqlCommand command = new SqlCommand("select * From club where regno=@regno", sqlConnection);
                command.Parameters.AddWithValue("@regno", regno);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                sqlConnection.Open();
                adapter.Fill(dataTable);
                sqlConnection.Close();
            }
            catch(Exception error)
            {
                MessageBox.Show($"Fail to populate controls \n Error is :- \n {error } ");
            }
            finally {}

            game = dataTable.Rows[0]["videogame"].ToString();
            cook = dataTable.Rows[0]["cooking"].ToString();
            photo = dataTable.Rows[0]["photography"].ToString();
            astro = dataTable.Rows[0]["astronomy"].ToString();
            foreignlan = dataTable.Rows[0]["Foreignlanguage"].ToString();
            chess = dataTable.Rows[0]["chess"].ToString();
            
            if (game == "1")
            {
                chbox_gaming.Checked = true;
            }
            else
            {
                chbox_gaming.Checked = false;
            }
            if (cook == "1")
            {
                chbox_cooking.Checked=true;
            }
            else
            {
                chbox_cooking.Checked = false;
            }
            if (photo == "1")
            {
                chbox_photography.Checked = true;
            }
            else
            {
                chbox_photography.Checked = false;
            }
            if (astro == "1")
            {
                chbox_astro .Checked = true;
            }
            else
            {
                chbox_astro.Checked = false;
            }
            if (foreignlan == "1")
            {
                chbox_frlanguage .Checked = true;
            }
            else
            {
                chbox_frlanguage.Checked = false;
            }
            if (chess == "1")
            {
                chbox_chess.Checked=true; 
            }
            else
            {
                chbox_chess.Checked = false;
            }
        }
    }
}
