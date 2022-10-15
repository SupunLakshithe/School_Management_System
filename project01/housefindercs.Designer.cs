namespace project01
{
    partial class frm_housefinder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_housefinder));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbox_regno = new System.Windows.Forms.ComboBox();
            this.btn_find = new System.Windows.Forms.Button();
            this.txt_house = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pic_house = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_house)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reg No.";
            // 
            // cmbox_regno
            // 
            this.cmbox_regno.FormattingEnabled = true;
            this.cmbox_regno.Location = new System.Drawing.Point(97, 12);
            this.cmbox_regno.Name = "cmbox_regno";
            this.cmbox_regno.Size = new System.Drawing.Size(121, 23);
            this.cmbox_regno.TabIndex = 2;
            // 
            // btn_find
            // 
            this.btn_find.ForeColor = System.Drawing.Color.Brown;
            this.btn_find.Location = new System.Drawing.Point(16, 58);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(75, 23);
            this.btn_find.TabIndex = 3;
            this.btn_find.Text = "Find";
            this.btn_find.UseVisualStyleBackColor = true;
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // txt_house
            // 
            this.txt_house.Enabled = false;
            this.txt_house.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_house.Location = new System.Drawing.Point(97, 93);
            this.txt_house.Name = "txt_house";
            this.txt_house.Size = new System.Drawing.Size(121, 29);
            this.txt_house.TabIndex = 4;
            this.txt_house.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Your house is :";
            // 
            // pic_house
            // 
            this.pic_house.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pic_house.Enabled = false;
            this.pic_house.Location = new System.Drawing.Point(129, 50);
            this.pic_house.Name = "pic_house";
            this.pic_house.Size = new System.Drawing.Size(76, 31);
            this.pic_house.TabIndex = 6;
            this.pic_house.TabStop = false;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(77, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_housefinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 154);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pic_house);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_house);
            this.Controls.Add(this.btn_find);
            this.Controls.Add(this.cmbox_regno);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_housefinder";
            this.Text = "House Finder";
            this.Load += new System.EventHandler(this.frm_housefinder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_house)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox cmbox_regno;
        private Button btn_find;
        private TextBox txt_house;
        private Label label2;
        private PictureBox pic_house;
        private Button button1;
    }
}