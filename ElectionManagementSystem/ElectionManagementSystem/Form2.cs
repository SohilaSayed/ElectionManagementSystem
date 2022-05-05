using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace ElectionManagementSystem
{
    public partial class Form2 : Form
    {

        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {




        }

        private void button1_Click(object sender, EventArgs e)
        {

            string ordb = "Data source=orcl;User Id=scott;Password=tiger;";

            string cmdstr = "Select candidateId,candidateName,candidateFamilyName,numberOfVoters,governorateName , cityName from candidates s where s.governorateName =:n ";
            adapter = new OracleDataAdapter(cmdstr, ordb);
            adapter.SelectCommand.Parameters.Add("n", textBox1.Text);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];


        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}