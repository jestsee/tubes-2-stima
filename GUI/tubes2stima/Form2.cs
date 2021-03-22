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
        string fn;
        Graph g;
        Dictionary<int, string> dic;
        string AkunTerpilih;
        int algorithm;
        public recommendation(Graph graf, Dictionary<int, string> dictionary, int algo, string f)
        {
            InitializeComponent();
            textBox1.Visible = false;
            g = graf;
            dic = dictionary;
            fn = f;
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
            Explore explore = new Explore(g, dic, algorithm, fn);
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
            int Nsimpul = g.getNSimpul();
            friendRecommendation fR = new friendRecommendation();
            string message = fR.friendrecommendation(AkunTerpilih, Nsimpul, g, algorithm);
            textBox1.AppendText(message);
            textBox1.AppendText(Environment.NewLine);
            textBox1.Visible = true;
        }

        private void akun1_SelectedIndexChanged(object sender, EventArgs e)
        {
            AkunTerpilih = akun1.SelectedItem.ToString();
        }

    }
}
