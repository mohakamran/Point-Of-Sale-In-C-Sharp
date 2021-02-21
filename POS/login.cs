using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace POS
{
    public partial class login : Form
    {

        int count;
         
        public login()
        {
            InitializeComponent();
            count = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string user, pass;
            user = username1.Text;
            pass = password1.Text;
            count++;
            if (count>=3)
            {
                MessageBox.Show(" You have tried 3 times. Now POS is blocked!","Blocked State",MessageBoxButtons.OK,MessageBoxIcon.Error);
                Application.Exit();
            }
            else if (user =="" || pass=="")
            {
                MessageBox.Show(" username or password box is empty!","Empty value",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else {
                MySqlConnection con;
                string conectString = "server=localhost; username=root; password=; SslMode=none; database=pms";
                MySqlCommand cm;
                MySqlDataReader reader;
                try {
                    con = new MySqlConnection(conectString);
                    con.Open();

                    cm = con.CreateCommand();
                    cm.CommandText = $"select * from login where username='{user}' and password='{pass}'";
                    reader = cm.ExecuteReader();
                    if (reader.HasRows)
                    {
                        this.Hide();
                        menu m = new menu();
                        m.Show();
                        con.Close();

                    }
                    else
                    {
                        MessageBox.Show(" username or password is incorrect.Please Try again!","Wrong",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
           
            
        }

       

        private void Katam(object sender, FormClosedEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to exit application? ", "Exit Login", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if(dialog == DialogResult.No) 
            {
                
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
