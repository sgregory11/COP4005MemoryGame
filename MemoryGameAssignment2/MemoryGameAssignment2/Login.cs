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

    }
}
