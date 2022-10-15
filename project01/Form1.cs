namespace project01
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }
       
        private void btn_login_Click(object sender, EventArgs e)
        {
            home home = new home();
            home.txt_username.Text = txt_usename.Text;
            home.Show();
            this.Hide();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_usename.Clear();
            txt_password.Clear();
            txt_usename.Focus();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure, Do you really want to Exit...?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                System .Windows .Forms.Application.Exit();
            }


        }

        private void frm_login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private   void txt_usename_TextChanged(object sender, EventArgs e)
        {

        }

        private void frm_login_Load(object sender, EventArgs e)
        {

        }

        private void txt_password_Enter(object sender, EventArgs e)
        {

        }
    }
}