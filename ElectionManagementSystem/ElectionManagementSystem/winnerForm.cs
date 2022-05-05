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
    
    public partial class winnerForm : Form
    {
        string ordb = "Data Source =ORCL; User Id=scott;Password=tiger;";
        OracleConnection conn;
        public winnerForm()
        {
            InitializeComponent();
        }

       
        private void winnerForm_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }
        private void button1_Click(object sender, EventArgs e)
        {


            int x;
            OracleCommand cm = new OracleCommand();
            cm.Connection = conn;
            cm.CommandText = "winner";
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.Add("numbers", OracleDbType.Int32, ParameterDirection.Output);
             cm.ExecuteNonQuery();
            x = Convert.ToInt32(cm.Parameters["numbers"].Value.ToString());
            textBox3.Text = x.ToString();
            OracleCommand smd = new OracleCommand();
            smd.Connection = conn;
            smd.CommandText = "select CONCAT (candidatename , candidatefamilyname )from candidates where numberofvoters = :d ";
            smd.Parameters.Add("id", textBox3.Text);
            OracleDataReader dr = smd.ExecuteReader();
            while (dr.Read()) {
                comboBox1.Items.Add(dr[0]);
               
                
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
