using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace LoginForm
{
    public partial class Form1 : Form
    {
        private readonly object sqlconnection;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-BFANKVE\SQLEXPRESS;Initial Catalog=LoginPage;Integrated Security=True");
            string query = "select * from LoginTable where UserName = '" + textBox1.Text.Trim() + "' and Password = '" + textBox2.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query,cn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows.Count == 1)
            {
                Form2 objFormMain = new Form2();
                this.Hide();
                objFormMain.Show();

            }
            else
            {
                MessageBox.Show("check your Details");

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}