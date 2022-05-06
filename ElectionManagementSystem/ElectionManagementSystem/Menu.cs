using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectionManagementSystem
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void votersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void voterInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }

        private void candidatesInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void searchByGovernorateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
        }

        private void voterInformationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void genderToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void winnersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            winnerForm f = new winnerForm();
            f.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
        }
    }
}
