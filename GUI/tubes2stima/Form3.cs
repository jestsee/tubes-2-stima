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
        Graph g;
        Dictionary<int, string> dic;
        string AkunTerpilih1, AkunTerpilih2;
        string fn;
        int algorithm;
        public Explore(Graph graf, Dictionary<int, string> dictionary, int algo, string filename)
        {
            InitializeComponent();
            g = graf;
            dic = dictionary;
            algorithm = algo;
            fn=filename;
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
            FileHandler f = new FileHandler();
            var Result = f.readFile(fn);
            int N = (from x in Result select x).Distinct().Count();
            g = new Graph(N);
            g.setDict(dic);
            g.generateGraph(Result); 
            Form form = new Form();
            Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
            Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("ini adalah graph");
            if(algorithm==1)
            {
                BFSsearch bfs = new BFSsearch();
                int s = g.getKey(AkunTerpilih1);
                int dest = g.getKey(AkunTerpilih2);
                int v = g.getNSimpul();
                int [] pred = new int[v];
                int [] dist = new int [v];
                LinkedList<int>[] adj=g.getAdjacent();
                bfs.BFS(adj, s, dest,g,pred,dist);
                List <int> path = bfs.printBFSPath(AkunTerpilih1,AkunTerpilih2, g);
                Visualization vis = new Visualization();
                vis.drawGraph(Result, form, viewer, graph);
                vis.highlightRouteBFS(path,g,form,viewer,graph);
            }
            else
            {
                DFS dfs = new DFS();
                dfs.StartDFS(AkunTerpilih1,AkunTerpilih2,g);
                List<string> route = dfs.StartDFS1(AkunTerpilih1, AkunTerpilih2, g);
                Visualization vis = new Visualization();
                vis.drawGraph(Result, form, viewer, graph);
                vis.highlightRouteDFS(route,g,form,viewer,graph);
            }
        }

        private void Main_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.ShowDialog();
        }

        private void recommendation_Click(object sender, EventArgs e)
        {
            recommendation recomm = new recommendation(g, dic, algorithm,fn);
            this.Hide();
            recomm.ShowDialog();
        }
    }
}
