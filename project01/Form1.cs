using System.Data.SqlClient;
using System.Data;
using System.Text;

namespace project01
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
           
        }
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=LAPTOP-LENOVOI5\SQLEXPRESS;Initial Catalog=SkillsInternational;Integrated Security=True");
        string username,password;
       
        
        
        private void btn_login_Click(object sender, EventArgs e)
        {
            username = txt_usename.Text;
            password = CreateMD5 (txt_password.Text);
            DataTable dt = new DataTable();
            SqlCommand command = new SqlCommand("select * From credentials where username=@username", sqlConnection);
            command.Parameters.AddWithValue("@username", username);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            sqlConnection.Open();
            adapter.Fill(dt);
            sqlConnection.Close();
            try
            {
                if (password == dt.Rows[0]["password"].ToString())
                {
                    loginSuccess();
                }
                else
                {
                    throw new Exception();
                }
            }
            catch
            {
                MessageBox.Show("Invalid Login credentials, please check username and Password and try again", "invalid login credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clear();
            }



        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure, Do you really want to Exit...?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }


        }

        private void frm_login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public static string CreateMD5(string s)
        {
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                var encoding = Encoding.ASCII;
                var data = encoding.GetBytes(s);

                Span<byte> hashBytes = stackalloc byte[16];
                md5.TryComputeHash(data, hashBytes, out int written);
                if (written != hashBytes.Length)
                    throw new OverflowException();


                Span<char> stringBuffer = stackalloc char[32];
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    hashBytes[i].TryFormat(stringBuffer.Slice(2 * i), out _, "x2");
                }
                return new string(stringBuffer);
            }
        }
        private void clear()
        {
            txt_usename.Clear();
            txt_password.Clear();
            txt_usename.Focus();
        }

        private void txt_usename_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==13)
            {
                txt_password.Focus(); 
            }
        }

        private void txt_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                btn_login_Click(sender, e); 
            }
        }

        private void loginSuccess()
        {
            home home = new home();
            home.txt_username.Text = txt_usename.Text;
            home.Show();
            this.Hide();
        }
    }
}
