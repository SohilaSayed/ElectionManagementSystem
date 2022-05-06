using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;
namespace ElectionManagementSystem
{
    public partial class Form5 : Form
    {
        CrystalReport1 CR;
        public Form5()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            CR = new CrystalReport1();
            foreach (ParameterDiscreteValue i in CR.ParameterFields[0].DefaultValues)
                comboBox1.Items.Add(i.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CR.SetParameterValue(0, comboBox1.Text);
            crystalReportViewer1.ReportSource = CR;
        }
    }
}
