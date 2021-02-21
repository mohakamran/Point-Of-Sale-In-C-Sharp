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
    public partial class delete : Form
    {
        public MySqlConnection con;
        public string conectString = "server=localhost; username=root; password=; SslMode=none; database=pms";
        public MySqlCommand cm;
        public MySqlDataReader reader;
        public delete()
        {
            InitializeComponent();
        }

        private void delete_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = new MySqlConnection(conectString);
            con.Open();
            string product_id = p_id1.Text;
            string product_name = pname.Text;
            string query = $" delete from sales where ProductID='"+product_id+"' and  ProductName='"+product_name+"'";
            cm = new MySqlCommand(query, con);
            reader = cm.ExecuteReader();
            MessageBox.Show(" Product: "+product_name+" deleted successfully! ","Delete Operation",MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.Hide();
        }
    }
}
