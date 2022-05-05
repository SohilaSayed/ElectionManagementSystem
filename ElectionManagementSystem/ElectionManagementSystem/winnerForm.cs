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
            
           
            OracleCommand cm = new OracleCommand();
            cm.Connection = conn;
            cm.CommandText = "Winner";
            cm.CommandType = CommandType.StoredProcedure;
            
           
            cm.ExecuteNonQuery();
        }

    }
}
