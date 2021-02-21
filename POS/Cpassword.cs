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
    public partial class Cpassword : Form
    {
        public MySqlConnection con;
        public string conectString = "server=localhost; username=root; password=; SslMode=none; database=pms;";
        public MySqlCommand cm;
        public MySqlDataReader reader;
        public Cpassword()
        {
            InitializeComponent();
        }

        private void Cpassword_Load(object sender, EventArgs e)
        {

        }

        private void change_Click(object sender, EventArgs e)
        {
            
            string pasword = password1.Text;
            string confirm = confirmPass.Text;
            string usernam = username.Text;
           
            if(pasword=="" || confirm=="")
            {
                MessageBox.Show(" Please provide required information! ","Admin Panel",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if (pasword == confirm)
            {
                try {

                    if(usernam == "")
                    {
                        con = new MySqlConnection(conectString);
                        con.Open();
                        cm = con.CreateCommand();
                        cm.CommandText = "select username from login where ID=1";
                        reader = cm.ExecuteReader();
                        while (reader.Read()) { usernam = reader["username"].ToString(); }
                        con.Close();

                        // exevuting wole query
                        con = new MySqlConnection(conectString);
                        con.Open();
                        string query = $"update login set username='" + usernam + "', password='" + password1.Text + "' where ID=1";
                        cm = new MySqlCommand(query, con);
                        reader = cm.ExecuteReader();
                        MessageBox.Show(" Login updated  successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Hide();
                        con.Close();
                    }
                    else
                    {
                        con = new MySqlConnection(conectString);
                        con.Open();
                        string query = $"update login set username='" + usernam + "', password='" + password1.Text + "' where ID=1";
                        cm = new MySqlCommand(query, con);
                        reader = cm.ExecuteReader();
                        MessageBox.Show(" Login updated  successfully!","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);

                        this.Hide();
                        con.Close();
                    }
                    
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
             }

            else
            {
                MessageBox.Show("Password does not match.Please Re-type password!","Password Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                confirmPass.Clear();

            }

        }
    }
}
