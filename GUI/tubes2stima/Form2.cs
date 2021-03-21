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
       // string filename;
        Graph g;
        Dictionary<int, string> dic;
        string AkunTerpilih;
        int algorithm;
        public recommendation(Graph graf, Dictionary<int, string> dictionary, int algo)
        {
            InitializeComponent();
            g = graf;
            dic = dictionary;
            //test.Text = file;
            string name;
            algorithm = algo;
            int Nsimpul = g.getNSimpul();
            for (int i = 0; i < Nsimpul; i++)
            {
                name = dic[i];
                akun1.Items.Add(name);
            }
        }

        private void explore_Click(object sender, EventArgs e)
        {
            Explore explore = new Explore(g, dic, algorithm);
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
            //lakukan pencarian

            //tampilkan hasil pencarian
        }

        private void akun1_SelectedIndexChanged(object sender, EventArgs e)
        {
            AkunTerpilih = akun1.SelectedItem.ToString();
        }

    }
}
