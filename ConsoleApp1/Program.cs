using System;
using System.Linq;
using System.Collections.Generic;

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
            Console.Write("Masukkan nama pengguna 1 : ");
            string pengguna1 = Console.ReadLine();
            Console.Write("Masukkan nama pengguna 2 : ");
            string pengguna2 = Console.ReadLine();
            dfs.StartDFS(pengguna1, pengguna2, g);
            int BanyakAkun = g.getNSimpul();
            fren.friendrecommendation(pengguna1, BanyakAkun, g, 1);
            // Console.WriteLine(g.getDictionary()[0]);

            // tes bfs
            Console.WriteLine("\ntes bfs");
            List<int> path = test.printBFSPath(pengguna1,pengguna2, g);
            Console.ReadKey();

            /////////////////////
            */
            //////////// TEST MSAGL //////////
            Visualization v = new Visualization();
            var Result = f.readFile("test1.txt");

            // menghitung jumlah simpul (N)
            int N = (from x in Result select x).Distinct().Count();

            // generate dictionary
            var dictionary = f.generateDictionary(Result, N);

            // construct graph
            Graph g = new Graph(N);
            g.setDict(dictionary);
            g.generateGraph(Result);

            // create a form 
            System.Windows.Forms.Form form = new System.Windows.Forms.Form();
            // create a viewer object 
            Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
            // create graph
            Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("ini adalah graph");
            List<int> path = test.printBFSPath("A", "H", g);
            List<string> route = dfs.StartDFS1("A", "H", g);
            v.drawGraph(Result, form, viewer, graph);
            v.highlightRouteBFS(path, g, form, viewer, graph);
            v.highlightRouteDFS(route, g, form, viewer, graph);
            
        }
        
    }
}
