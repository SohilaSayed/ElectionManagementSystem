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
    public partial class Form1 : Form
    {
        string ordb = "Data Source =ORCL; User Id=scott;Password=scott;";
        OracleConnection conn;
        string gender;
        public Form1()
        {
            
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "select candidateId from candidates";
            c.CommandType = CommandType.Text;
            OracleDataReader dr = c.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);
            }
            dr.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into voters values(:candidateId,:voterId , :voterName,:voterFamilyName,:sex)";
            cmd.Parameters.Add("candidateId", comboBox1.SelectedItem.ToString());
            cmd.Parameters.Add("voterId", textBox1.Text);
            cmd.Parameters.Add("voterName",textBox2.Text);
            cmd.Parameters.Add("voterFamilyName",textBox3.Text);
            cmd.Parameters.Add("sex",gender);
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "update candidates set numberOfVoters = numberofvoters + 1 where candidateid = :x";
            c.Parameters.Add("candidateId", comboBox1.SelectedItem.ToString());
            c.ExecuteNonQuery();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Saved");
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
