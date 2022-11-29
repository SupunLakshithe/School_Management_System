namespace project01
{
    partial class clubform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(clubform));
            this.game_grpbox = new System.Windows.Forms.GroupBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_register = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chbox_astro = new System.Windows.Forms.CheckBox();
            this.chbox_cooking = new System.Windows.Forms.CheckBox();
            this.cmbox_regno = new System.Windows.Forms.ComboBox();
            this.chbox_frlanguage = new System.Windows.Forms.CheckBox();
            this.chbox_gaming = new System.Windows.Forms.CheckBox();
            this.chbox_chess = new System.Windows.Forms.CheckBox();
            this.chbox_photography = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.linklbl_exit = new System.Windows.Forms.LinkLabel();
            this.linklbl_logout = new System.Windows.Forms.LinkLabel();
            this.game_grpbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // game_grpbox
            // 
            this.game_grpbox.Controls.Add(this.btn_clear);
            this.game_grpbox.Controls.Add(this.btn_delete);
            this.game_grpbox.Controls.Add(this.btn_register);
            this.game_grpbox.Controls.Add(this.btn_update);
            this.game_grpbox.Controls.Add(this.label1);
            this.game_grpbox.Controls.Add(this.chbox_astro);
            this.game_grpbox.Controls.Add(this.chbox_cooking);
            this.game_grpbox.Controls.Add(this.cmbox_regno);
            this.game_grpbox.Controls.Add(this.chbox_frlanguage);
            this.game_grpbox.Controls.Add(this.chbox_gaming);
            this.game_grpbox.Controls.Add(this.chbox_chess);
            this.game_grpbox.Controls.Add(this.chbox_photography);
            this.game_grpbox.Location = new System.Drawing.Point(12, 58);
            this.game_grpbox.Name = "game_grpbox";
            this.game_grpbox.Size = new System.Drawing.Size(319, 271);
            this.game_grpbox.TabIndex = 0;
            this.game_grpbox.TabStop = false;
            this.game_grpbox.Text = "Scool Clubs";
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(189, 242);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(54, 23);
            this.btn_clear.TabIndex = 9;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(249, 242);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(64, 23);
            this.btn_delete.TabIndex = 8;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_register
            // 
            this.btn_register.Location = new System.Drawing.Point(6, 242);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(62, 23);
            this.btn_register.TabIndex = 7;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click_1);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(74, 242);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(65, 23);
            this.btn_update.TabIndex = 6;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reg No.";
            // 
            // chbox_astro
            // 
            this.chbox_astro.AutoSize = true;
            this.chbox_astro.Location = new System.Drawing.Point(189, 146);
            this.chbox_astro.Name = "chbox_astro";
            this.chbox_astro.Size = new System.Drawing.Size(116, 19);
            this.chbox_astro.TabIndex = 5;
            this.chbox_astro.Text = "Astronomy Club ";
            this.chbox_astro.UseVisualStyleBackColor = true;
            // 
            // chbox_cooking
            // 
            this.chbox_cooking.AutoSize = true;
            this.chbox_cooking.Location = new System.Drawing.Point(189, 110);
            this.chbox_cooking.Name = "chbox_cooking";
            this.chbox_cooking.Size = new System.Drawing.Size(99, 19);
            this.chbox_cooking.TabIndex = 4;
            this.chbox_cooking.Text = "Cooking Club";
            this.chbox_cooking.UseVisualStyleBackColor = true;
            // 
            // cmbox_regno
            // 
            this.cmbox_regno.FormattingEnabled = true;
            this.cmbox_regno.Location = new System.Drawing.Point(134, 46);
            this.cmbox_regno.Name = "cmbox_regno";
            this.cmbox_regno.Size = new System.Drawing.Size(121, 23);
            this.cmbox_regno.TabIndex = 0;
            this.cmbox_regno.SelectedIndexChanged += new System.EventHandler(this.cmbox_regno_SelectedIndexChanged);
            // 
            // chbox_frlanguage
            // 
            this.chbox_frlanguage.AutoSize = true;
            this.chbox_frlanguage.Location = new System.Drawing.Point(16, 182);
            this.chbox_frlanguage.Name = "chbox_frlanguage";
            this.chbox_frlanguage.Size = new System.Drawing.Size(149, 19);
            this.chbox_frlanguage.TabIndex = 3;
            this.chbox_frlanguage.Text = "Foreign Language Club";
            this.chbox_frlanguage.UseVisualStyleBackColor = true;
            // 
            // chbox_gaming
            // 
            this.chbox_gaming.AutoSize = true;
            this.chbox_gaming.Location = new System.Drawing.Point(16, 110);
            this.chbox_gaming.Name = "chbox_gaming";
            this.chbox_gaming.Size = new System.Drawing.Size(118, 19);
            this.chbox_gaming.TabIndex = 2;
            this.chbox_gaming.Text = "Video Game Club";
            this.chbox_gaming.UseVisualStyleBackColor = true;
            // 
            // chbox_chess
            // 
            this.chbox_chess.AutoSize = true;
            this.chbox_chess.Location = new System.Drawing.Point(189, 182);
            this.chbox_chess.Name = "chbox_chess";
            this.chbox_chess.Size = new System.Drawing.Size(85, 19);
            this.chbox_chess.TabIndex = 1;
            this.chbox_chess.Text = "Chess Club";
            this.chbox_chess.UseVisualStyleBackColor = true;
            // 
            // chbox_photography
            // 
            this.chbox_photography.AutoSize = true;
            this.chbox_photography.Location = new System.Drawing.Point(16, 146);
            this.chbox_photography.Name = "chbox_photography";
            this.chbox_photography.Size = new System.Drawing.Size(123, 19);
            this.chbox_photography.TabIndex = 0;
            this.chbox_photography.Text = "Photography Club";
            this.chbox_photography.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(64, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Skills International";
            // 
            // linklbl_exit
            // 
            this.linklbl_exit.AutoSize = true;
            this.linklbl_exit.Location = new System.Drawing.Point(305, 332);
            this.linklbl_exit.Name = "linklbl_exit";
            this.linklbl_exit.Size = new System.Drawing.Size(26, 15);
            this.linklbl_exit.TabIndex = 8;
            this.linklbl_exit.TabStop = true;
            this.linklbl_exit.Text = "Exit";
            this.linklbl_exit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_exit_LinkClicked);
            // 
            // linklbl_logout
            // 
            this.linklbl_logout.AutoSize = true;
            this.linklbl_logout.Location = new System.Drawing.Point(12, 9);
            this.linklbl_logout.Name = "linklbl_logout";
            this.linklbl_logout.Size = new System.Drawing.Size(45, 15);
            this.linklbl_logout.TabIndex = 9;
            this.linklbl_logout.TabStop = true;
            this.linklbl_logout.Text = "Logout";
            this.linklbl_logout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_logout_LinkClicked_1);
            // 
            // clubform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 351);
            this.ControlBox = false;
            this.Controls.Add(this.linklbl_logout);
            this.Controls.Add(this.linklbl_exit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.game_grpbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "clubform";
            this.Text = "Club registration - Skills International";
            this.Load += new System.EventHandler(this.clubform_Load);
            this.game_grpbox.ResumeLayout(false);
            this.game_grpbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox game_grpbox;
        private Button btn_register;
        private Button btn_update;
        private Label label1;
        private CheckBox chbox_astro;
        private CheckBox chbox_cooking;
        private ComboBox cmbox_regno;
        private CheckBox chbox_frlanguage;
        private CheckBox chbox_gaming;
        private CheckBox chbox_chess;
        private CheckBox chbox_photography;
        private Label label2;
        private LinkLabel linklbl_exit;
        private Button btn_clear;
        private Button btn_delete;
        private LinkLabel linklbl_logout;
    }
}