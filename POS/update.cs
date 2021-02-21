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
    public partial class update : Form
    {
        public MySqlConnection con;
        public string conectString = "server=localhost; username=root; password=; SslMode=none; database=pms";
        public MySqlCommand cm;
        public MySqlDataReader reader;
        public update()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                con = new MySqlConnection(conectString);
                con.Open();
                string query = $"update sales set ProductId='" + p_id1.Text + "',  ProductName='" + item1.Text + "',  ProductQue='" + Convert.ToInt32(quantity1.Text) + "' ,    Discount='" + Convert.ToInt32(discount1.Text) + "' ,  ProductDate='" + DateTime.Now.ToString("dd-MM-yyyy") + "', ProductPrice='" + Convert.ToInt32(price1.Text) + "', CustomerName='" + c_name1.Text + "', CustomerAdd='" + address1.Text + "', Customercell='" + Convert.ToInt32(cell1.Text) + "', C_cellCode='"+Convert.ToInt32(code1.Text)+"'  where ProductID='" + p_id1.Text + "'";
                cm = new MySqlCommand(query, con);
                reader = cm.ExecuteReader();
                MessageBox.Show("Data successfully updated!","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);

                p_id1.Text = "";
                item1.Text = "";
                quantity1.Text = "";
                discount1.Text = "00";
                price1.Text = "";
                c_name1.Text = "";
                address1.Text = "";
                
                
               }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }
        }
    }
}
