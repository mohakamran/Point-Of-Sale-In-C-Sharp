using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace POS
{
    public partial class Report : Form
    {
        public MySqlConnection con;
        public string conectString = "server=localhost; username=root; password=; SslMode=none; database=pms";
        public MySqlCommand cm,cm2,cm3,cm4;
        public MySqlDataReader reader;
        public Report()
        {
            InitializeComponent();
            try {
                con = new MySqlConnection(conectString);
                con.Open();
                string query = "select sum(ProductPrice) as total from sales";
                string query2 = " select count(ProductName) as total2 from sales";
                string query3 = " select sum(Discount) as total3 from sales";
                string query4 = " select sum(ProductQue) as total4 from sales";

                cm = new MySqlCommand(query,con);
                cm.ExecuteNonQuery();

                cm2 = new MySqlCommand(query2, con);
                cm2.ExecuteNonQuery();

                cm3 = new MySqlCommand(query3, con);
                cm3.ExecuteNonQuery();

                cm4 = new MySqlCommand(query4, con);
                cm4.ExecuteNonQuery();

                int total = Convert.ToInt32(cm.ExecuteScalar());

                int total2 = Convert.ToInt32(cm2.ExecuteScalar());


                int total3 = Convert.ToInt32(cm3.ExecuteScalar());

                int total4 = Convert.ToInt32(cm4.ExecuteScalar());

                salesTotal.Text = total.ToString();

                productsTotal.Text = total2.ToString();

                discount.Text = total3.ToString();

                quan.Text = total4.ToString();
                con.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 

            }

        private void Report_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
