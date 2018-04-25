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
    public partial class Instructions : Form
    {
        public Instructions()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; 
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage hp = new HomePage( );
            hp.Show();

        }

    }
}
