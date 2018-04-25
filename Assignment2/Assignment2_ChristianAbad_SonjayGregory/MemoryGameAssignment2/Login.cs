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

namespace MemoryGameAssignment2
{
    public partial class Login : Form
    {
        public HomePage homePageForm;

        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; 
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\Projects;Initial Catalog=memoryGame;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;");
            SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from loginInformation where username='" + txt_username.Text +"' and password='" + txt_password.Text +"'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                HomePage hp = new HomePage();
                hp.Show();
            }
            else 
            {
                MessageBox.Show("Please provide both correct UserName and Password", "Incorrect UserName or Password");
                return;
            } 
        }

        private void btn_addPlayer_Click(object sender, EventArgs e)
        {

            if (txt_username.Text == "" && txt_password.Text == "")
            {
                MessageBox.Show("No Blank Username or Password will be accepted Accepted", "No Blank Username and Password");
                return;
            }

            SqlConnection con = new SqlConnection("Data Source=(localdb)\\Projects;Initial Catalog=memoryGame;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;");
            con.Open();
            string query = "insert into loginInformation (username, password) values (@username, @password)";
            SqlCommand myCommand = new SqlCommand(query, con);
            myCommand.Parameters.AddWithValue("@username", txt_username.Text);
            myCommand.Parameters.AddWithValue("@password", txt_password.Text);
            myCommand.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Please try using you New Username and Password", "New Username and Password");
        }

    }
}
