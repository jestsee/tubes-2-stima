using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Msagl.Core.Layout;
using Microsoft.Msagl.Drawing;

namespace tubes2stima
{
    public class FileHandler
    {
        public string[] readFile(string fileName)
        {
            string currentDir = Environment.CurrentDirectory.ToString();
            DirectoryInfo d = new DirectoryInfo(currentDir);
            //string parentDir = d.Parent.Parent.Parent.Parent.Parent.ToString();
            string parent = System.IO.Directory.GetParent(currentDir).FullName;
            string parentDir = System.IO.Directory.GetParent(parent).FullName;
            // alternatif (ganti sama directory file test berada)
            var newPath = Path.GetFullPath(Path.Combine(parentDir, @"test", fileName));
            Console.WriteLine(newPath);
            var fileContent = File.ReadAllText(newPath);
            var Result = fileContent.Split((string[])null, StringSplitOptions.RemoveEmptyEntries);
            return Result;
        }

        // mengembalikan hasil mapping index dengan string, menerima masukan array of string dan integer
        public Dictionary<int, string> generateDictionary(string[] Result, int N)
        {
            // membuat list of nama simpul
            List<string> arraystring = new List<string>();
            foreach (var item in Result)
            {
                if (!arraystring.Contains(item))
                {
                    arraystring.Add(item);
                }
            }

            // membuat array of integer sebanyak dari 0..N-1
            List<int> arrayint = new List<int>();
            for (int i = 0; i < N; i++)
            {
                arrayint.Add(i);
            }

            // mapping nama simpul dengan angka
            var dictionary = arrayint.Zip(arraystring, (k, v) => new { Key = k, Value = v })
                            .ToDictionary(x => x.Key, x => x.Value);
            return dictionary;
        }
    }

    public class Graph
    {
        // attribute
        private int _nSimpul;
        private LinkedList<int>[] _adj;
        private Dictionary<int, string> _dictionary;

        // constructor
        public Graph(int n)
        {
            _adj = new LinkedList<int>[n];
            _dictionary = new Dictionary<int, string>();
            for (int i = 0; i < n; i++)
            {
                _adj[i] = new LinkedList<int>();
            }
            _nSimpul = n;
        }


        public LinkedList<int>[] getAdjacent()
        {
            return this._adj;
        }

        public Dictionary<int, string> getDictionary()
        {
            return this._dictionary;
        }

        public int getNSimpul()
        {
            return this._nSimpul;
        }

        public int getKey(string n)
        {
            return (_dictionary.FirstOrDefault(x => Equals(x.Value, n)).Key);
        }

        // menambahkan simpul yang bersisian
        public void addEdge(int u, int v)
        {
            this._adj[u].AddLast(v);
            this._adj[v].AddLast(u);
        }

        // setter
        public void setDict(Dictionary<int, string> dict)
        {
            this._dictionary = dict;
        }

        // membuat graf
        public void generateGraph(string[] Result)
        {
            List<int> mentah = new List<int>();
            foreach (var item in Result)
            {
                // akses value by key
                var keynya = this.getKey(item);
                mentah.Add(keynya);
            }

            //menambahkan simpul yang bersisian
            int Nmentah = mentah.Count;

            for (int i = 0; i < Nmentah; i += 2)
            {
                this.addEdge(mentah[i], mentah[i + 1]);
            }

        }

        public List<(string, string)> edgeTuple(List<string> stringpath)
        {
            int n = stringpath.Count;
            List<(string, string)> tup = new List<(string, string)>();
            for (int i = 0; i < n; i += 2)
            {
                tup.Add((stringpath[i], stringpath[i + 1]));
            }
            return tup;
        }
    }

