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
    public partial class Form6 : Form
    {
        CrystalReport2 CR;
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            CR = new CrystalReport2();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            crystalReportViewer2.ReportSource = CR;
        }
    }
}
