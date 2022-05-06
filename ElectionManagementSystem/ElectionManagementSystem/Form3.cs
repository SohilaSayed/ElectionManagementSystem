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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

       

        

        private void Form3_Load_1(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == "admin" && textBox6.Text == "admin")
            {
                MessageBox.Show(" Login Successful!");
                Form2 f = new Form2();
                f.Show();
                this.Hide();
            }
            else {
                MessageBox.Show("Login Failed!");
                textBox5.Clear();
                textBox6.Clear();
               
                textBox5.Focus();
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true )
            {

                textBox6.UseSystemPasswordChar =false;
            }
            else
            {

                textBox6.UseSystemPasswordChar = true;

            }
        }
    }
}
