
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
            this.candidatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.governorateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voterInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.candidatesInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchByGovernorateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.voterInformationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
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
            this.governorateToolStripMenuItem});
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
            this.votersToolStripMenuItem.Name = "votersToolStripMenuItem";
            this.votersToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.votersToolStripMenuItem.Text = "Voters";
            this.votersToolStripMenuItem.Click += new System.EventHandler(this.votersToolStripMenuItem_Click);
            // 
            // candidatesToolStripMenuItem
            // 
            this.candidatesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.candidatesInformationToolStripMenuItem});
            this.candidatesToolStripMenuItem.Name = "candidatesToolStripMenuItem";
            this.candidatesToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.candidatesToolStripMenuItem.Text = "Candidates";
            // 
            // governorateToolStripMenuItem
            // 
            this.governorateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchByGovernorateToolStripMenuItem});
            this.governorateToolStripMenuItem.Name = "governorateToolStripMenuItem";
            this.governorateToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.governorateToolStripMenuItem.Text = "Governorate";
            // 
            // voterInformationToolStripMenuItem
            // 
            this.voterInformationToolStripMenuItem.Name = "voterInformationToolStripMenuItem";
            this.voterInformationToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.voterInformationToolStripMenuItem.Text = "Enter Information";
            this.voterInformationToolStripMenuItem.Click += new System.EventHandler(this.voterInformationToolStripMenuItem_Click);
            // 
            // candidatesInformationToolStripMenuItem
            // 
            this.candidatesInformationToolStripMenuItem.Name = "candidatesInformationToolStripMenuItem";
            this.candidatesInformationToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.candidatesInformationToolStripMenuItem.Text = "Candidates Information";
            this.candidatesInformationToolStripMenuItem.Click += new System.EventHandler(this.candidatesInformationToolStripMenuItem_Click);
            // 
            // searchByGovernorateToolStripMenuItem
            // 
            this.searchByGovernorateToolStripMenuItem.Name = "searchByGovernorateToolStripMenuItem";
            this.searchByGovernorateToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.searchByGovernorateToolStripMenuItem.Text = "Search by Governorate";
            this.searchByGovernorateToolStripMenuItem.Click += new System.EventHandler(this.searchByGovernorateToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 32);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(726, 429);
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
            // voterInformationToolStripMenuItem1
            // 
            this.voterInformationToolStripMenuItem1.Name = "voterInformationToolStripMenuItem1";
            this.voterInformationToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.voterInformationToolStripMenuItem1.Text = "Voter Information";
            this.voterInformationToolStripMenuItem1.Click += new System.EventHandler(this.voterInformationToolStripMenuItem1_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 458);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
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
        private System.Windows.Forms.ToolStripMenuItem governorateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchByGovernorateToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem voterInformationToolStripMenuItem1;
    }
}