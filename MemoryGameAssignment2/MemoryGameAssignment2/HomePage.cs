using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGameAssignment2
{
    public partial class HomePage : Form
    {
        public difficultySelect difficultySelectForm;
        int timer;

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

    }
}
