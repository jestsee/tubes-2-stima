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
        string filename;
        int algotithm;
        Graph g;
        Dictionary<int, string> dictionary;
        public Main()
        {
            InitializeComponent();
            //g = graf;
            //dic = dictionary;
        }

        private void submit1_Click(object sender, EventArgs e)
        {
          
            filename = file.Text;
            if (bfsbutton.Checked)
            {
                algotithm = 1;
            } else
            {
                algotithm = 2;
            }

            //buat graf
            FileHandler f = new FileHandler();
            var Result = f.readFile(filename);
            // menghitung jumlah simpul (N)
            int N = (from x in Result select x).Distinct().Count();

            // generate dictionary
            dictionary = f.generateDictionary(Result, N);

            // construct graph
            g = new Graph(N);
            g.setDict(dictionary);
            g.generateGraph(Result);

            //tampilkan visualisasi

        }

        private void recommendation_Click(object sender, EventArgs e)
        {
            recommendation recomm = new recommendation(g, dictionary, algotithm);
            this.Hide();
            recomm.ShowDialog();
        }

        private void explore_Click(object sender, EventArgs e)
        {
            Explore explore = new Explore(g, dictionary, algotithm);
            this.Hide();
            explore.ShowDialog();
        }
    }
}
