namespace project01
{
    partial class student_register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(student_register));
            this.linklbl_logout = new System.Windows.Forms.LinkLabel();
            this.linklbl_exit = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.grp_basic = new System.Windows.Forms.GroupBox();
            this.rdbtn_female = new System.Windows.Forms.RadioButton();
            this.rdbtn_male = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txt_secondname = new System.Windows.Forms.TextBox();
            this.txt_firstname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grp_parent = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_parentnomber = new System.Windows.Forms.TextBox();
            this.txt_parentnic = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_parentname = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.grp_contact = new System.Windows.Forms.GroupBox();
            this.txt_homenomber = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_mobilenomber = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_register = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbox_regno = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.grp_basic.SuspendLayout();
            this.grp_parent.SuspendLayout();
            this.grp_contact.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // linklbl_logout
            // 
            this.linklbl_logout.AutoSize = true;
            this.linklbl_logout.Location = new System.Drawing.Point(12, 9);
            this.linklbl_logout.Name = "linklbl_logout";
            this.linklbl_logout.Size = new System.Drawing.Size(45, 15);
            this.linklbl_logout.TabIndex = 0;
            this.linklbl_logout.TabStop = true;
            this.linklbl_logout.Text = "Logout";
            // 
            // linklbl_exit
            // 
            this.linklbl_exit.AutoSize = true;
            this.linklbl_exit.Location = new System.Drawing.Point(511, 747);
            this.linklbl_exit.Name = "linklbl_exit";
            this.linklbl_exit.Size = new System.Drawing.Size(26, 15);
            this.linklbl_exit.TabIndex = 1;
            this.linklbl_exit.TabStop = true;
            this.linklbl_exit.Text = "Exit";
            this.linklbl_exit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_exit_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(168, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Skills International";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // grp_basic
            // 
            this.grp_basic.Controls.Add(this.rdbtn_female);
            this.grp_basic.Controls.Add(this.rdbtn_male);
            this.grp_basic.Controls.Add(this.dateTimePicker1);
            this.grp_basic.Controls.Add(this.txt_secondname);
            this.grp_basic.Controls.Add(this.txt_firstname);
            this.grp_basic.Controls.Add(this.label5);
            this.grp_basic.Controls.Add(this.label4);
            this.grp_basic.Controls.Add(this.label3);
            this.grp_basic.Controls.Add(this.label2);
            this.grp_basic.Location = new System.Drawing.Point(19, 61);
            this.grp_basic.Name = "grp_basic";
            this.grp_basic.Size = new System.Drawing.Size(489, 189);
            this.grp_basic.TabIndex = 3;
            this.grp_basic.TabStop = false;
            this.grp_basic.Text = "Basic Details";
            // 
            // rdbtn_female
            // 
            this.rdbtn_female.AutoSize = true;
            this.rdbtn_female.Location = new System.Drawing.Point(244, 157);
            this.rdbtn_female.Name = "rdbtn_female";
            this.rdbtn_female.Size = new System.Drawing.Size(63, 19);
            this.rdbtn_female.TabIndex = 8;
            this.rdbtn_female.TabStop = true;
            this.rdbtn_female.Text = "Female";
            this.rdbtn_female.UseVisualStyleBackColor = true;
            // 
            // rdbtn_male
            // 
            this.rdbtn_male.AutoSize = true;
            this.rdbtn_male.Location = new System.Drawing.Point(127, 157);
            this.rdbtn_male.Name = "rdbtn_male";
            this.rdbtn_male.Size = new System.Drawing.Size(51, 19);
            this.rdbtn_male.TabIndex = 7;
            this.rdbtn_male.TabStop = true;
            this.rdbtn_male.Text = "Male";
            this.rdbtn_male.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/mm/yyyy";
            this.dateTimePicker1.Location = new System.Drawing.Point(127, 108);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(215, 23);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // txt_secondname
            // 
            this.txt_secondname.Location = new System.Drawing.Point(126, 70);
            this.txt_secondname.Name = "txt_secondname";
            this.txt_secondname.Size = new System.Drawing.Size(341, 23);
            this.txt_secondname.TabIndex = 5;
            // 
            // txt_firstname
            // 
            this.txt_firstname.Location = new System.Drawing.Point(126, 29);
            this.txt_firstname.Name = "txt_firstname";
            this.txt_firstname.Size = new System.Drawing.Size(341, 23);
            this.txt_firstname.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Date Of Birth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "First Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // grp_parent
            // 
            this.grp_parent.Controls.Add(this.label12);
            this.grp_parent.Controls.Add(this.txt_parentnomber);
            this.grp_parent.Controls.Add(this.txt_parentnic);
            this.grp_parent.Controls.Add(this.label11);
            this.grp_parent.Controls.Add(this.txt_parentname);
            this.grp_parent.Controls.Add(this.label10);
            this.grp_parent.Location = new System.Drawing.Point(19, 490);
            this.grp_parent.Name = "grp_parent";
            this.grp_parent.Size = new System.Drawing.Size(489, 166);
            this.grp_parent.TabIndex = 4;
            this.grp_parent.TabStop = false;
            this.grp_parent.Text = "Parent Details";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(28, 121);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 15);
            this.label12.TabIndex = 5;
            this.label12.Text = "Contact Number";
            // 
            // txt_parentnomber
            // 
            this.txt_parentnomber.Location = new System.Drawing.Point(126, 118);
            this.txt_parentnomber.Name = "txt_parentnomber";
            this.txt_parentnomber.Size = new System.Drawing.Size(90, 23);
            this.txt_parentnomber.TabIndex = 4;
            // 
            // txt_parentnic
            // 
            this.txt_parentnic.Location = new System.Drawing.Point(126, 76);
            this.txt_parentnic.Name = "txt_parentnic";
            this.txt_parentnic.Size = new System.Drawing.Size(341, 23);
            this.txt_parentnic.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 15);
            this.label11.TabIndex = 2;
            this.label11.Text = "NIC";
            // 
            // txt_parentname
            // 
            this.txt_parentname.Location = new System.Drawing.Point(126, 35);
            this.txt_parentname.Name = "txt_parentname";
            this.txt_parentname.Size = new System.Drawing.Size(341, 23);
            this.txt_parentname.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "Parent Name";
            // 
            // grp_contact
            // 
            this.grp_contact.Controls.Add(this.txt_homenomber);
            this.grp_contact.Controls.Add(this.label9);
            this.grp_contact.Controls.Add(this.txt_mobilenomber);
            this.grp_contact.Controls.Add(this.txt_email);
            this.grp_contact.Controls.Add(this.txt_address);
            this.grp_contact.Controls.Add(this.label8);
            this.grp_contact.Controls.Add(this.label7);
            this.grp_contact.Controls.Add(this.label6);
            this.grp_contact.Location = new System.Drawing.Point(21, 271);
            this.grp_contact.Name = "grp_contact";
            this.grp_contact.Size = new System.Drawing.Size(489, 192);
            this.grp_contact.TabIndex = 5;
            this.grp_contact.TabStop = false;
            this.grp_contact.Text = "Contact Details";
            // 
            // txt_homenomber
            // 
            this.txt_homenomber.Location = new System.Drawing.Point(377, 147);
            this.txt_homenomber.MaxLength = 10;
            this.txt_homenomber.Name = "txt_homenomber";
            this.txt_homenomber.Size = new System.Drawing.Size(90, 23);
            this.txt_homenomber.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(276, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 15);
            this.label9.TabIndex = 6;
            this.label9.Text = "Home Phone";
            // 
            // txt_mobilenomber
            // 
            this.txt_mobilenomber.Location = new System.Drawing.Point(126, 147);
            this.txt_mobilenomber.MaxLength = 10;
            this.txt_mobilenomber.Name = "txt_mobilenomber";
            this.txt_mobilenomber.Size = new System.Drawing.Size(90, 23);
            this.txt_mobilenomber.TabIndex = 5;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(127, 108);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(342, 23);
            this.txt_email.TabIndex = 4;
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(126, 32);
            this.txt_address.Multiline = true;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(342, 59);
            this.txt_address.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "Mobile Phone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Address";
            // 
            // btn_register
            // 
            this.btn_register.Location = new System.Drawing.Point(21, 671);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(75, 23);
            this.btn_register.TabIndex = 6;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = true;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(102, 671);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 7;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(346, 671);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 8;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(427, 671);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 9;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbox_regno);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.btn_update);
            this.groupBox1.Controls.Add(this.btn_delete);
            this.groupBox1.Controls.Add(this.btn_register);
            this.groupBox1.Controls.Add(this.grp_basic);
            this.groupBox1.Controls.Add(this.btn_clear);
            this.groupBox1.Controls.Add(this.grp_contact);
            this.groupBox1.Controls.Add(this.grp_parent);
            this.groupBox1.Location = new System.Drawing.Point(12, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(525, 700);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Registration";
            // 
            // cmbox_regno
            // 
            this.cmbox_regno.FormattingEnabled = true;
            this.cmbox_regno.Location = new System.Drawing.Point(145, 29);
            this.cmbox_regno.Name = "cmbox_regno";
            this.cmbox_regno.Size = new System.Drawing.Size(121, 23);
            this.cmbox_regno.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(47, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 15);
            this.label13.TabIndex = 10;
            this.label13.Text = "Reg No.";
            // 
            // student_register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 769);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linklbl_exit);
            this.Controls.Add(this.linklbl_logout);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "student_register";
            this.Text = "Student Registration - Skills International";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.student_register_FormClosed);
            this.grp_basic.ResumeLayout(false);
            this.grp_basic.PerformLayout();
            this.grp_parent.ResumeLayout(false);
            this.grp_parent.PerformLayout();
            this.grp_contact.ResumeLayout(false);
            this.grp_contact.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LinkLabel linklbl_logout;
        private LinkLabel linklbl_exit;
        private Label label1;
        private GroupBox grp_basic;
        private DateTimePicker dateTimePicker1;
        private TextBox txt_secondname;
        private TextBox txt_firstname;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private GroupBox grp_parent;
        private GroupBox grp_contact;
        private RadioButton rdbtn_female;
        private RadioButton rdbtn_male;
        private TextBox txt_address;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox txt_homenomber;
        private Label label9;
        private TextBox txt_mobilenomber;
        private TextBox txt_email;
        private Label label12;
        private TextBox txt_parentnomber;
        private TextBox txt_parentnic;
        private Label label11;
        private TextBox txt_parentname;
        private Label label10;
        private Button btn_register;
        private Button btn_update;
        private Button btn_clear;
        private Button btn_delete;
        private GroupBox groupBox1;
        private ComboBox cmbox_regno;
        private Label label13;
    }
}