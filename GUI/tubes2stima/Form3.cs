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
    public partial class Explore : Form
    {
        public Explore()
        {
            InitializeComponent();
        }

        private void akun1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void akun2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void submit1_Click(object sender, EventArgs e)
        {

        }

        private void Main_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.ShowDialog();
        }

        private void recommendation_Click(object sender, EventArgs e)
        {
            recommendation recomm = new recommendation();
            this.Hide();
            recomm.ShowDialog();
        }
    }
}
