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

    public partial class menu : Form
    {
        public MySqlConnection con;
        public string conectString = "server=localhost; username=root; password=; SslMode=none; database=pms";
        public MySqlCommand cm;
        public MySqlDataReader reader;
        public menu()
        {
            InitializeComponent();

           
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Cpassword cp = new Cpassword();
            cp.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            update up = new update();
            up.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            delete de = new delete();
            de.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
        
                string query = $"insert into sales(ProductID ,ProductName,ProductQue,Discount,ProductDate,ProductPrice,CustomerName,CustomerAdd,C_cellCode,Customercell) values('"+p_id.Text+"','"+item.Text+"','"+Convert.ToInt32(quantity.Text)+"','"+ Convert.ToInt32(discount.Text) + "','"+ DateTime.Now.ToString("dd-MM-yyyy")+ "','"+Convert.ToInt32(price.Text)+"','"+c_name.Text+"','"+ address.Text + "','"+Convert.ToInt32(code.Text)+"','"+ Convert.ToInt32(cell.Text) + "')";
                con = new MySqlConnection(conectString);
                con.Open();
                cm = new MySqlCommand(query, con);
                reader = cm.ExecuteReader();
                MessageBox.Show(" Data saved successfully!");
                p_id.Text = "";
                item.Text = "";
                quantity.Text = "";
                discount.Text = "00";
                price.Text = "";
                c_name.Text = "";
                address.Text = "";
                
                con.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Report rp = new Report();
            rp.Show();
        }

        private void FormClose(object sender, FormClosedEventArgs ex)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to exit application? ","Exit Menu",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if( dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                menu m = new menu();
                m.Show();
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
