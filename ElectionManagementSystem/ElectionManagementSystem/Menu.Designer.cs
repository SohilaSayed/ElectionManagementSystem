
namespace ElectionManagementSystem
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.votersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voterInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voterInformationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.candidatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.candidatesInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genderBiasedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.winnersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.votersToolStripMenuItem,
            this.candidatesToolStripMenuItem,
            this.adminToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(699, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // votersToolStripMenuItem
            // 
            this.votersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voterInformationToolStripMenuItem,
            this.voterInformationToolStripMenuItem1});
            this.votersToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.votersToolStripMenuItem.Name = "votersToolStripMenuItem";
            this.votersToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.votersToolStripMenuItem.Text = "Voters";
            this.votersToolStripMenuItem.Click += new System.EventHandler(this.votersToolStripMenuItem_Click);
            // 
            // voterInformationToolStripMenuItem
            // 
            this.voterInformationToolStripMenuItem.Name = "voterInformationToolStripMenuItem";
            this.voterInformationToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.voterInformationToolStripMenuItem.Text = "Enter Information";
            this.voterInformationToolStripMenuItem.Click += new System.EventHandler(this.voterInformationToolStripMenuItem_Click);
            // 
            // voterInformationToolStripMenuItem1
            // 
            this.voterInformationToolStripMenuItem1.Name = "voterInformationToolStripMenuItem1";
            this.voterInformationToolStripMenuItem1.Size = new System.Drawing.Size(201, 26);
            this.voterInformationToolStripMenuItem1.Text = "Voter Information";
            this.voterInformationToolStripMenuItem1.Click += new System.EventHandler(this.voterInformationToolStripMenuItem1_Click);
            // 
            // candidatesToolStripMenuItem
            // 
            this.candidatesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.candidatesInformationToolStripMenuItem,
            this.genderBiasedToolStripMenuItem,
            this.winnersToolStripMenuItem});
            this.candidatesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.candidatesToolStripMenuItem.Name = "candidatesToolStripMenuItem";
            this.candidatesToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.candidatesToolStripMenuItem.Text = "Candidates";
            // 
            // candidatesInformationToolStripMenuItem
            // 
            this.candidatesInformationToolStripMenuItem.Name = "candidatesInformationToolStripMenuItem";
            this.candidatesInformationToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.candidatesInformationToolStripMenuItem.Text = "Candidates Information";
            this.candidatesInformationToolStripMenuItem.Click += new System.EventHandler(this.candidatesInformationToolStripMenuItem_Click);
            // 
            // genderBiasedToolStripMenuItem
            // 
            this.genderBiasedToolStripMenuItem.Name = "genderBiasedToolStripMenuItem";
            this.genderBiasedToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.genderBiasedToolStripMenuItem.Text = "Category by Governorate";
            this.genderBiasedToolStripMenuItem.Click += new System.EventHandler(this.genderBiasedToolStripMenuItem_Click);
            // 
            // winnersToolStripMenuItem
            // 
            this.winnersToolStripMenuItem.Name = "winnersToolStripMenuItem";
            this.winnersToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.winnersToolStripMenuItem.Text = "Winners";
            this.winnersToolStripMenuItem.Click += new System.EventHandler(this.winnersToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(294, 26);
            this.loginToolStripMenuItem.Text = "Login (Search BY Governorate)";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 31);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(726, 430);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(587, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome to Election Management System";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Salmon;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button2.Location = new System.Drawing.Point(593, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 33);
            this.button2.TabIndex = 32;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 461);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem votersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voterInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem candidatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem candidatesInformationToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem voterInformationToolStripMenuItem1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem genderBiasedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem winnersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
    }
}