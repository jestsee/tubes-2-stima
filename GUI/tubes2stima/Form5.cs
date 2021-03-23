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
    public partial class aboutus : Form
    {
        public aboutus()
        {
            InitializeComponent();
        }

        private void Main_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.ShowDialog();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            this.Hide();
            help.ShowDialog();
        }
    }
}
