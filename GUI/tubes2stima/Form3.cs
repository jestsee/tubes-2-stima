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
        //string filename;
        Graph g;
        Dictionary<int, string> dic;
        string AkunTerpilih1, AkunTerpilih2;
        int algorithm;
        public Explore(Graph graf, Dictionary<int, string> dictionary, int algo)
        {
            InitializeComponent();
            g = graf;
            dic = dictionary;
            algorithm = algo;
            string name;
            int Nsimpul = g.getNSimpul();
            for (int i = 0; i < Nsimpul; i++)
            {
                name = dic[i];
                akun1.Items.Add(name);
            }
            for (int i = 0; i < Nsimpul; i++)
            {
                name = dic[i];
                akun2.Items.Add(name);
            }
        }

        private void akun1_SelectedIndexChanged(object sender, EventArgs e)
        {
            AkunTerpilih1 = akun1.SelectedItem.ToString();
        }

        private void akun2_SelectedIndexChanged(object sender, EventArgs e)
        {
            AkunTerpilih2 = akun2.SelectedItem.ToString();
        }

        private void submit1_Click(object sender, EventArgs e)
        {
            //lakukan pencarian

            //tampilkan visualisasi hasil pencarian
        }

        private void Main_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.ShowDialog();
        }

        private void recommendation_Click(object sender, EventArgs e)
        {
            recommendation recomm = new recommendation(g, dic, algorithm);
            this.Hide();
            recomm.ShowDialog();
        }
    }
}
