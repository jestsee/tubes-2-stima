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
    public partial class recommendation : Form
    {
        public recommendation()
        {
            InitializeComponent();
        }

        private void explore_Click(object sender, EventArgs e)
        {
            Explore explore = new Explore();
            this.Hide();
            explore.ShowDialog();
        }

        private void Main_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.ShowDialog();
        }

        private void submit1_Click(object sender, EventArgs e)
        {

        }

        private void akun1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