    class BFSsearch
    {
        public bool BFS(LinkedList<int>[] adj, int start, int end, Graph g, int[] p, int[] d)
        {
            ////// INISIALISASI //////
            // inisialisasi list untuk queue
            List<int> queue = new List<int>();

            // inisialisasi array of boolean
            bool[] visited = new bool[g.getNSimpul()];

            // semua elemen array of boolean diinisialisasi nilai false
            // array d (distance) diinisialisasi dengan infinit
            // array p (predecessor) diinisialisasi dengan -1
            for (int i = 0; i < g.getNSimpul(); i++)
            {
                visited[i] = false;
                d[i] = int.MaxValue;
                p[i] = -1;
            }

            // proses simpul start
            visited[start] = true;
            d[start] = 0;
            queue.Add(start);

            // selama queue tidak kosong
            while (queue.Count != 0)
            {
                int cur = queue[0];
                queue.RemoveAt(0);

                LinkedList<int> tetangga = adj[cur];
                foreach (var t in tetangga)
                {
                    if (!visited[t])
                    {
                        visited[t] = true;
                        d[t] = d[cur] + 1;
                        p[t] = cur;
                        queue.Add(t);

                        // kondisi berhenti
                        if (t == end)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public List<int> printBFSPath(string start, string end, Graph g)
        {
            int s = g.getKey(start);
            int dest = g.getKey(end);

            int v = g.getNSimpul();
            int[] pred = new int[v];
            int[] dist = new int[v];
            LinkedList<int>[] adj = g.getAdjacent();
            List<int> path = new List<int>();

            if (BFS(adj, s, dest, g, pred, dist) == false)
            {
                return path;
            }

            
            int crawl = dest;
            path.Add(crawl);

            while (pred[crawl] != -1)
            {
                path.Add(pred[crawl]);
                crawl = pred[crawl];
            }
            return path;
        }

        public List<string> getStringPath(List<int> intpath, Graph g)
        {
            List<string> stringpath = new List<string>();
            foreach (var i in intpath)
            {
                stringpath.Add(g.getDictionary()[i]);
            }
            stringpath.Reverse();
            return stringpath;
        }

        public List<(string,string)> listOfPath (List<string> stringpath)
        {
            int n = stringpath.Count;
            List<(string, string)> tup = new List<(string, string)>();
            for(int i=0; i<n-1; i++)
            {
                tup.Add((stringpath[i], stringpath[i + 1]));
            }
            return tup;
        }
        public string showMessageBFS(string start, string end, Graph g)
        {
            string message="(";
            List<int> path = printBFSPath(start, end, g);
            for (int i =path.Count-1; i > 0; i--)
            {
                message = message + g.getDictionary()[path[i]] + " -> ";
            }
            message = message + g.getDictionary()[path[0]];
            return message;
        }

    }

    class DFS
    {
        public void StartDFS(string start, string destination, Graph graph)
        {
            List<string> route = new List<string>();
            var _visited = new HashSet<string>();
            int idx = 0;
            string value = "";
            foreach (var a in graph.getDictionary())
            {
                graph.getDictionary().TryGetValue(a.Key, out value);
                if (Equals(value, start))
                {
                    idx = a.Key;
                    break;
                }
            }
            DepthFirstSearch(idx, start, destination, route, graph, _visited);
        }

        public List<string> StartDFS1(string start, string destination, Graph graph)
        {
            List<string> route = new List<string>();
            var _visited = new HashSet<string>();
            int idx = 0;
            string value = "";
            foreach (var a in graph.getDictionary())
            {
                graph.getDictionary().TryGetValue(a.Key, out value);
                if (Equals(value, start))
                {
                    idx = a.Key;
                    break;
                }
            }
            DepthFirstSearch(idx, start, destination, route, graph, _visited);
            return route;
        }

        public void DepthFirstSearch(int i, string start, string destination, List<string> route, Graph graph, HashSet<string> _visited)
        {
            _visited.Add(start);
            if (!_visited.Contains(destination))
            {
                route.Add(start);
                foreach (var b in graph.getAdjacent()[i])
                {
                    if(!_visited.Contains(graph.getDictionary()[b]))
                    {
                        DepthFirstSearch(b, graph.getDictionary()[b], destination, route, graph, _visited);
                    }
                }
                if(!_visited.Contains(destination))
                {
                    route.Remove(start);
                }
            }
            if (Equals(start, destination))
            {
                route.Add(destination);
            }
        }
        public string showMessageDFS(string start, string destination, Graph graph)
        {
            string message="(";
            int degreeConnection = 0;
            foreach (var a in StartDFS1(start, destination, graph))
            {
                if (!Equals(a, destination))
                {
                    message = message + a + "->";
                }
                else
                {
                    if(degreeConnection>1)
                    {
                        message = message + a +"," + (degreeConnection-1) + "-th degree)\r\n";
                    }
                    else
                    {
                        message = message + a +"," + degreeConnection + "-th degree)\r\n";
                    }
                }
                degreeConnection++;
            }
            return message;
        }
    }

    class friendRecommendation
    {
        public int GetMax(int[] BanyakMutual, int Nelement)
        {
            int idxmax = 0;
            for (int i = 1; i < Nelement; i++)
            {
                if (BanyakMutual[i] > BanyakMutual[idxmax])
                {
                    idxmax = i;
                }
            }
            return idxmax;
        }

        public string friendrecommendation(string Akun, int BanyakAkun, Graph graph, int algo)
        {
            DFS dfs = new DFS();
            string message = "";
            int[] BanyakMutual = new int[BanyakAkun];
            int idx = 0;
            string value = "";
            foreach (var a in graph.getDictionary())
            {
                graph.getDictionary().TryGetValue(a.Key, out value);
                if (Equals(value, Akun))
                {
                    idx = a.Key;
                    break;
                }
            }
            for (int i = 0; i < BanyakAkun; i++)
            {
                BanyakMutual[i] = 0;
            }
            foreach (var node in graph.getAdjacent()[idx])
            {
                foreach (var tetangga in graph.getAdjacent()[node])
                {
                    BanyakMutual[tetangga]++;
                }
            }

            BanyakMutual[idx] = 0;
            foreach (var node in graph.getAdjacent()[idx])
            {
                BanyakMutual[node] = 0;
            }
            //ambil dari nilai yang terbesar
            BFSsearch bfs = new BFSsearch();
            int v = graph.getNSimpul();
            int [] pred = new int[v];
            int [] dist = new int [v];
            LinkedList<int>[] adj=graph.getAdjacent();
            int s = graph.getKey(Akun);
            message = message + "Daftar rekomendasi teman untuk akun " + graph.getDictionary()[idx] + ":\r\n";
            int idxmax = GetMax(BanyakMutual, BanyakAkun);
            while (BanyakMutual[idxmax] != 0)
            {
                message = message + "\r\nNama Akun: \r\n" + graph.getDictionary()[idxmax] ;
                if (algo == 1) //dengan algortima BFS
                {
                    int dest = graph.getKey(graph.getDictionary()[idxmax]);
                    bfs.BFS(adj, s, dest, graph, pred, dist);
                    // Print path
                    double deg = dist[dest];
                    List <int> path = bfs.printBFSPath(Akun,graph.getDictionary()[idxmax], graph);
                    string c = bfs.showMessageBFS(Akun,graph.getDictionary()[idxmax], graph);
                    message = message + c + "," + (Math.Ceiling(deg / 2)) + "-th degree)\r\n";
                }
                else
                {
                    dfs.StartDFS(Akun, graph.getDictionary()[idxmax], graph);
                    string c = dfs.showMessageDFS(Akun, graph.getDictionary()[idxmax], graph);
                    message = message + c;
                }
                message = message + BanyakMutual[idxmax] + " mutual friends: \r\n";
                foreach (var node in graph.getAdjacent()[idx])
                {
                    foreach (var node2 in graph.getAdjacent()[idxmax])
                    {
                        if (node == node2 && node2 != idx)
                        {
                            message = message + graph.getDictionary()[node2] + " ";
                        }
                    }
                }
                BanyakMutual[idxmax] = 0;
                idxmax = GetMax(BanyakMutual, BanyakAkun);
                message = message + "\r\n";
            }
            return message;
        }
    }

    class Visualization
    {
        public void highlightRouteBFS(List<int> path, Graph g,
            System.Windows.Forms.Form form,
            Microsoft.Msagl.GraphViewerGdi.GViewer viewer,
            Microsoft.Msagl.Drawing.Graph graph)
        {
            for (int i = 0; i < path.Count; i++)
            {
                string node = g.getDictionary()[path.ElementAt(i)];

                // highlight node
                Microsoft.Msagl.Drawing.Node c = graph.FindNode(node);
                c.Attr.FillColor = Microsoft.Msagl.Drawing.Color.Crimson;
                c.Attr.Shape = Microsoft.Msagl.Drawing.Shape.Circle;
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

        public void drawRoute(string[] mentah, Graph g, List<int> bfsint, Microsoft.Msagl.GraphViewerGdi.GViewer viewer)
        {
            BFSsearch test = new BFSsearch();
            List<string> test2 = test.getStringPath(bfsint, g);
            var lp = test.listOfPath(test2);

            List<string> stringmentah = new List<string>(mentah);
            var lp2 = g.edgeTuple(stringmentah);

            // create a form 
            System.Windows.Forms.Form form = new System.Windows.Forms.Form();
            // create a viewer object 
            //Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
            // create graph
            Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("ini adalah graph");

            foreach (var i in lp2)
            {
                var tempEdge = graph.AddEdge(i.Item1, i.Item2);
                tempEdge.Attr.ArrowheadAtTarget = ArrowStyle.None;
                tempEdge.Attr.ArrowheadAtSource = ArrowStyle.None;
                if (lp.Contains(i))
                {
                    tempEdge.Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                }
                else
                {
                    tempEdge.Attr.Color = Microsoft.Msagl.Drawing.Color.Black;
                }

            }

            for (int i = 0; i < g.getNSimpul(); i++)
            {
                string node = g.getDictionary()[i];
                Microsoft.Msagl.Drawing.Node c = graph.FindNode(node);

                if (!bfsint.Contains(i))
                {
                    c.Attr.FillColor = Color.AntiqueWhite;
                    c.Attr.Shape = Shape.Circle;
                }
                else
                {
                    c.Attr.FillColor = Color.Red;
                    c.Attr.Shape = Shape.Circle;
                }

            }
            viewer.Graph = graph;
            //associate the viewer with the form 
            //form.SuspendLayout();
            //viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            //form.Controls.Add(viewer);
            //form.ResumeLayout();
            //show the form 
            //form.ShowDialog();

        }

        public void drawRoute(string[] mentah, Graph g, List<string> route, Microsoft.Msagl.GraphViewerGdi.GViewer viewer)
        {
            BFSsearch test = new BFSsearch();
            var lp = test.listOfPath(route);

            List<string> stringmentah = new List<string>(mentah);
            var lp2 = g.edgeTuple(stringmentah);

            // create a form 
            //System.Windows.Forms.Form f = new System.Windows.Forms.Form();
            // create a viewer object 
            //Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
            // create graph
            Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("ini adalah graph");

            foreach (var i in lp2)
            {
                var tempEdge = graph.AddEdge(i.Item1, i.Item2);
                tempEdge.Attr.ArrowheadAtTarget = ArrowStyle.None;
                tempEdge.Attr.ArrowheadAtSource = ArrowStyle.None;
                if (lp.Contains(i) ||
                    lp.Contains((i.Item2, i.Item1)))
                {
                    tempEdge.Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                }
                else
                {
                    tempEdge.Attr.Color = Microsoft.Msagl.Drawing.Color.Black;
                }

            }

            List<int> bfsint = new List<int>();
            foreach(var i in route)
            {
                bfsint.Add(g.getKey(i));
            }

            for (int i = 0; i < g.getNSimpul(); i++)
            {
                string node = g.getDictionary()[i];
                Microsoft.Msagl.Drawing.Node c = graph.FindNode(node);

                if (!bfsint.Contains(i))
                {
                    c.Attr.FillColor = Microsoft.Msagl.Drawing.Color.AntiqueWhite;
                    c.Attr.Shape = Microsoft.Msagl.Drawing.Shape.Circle;
                }
                else
                {
                    c.Attr.FillColor = Microsoft.Msagl.Drawing.Color.Red;
                    c.Attr.Shape = Microsoft.Msagl.Drawing.Shape.Circle;
                }

            }
            viewer.Graph = graph;
            //associate the viewer with the form 
            //f.SuspendLayout();
            //viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            //f.Controls.Add(viewer);
            //f.ResumeLayout();
            //show the form 
            //f.ShowDialog();
        }

        public void drawGraph(string[] result, Microsoft.Msagl.GraphViewerGdi.GViewer viewer)
        {
            List<string> list = new List<string>(result);
            var n = list.Count;
            // create a form 
            //System.Windows.Forms.Form form = new System.Windows.Forms.Form();
            // create a viewer object 
            //Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
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
            //form.SuspendLayout();
            //viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            //form.Controls.Add(viewer);
            //form.ResumeLayout();
            //show the form 
            //form.ShowDialog();
        }

    }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());

        }
    }
}
