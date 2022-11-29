namespace project01
{
    partial class home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            this.lnklbl_aboutus = new System.Windows.Forms.LinkLabel();
            this.btn_logout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_housefinder = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_club = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lnklbl_aboutus
            // 
            resources.ApplyResources(this.lnklbl_aboutus, "lnklbl_aboutus");
            this.lnklbl_aboutus.Name = "lnklbl_aboutus";
            this.lnklbl_aboutus.TabStop = true;
            this.lnklbl_aboutus.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklbl_aboutus_LinkClicked);
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_logout.ForeColor = System.Drawing.Color.Blue;
            resources.ApplyResources(this.btn_logout, "btn_logout");
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::project01.Properties.Resources.WhatsApp_Image_2022_10_10_at_10_15_48_AM__1_;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // btn_housefinder
            // 
            resources.ApplyResources(this.btn_housefinder, "btn_housefinder");
            this.btn_housefinder.ForeColor = System.Drawing.Color.Red;
            this.btn_housefinder.Name = "btn_housefinder";
            this.btn_housefinder.UseVisualStyleBackColor = true;
            this.btn_housefinder.Click += new System.EventHandler(this.btn_housefinder_Click);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Name = "label6";
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.btn_exit, "btn_exit");
            this.btn_exit.ForeColor = System.Drawing.Color.Blue;
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_club
            // 
            resources.ApplyResources(this.btn_club, "btn_club");
            this.btn_club.ForeColor = System.Drawing.Color.Red;
            this.btn_club.Name = "btn_club";
            this.btn_club.UseVisualStyleBackColor = true;
            this.btn_club.Click += new System.EventHandler(this.btn_club_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Name = "label4";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Name = "label3";
            // 
            // txt_username
            // 
            resources.ApplyResources(this.txt_username, "txt_username");
            this.txt_username.ForeColor = System.Drawing.Color.IndianRed;
            this.txt_username.Name = "txt_username";
            this.txt_username.ReadOnly = true;
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_TeachRegister_Click);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btn_StudRegister_Click);
            // 
            // home
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::project01.Properties.Resources.wp1954191_school_wallpapers_done;
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_club);
            this.Controls.Add(this.lnklbl_aboutus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_housefinder);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_exit);
            this.Name = "home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LinkLabel lnklbl_aboutus;
        private Button btn_logout;
        private PictureBox pictureBox1;
        private Button btn_housefinder;
        private Label label6;
        private Button btn_exit;
        private Button btn_club;
        private Label label4;
        private Label label1;
        private Label label2;
        private Label label3;
        public TextBox txt_username;
        private Button button1;
        private Button button2;
    }
}