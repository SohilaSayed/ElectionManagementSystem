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
        string ordb = "Data Source =ORCL; User Id=scott;Password=tiger;";
        OracleConnection conn;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //conn = new OracleConnection(ordb);
            //conn.Open();
            //OracleCommand cmd = new OracleCommand();
            //cmd.Connection = conn;
            //cmd.CommandText = "select governorateName from governorate";
            //cmd.CommandType = CommandType.Text;
            //OracleDataReader dr = cmd.ExecuteReader();
            //while (dr.Read())
            //{
            //    comboBox1.Items.Add(dr[0]);
            //}
            //dr.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
