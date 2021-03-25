using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Msagl.Core.Layout;
using Microsoft.Msagl.Drawing;
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
            Visualization v = new Visualization();
            Main main = new Main();
            v.drawGraph(Result, gViewer1);
            //this.Hide();
        }

        private void recommendation_Click(object sender, EventArgs e)
        {
            recommendation recomm = new recommendation(g, dictionary, algotithm, filename);
            this.Hide();
            recomm.ShowDialog();
        }

        private void explore_Click(object sender, EventArgs e)
        {
            Explore explore = new Explore(g, dictionary, algotithm,filename);
            this.Hide();
            explore.ShowDialog();
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
            /*List<string> list = new List<string>(result);
            var n = list.Count;
            // create a form 
            System.Windows.Forms.Form form = new System.Windows.Forms.Form();
            // create a viewer object 
            Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
            // create graph
            Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("ini adalah graph");

            for (int i = 0; i < n; i += 2)
            {
                var Edge = graph.AddEdge(list.ElementAt(i), list.ElementAt(i + 1));
                // undirect graph
                Edge.Attr.ArrowheadAtTarget = ArrowStyle.None;
                Edge.Attr.ArrowheadAtSource = ArrowStyle.None;

                // change shape
                Microsoft.Msagl.Drawing.Node c = graph.FindNode(list.ElementAt(i));
                c.Attr.FillColor = Microsoft.Msagl.Drawing.Color.AntiqueWhite;
                c.Attr.Shape = Microsoft.Msagl.Drawing.Shape.Circle;

                Microsoft.Msagl.Drawing.Node c1 = graph.FindNode(list.ElementAt(i + 1));
                c1.Attr.FillColor = Microsoft.Msagl.Drawing.Color.AntiqueWhite;
                c1.Attr.Shape = Microsoft.Msagl.Drawing.Shape.Circle;

            }
            viewer.Graph = graph;
            //associate the viewer with the form 
            this.SuspendLayout();
            viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Controls.Add(viewer);
            this.ResumeLayout();
            //show the form 
            this.ShowDialog();*/
        }
    }
}
