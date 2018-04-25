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
    public partial class HomePage : Form
    {
        public difficultySelect difficultySelectForm;

        public HomePage()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; 
        }

        private void btn_startGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            difficultySelect ds = new difficultySelect( );
            ds.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string con = "Data Source=(localdb)\\Projects;Initial Catalog=memoryGame;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;";
            SqlConnection cdb = new SqlConnection(con);
            string query = "SELECT scores FROM highScores ORDER BY scores DESC";
            SqlCommand myCommand = new SqlCommand(query, cdb);

            try
            {
                SqlDataAdapter da = new SqlDataAdapter(myCommand);
                da.SelectCommand = myCommand;
                DataTable table = new DataTable();
                da.Fill(table);
                BindingSource bs = new BindingSource();
                bs.DataSource = table;
                dataGridView1.DataSource = bs;
                da.Update(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Howtoplay_Click(object sender, EventArgs e)
        {
            this.Hide();
            Instructions htp = new Instructions();
            htp.Show();
        }



    }
}
