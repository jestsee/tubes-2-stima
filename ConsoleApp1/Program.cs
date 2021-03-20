using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using Microsoft.Msagl.Core.Layout;
using Microsoft.Msagl.Drawing;

namespace tubes2stima
{
    class Driver
    {
        // Main
        public static void Main(String[] args)
        {
            
            FileHandler f = new FileHandler();
            DFS dfs = new DFS();
            friendRecommendation fren = new friendRecommendation();
            BFSsearch test = new BFSsearch();

            /*
            // MEMBACA FILE EKSTERNAL
            Console.Write("Masukan nama file : ");
            string fileName = Console.ReadLine();
            var Result = f.readFile(fileName);

            // menghitung jumlah simpul (N)
            int N = (from x in Result select x).Distinct().Count();

            // generate dictionary
            var dictionary = f.generateDictionary(Result, N);

            // construct graph
            Graph g = new Graph(N);
            g.setDict(dictionary);
            g.generateGraph(Result);
            g.printGraph();

            // Contoh
            Console.Write("Masukkan nama pengguna 1 :");
            string pengguna1 = Console.ReadLine();
            Console.Write("Masukkan nama pengguna 2 : ");
            string pengguna2 = Console.ReadLine();
            dfs.StartDFS(pengguna1, pengguna2, g);
            int BanyakAkun = g.getNSimpul();
            fren.friendrecommendation(pengguna1, BanyakAkun, g, 1);
            // Console.WriteLine(g.getDictionary()[0]);

            // tes bfs
            Console.WriteLine("\ntes bfs");
            test.printBFSPath(pengguna1, pengguna2, g);
            Console.ReadKey();*/

            /*
            //////// MSAGL ////////
            // create a form 
            System.Windows.Forms.Form form = new System.Windows.Forms.Form();

            // create a viewer object 
            Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();

            // create a graph object 
            Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("ini adalah graph");

            // create the graph content 
            var Edge = graph.AddEdge("A", "B");

            Edge.Attr.ArrowheadAtTarget = ArrowStyle.None;
            Edge.Attr.ArrowheadAtSource = ArrowStyle.None;

            graph.AddEdge("B", "C");
            graph.AddEdge("A", "C").Attr.Color = Microsoft.Msagl.Drawing.Color.Green;
            graph.FindNode("A").Attr.FillColor = Microsoft.Msagl.Drawing.Color.Magenta;
            graph.FindNode("B").Attr.FillColor = Microsoft.Msagl.Drawing.Color.MistyRose;
            Microsoft.Msagl.Drawing.Node c = graph.FindNode("C");
            c.Attr.FillColor = Microsoft.Msagl.Drawing.Color.PaleGreen;
            c.Attr.Shape = Microsoft.Msagl.Drawing.Shape.Diamond;
            

            //bind the graph to the viewer 
            viewer.Graph = graph;
            //associate the viewer with the form 
            form.SuspendLayout();
            viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            form.Controls.Add(viewer);
            form.ResumeLayout();
            //show the form 
            form.ShowDialog();*/

            var Result = f.readFile("testnama.txt");
            drawGraph(Result);
        }

        public static void drawGraph(string[]result)
        {
            // create a form 
            System.Windows.Forms.Form form = new System.Windows.Forms.Form();

            // create a viewer object 
            Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();

            List<string> list = new List<string>(result);
            var n = list.Count;

            Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("ini adalah graph");
            for (int i = 0; i <n; i+=2)
            {
                var Edge = graph.AddEdge(list.ElementAt(i), list.ElementAt(i + 1));
                
                // undirect graph
                Edge.Attr.ArrowheadAtTarget = ArrowStyle.None;
                Edge.Attr.ArrowheadAtSource = ArrowStyle.None;

                // change shape
                Microsoft.Msagl.Drawing.Node c = graph.FindNode(list.ElementAt(i));
                c.Attr.FillColor = Microsoft.Msagl.Drawing.Color.PaleGreen;
                c.Attr.Shape = Microsoft.Msagl.Drawing.Shape.Circle;

                Microsoft.Msagl.Drawing.Node c1 = graph.FindNode(list.ElementAt(i+1));
                c1.Attr.FillColor = Microsoft.Msagl.Drawing.Color.PaleGreen;
                c1.Attr.Shape = Microsoft.Msagl.Drawing.Shape.Circle;

            }
            viewer.Graph = graph;
            //associate the viewer with the form 
            form.SuspendLayout();
            viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            form.Controls.Add(viewer);
            form.ResumeLayout();
            //show the form 
            form.ShowDialog();
        }
    }
}
