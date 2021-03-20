using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tubes2stima
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void submit1_Click(object sender, EventArgs e)
        {

        }

        private void recommendation_Click(object sender, EventArgs e)
        {
            recommendation recomm = new recommendation();
            this.Hide();
            recomm.ShowDialog();
        }

        private void explore_Click(object sender, EventArgs e)
        {
            Explore explore = new Explore();
            this.Hide();
            explore.ShowDialog();
        }
    }
}
