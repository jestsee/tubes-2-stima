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
            textBox1.Visible = false;
            //gViewer1.Visible = false;
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
            //gViewer1.Visible = true;
            FileHandler f = new FileHandler();
            var Result = f.readFile(fn);
            int N = (from x in Result select x).Distinct().Count();
            g = new Graph(N);
            g.setDict(dic);
            g.generateGraph(Result); 
            Explore form = new Explore(g,dic,2,fn);
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
                List <int> path = bfs.BFSPath(AkunTerpilih1,AkunTerpilih2, g);
                if (bfs.BFS(adj, s, dest, g, pred, dist) == false)
                {
                    textBox1.Text = "No path to make a connection";
                    textBox1.Visible = true;
                    textBox1.ScrollBars = ScrollBars.Vertical;
                    textBox1.ReadOnly = true;
                }
                else
                {
                    Visualization vis = new Visualization();
                    string message=bfs.showMessageBFS(AkunTerpilih1, AkunTerpilih2,g);
                    double deg = dist[dest];
                    message = message + "," + (Math.Ceiling(deg / 2)) + "-th degree)\r\n";
                    textBox1.Text = message;
                    textBox1.Visible = true;
                    textBox1.ReadOnly = true;
                    //this.Hide();
                    vis.drawRoute(Result, g, path,gViewer1);
                }
            }
            else
            {
                DFS dfs = new DFS();
                dfs.StartDFS(AkunTerpilih1,AkunTerpilih2,g);
                List<string> route = dfs.StartDFS1(AkunTerpilih1, AkunTerpilih2, g);
                if(!route.Contains(AkunTerpilih2))
                {
                    textBox1.AppendText("No path to make a connection");
                    //textBox1.Visible = true;
                    //textBox1.ScrollBars = ScrollBars.Vertical;
                    textBox1.ReadOnly = true;
                }
                else
                {
                    Visualization vis = new Visualization();
                    string message=dfs.showMessageDFS(AkunTerpilih1,AkunTerpilih2,g);
                    textBox1.AppendText(message);
                    textBox1.Visible = true;
                    textBox1.ReadOnly = true;
                    //this.Hide();
                    vis.drawRoute(Result,g,route,gViewer1);
                }
            }
        }

        private void Main_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            this.Hide();
            help.ShowDialog();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutus us = new aboutus();
            this.Hide();
            us.ShowDialog();
        }

        private void gViewer1_Load(object sender, EventArgs e)
        {

        }

        private void recommendation_Click(object sender, EventArgs e)
        {
            recommendation recomm = new recommendation(g, dic, algorithm,fn);
            this.Hide();
            recomm.ShowDialog();
        }
    }
}
