using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace SCHOOL_FEE_MANAGEMENT_SYSTEM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        public String conString = "Data Source=DESKTOP-3M2LRPG\\SQLEXPRESS;Initial Catalog=SCHOOL_FEE_MANAGEMENT_SYSTEM;Integrated Security=True";
        private void button2_Click(object sender, EventArgs e)
        {
          SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State==System.Data.ConnectionState.Open)
            {
                String q = "insert into User_Registration(Username,Password,Position)values('"+textBox1.Text.ToString()+"','"+textBox2.Text.ToString()+"','"+textBox3.Text.ToString()+"')";
                SqlCommand cmd = new SqlCommand(q,con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Connection made successfully");
            }
            else
            {
                MessageBox.Show("error");
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
