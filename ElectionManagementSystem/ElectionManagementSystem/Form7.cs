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
    public partial class Form7 : Form
    {
        string ordb = "Data Source =ORCL; User Id=scott;Password=tiger;";
        OracleConnection conn;
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "select voterId from voters";
            c.CommandType = CommandType.Text;

            OracleDataReader drr = c.ExecuteReader();
            while (drr.Read())
            {
                comboBox2.Items.Add(drr[0]);
            }
            drr.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select candidateId,voterName , voterFamilyName ,sex from voters where voterId =:id";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("id", comboBox2.SelectedItem.ToString());
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox4.Text = dr[0].ToString();
                textBox1.Text = dr[1].ToString();
                textBox2.Text = dr[2].ToString();
                textBox3.Text = dr[3].ToString();
            }

            dr.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand cc = new OracleCommand();
            cc.Connection = conn;
            cc.CommandText = "update voters set voterName=:voterName,voterFamilyName =:voterFamilyName , sex=:sex where voterId =:id";
            cc.Parameters.Add("voterName", textBox1.Text);
            cc.Parameters.Add("voterFamilyName", textBox2.Text);
            cc.Parameters.Add("sex", textBox3.Text);
            cc.Parameters.Add("id", comboBox2.SelectedItem.ToString());
            int r = cc.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("Voter Modified");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
