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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lnklbl_aboutus = new System.Windows.Forms.LinkLabel();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.btn_logout = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_housefinder = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_club = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_TeachRegister = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_StudRegister = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lnklbl_aboutus);
            this.splitContainer1.Panel1.Controls.Add(this.txt_username);
            this.splitContainer1.Panel1.Controls.Add(this.btn_logout);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btn_housefinder);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.btn_exit);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(580, 324);
            this.splitContainer1.SplitterDistance = 218;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // lnklbl_aboutus
            // 
            this.lnklbl_aboutus.AutoSize = true;
            this.lnklbl_aboutus.Location = new System.Drawing.Point(60, 300);
            this.lnklbl_aboutus.Name = "lnklbl_aboutus";
            this.lnklbl_aboutus.Size = new System.Drawing.Size(99, 15);
            this.lnklbl_aboutus.TabIndex = 6;
            this.lnklbl_aboutus.TabStop = true;
            this.lnklbl_aboutus.Text = "about devolopers";
            // 
            // txt_username
            // 
            this.txt_username.Enabled = false;
            this.txt_username.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_username.Location = new System.Drawing.Point(38, 210);
            this.txt_username.Name = "txt_username";
            this.txt_username.ReadOnly = true;
            this.txt_username.Size = new System.Drawing.Size(140, 29);
            this.txt_username.TabIndex = 5;
            this.txt_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_username.TextChanged += new System.EventHandler(this.txt_username_TextChanged);
            // 
            // btn_logout
            // 
            this.btn_logout.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_logout.Location = new System.Drawing.Point(74, 245);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(75, 23);
            this.btn_logout.TabIndex = 4;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(50, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 36);
            this.label5.TabIndex = 2;
            this.label5.Text = "Welcome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 74);
            this.label3.TabIndex = 1;
            this.label3.Text = "       Skills\r\nInternational";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::project01.Properties.Resources.WhatsApp_Image_2022_10_10_at_10_15_48_AM__1_;
            this.pictureBox1.Location = new System.Drawing.Point(50, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_housefinder
            // 
            this.btn_housefinder.Location = new System.Drawing.Point(218, 249);
            this.btn_housefinder.Name = "btn_housefinder";
            this.btn_housefinder.Size = new System.Drawing.Size(75, 23);
            this.btn_housefinder.TabIndex = 7;
            this.btn_housefinder.Text = "Run";
            this.btn_housefinder.UseVisualStyleBackColor = true;
            this.btn_housefinder.Click += new System.EventHandler(this.btn_housefinder_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(117, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "House Finder";
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(275, 289);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 5;
            this.btn_exit.Text = "EXIT";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_club);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(60, 148);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(249, 81);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Club Register";
            // 
            // btn_club
            // 
            this.btn_club.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_club.Location = new System.Drawing.Point(154, 32);
            this.btn_club.Name = "btn_club";
            this.btn_club.Size = new System.Drawing.Size(79, 30);
            this.btn_club.TabIndex = 1;
            this.btn_club.Text = "GO";
            this.btn_club.UseVisualStyleBackColor = true;
            this.btn_club.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 30);
            this.label4.TabIndex = 0;
            this.label4.Text = "Register  Students to \r\nSchool Clubs";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Location = new System.Drawing.Point(60, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 105);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "School Register";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(6, 22);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(237, 75);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btn_TeachRegister);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(229, 44);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Teacher";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "View,Register or Update\r\ndetails about Teachers\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_TeachRegister
            // 
            this.btn_TeachRegister.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_TeachRegister.ForeColor = System.Drawing.Color.Red;
            this.btn_TeachRegister.Location = new System.Drawing.Point(144, 6);
            this.btn_TeachRegister.Name = "btn_TeachRegister";
            this.btn_TeachRegister.Size = new System.Drawing.Size(79, 30);
            this.btn_TeachRegister.TabIndex = 0;
            this.btn_TeachRegister.Text = "GO";
            this.btn_TeachRegister.UseVisualStyleBackColor = true;
            this.btn_TeachRegister.Click += new System.EventHandler(this.btn_TeachRegister_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.btn_StudRegister);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(229, 44);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Student";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "View,Register or Update\r\ndetails about Students";
            // 
            // btn_StudRegister
            // 
            this.btn_StudRegister.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_StudRegister.ForeColor = System.Drawing.Color.Blue;
            this.btn_StudRegister.Location = new System.Drawing.Point(144, 7);
            this.btn_StudRegister.Name = "btn_StudRegister";
            this.btn_StudRegister.Size = new System.Drawing.Size(79, 30);
            this.btn_StudRegister.TabIndex = 2;
            this.btn_StudRegister.Text = "GO";
            this.btn_StudRegister.UseVisualStyleBackColor = true;
            this.btn_StudRegister.Click += new System.EventHandler(this.btn_StudRegister_Click);
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 324);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home - Skills International";
            this.Load += new System.EventHandler(this.home_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private GroupBox groupBox1;
        private TabControl tabControl1;
        private TabPage tabPage2;
        private TabPage tabPage1;
        private Label label1;
        private Button btn_TeachRegister;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label2;
        private Button btn_StudRegister;
        private GroupBox groupBox2;
        private Button btn_club;
        private Label label4;
        private Label label5;
        private LinkLabel lnklbl_aboutus;
        private Button btn_exit;
        private Button btn_housefinder;
        private Label label6;
        public TextBox txt_username;
        private Button btn_logout;
    }
}