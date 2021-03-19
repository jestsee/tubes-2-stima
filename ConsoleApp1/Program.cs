using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace tubes2stima
{
    // implementasi graf dalam bentuk list of linked list
    class Graph
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
            for(int i=0; i < n; i++)
            {
                _adj[i] = new LinkedList<int>();
            }
            _nSimpul = n;
        }


        public LinkedList<int>[] getAdjacent()
        {
            return this._adj;
        }

        public Dictionary<int,string> getDictionary()
        {
            return this._dictionary;
        }

        public int getNSimpul()
        {
            return this._nSimpul;
        }

        public int getKey(string n)
        {
            return(_dictionary.FirstOrDefault(x => x.Value == n).Key);
        }

        // menambahkan simpul yang bersisian
        public void addEdge(int u, int v)
        {
            this._adj[u].AddLast(v);
            this._adj[v].AddLast(u);
        }

        // mencetak daftar simpul yang bertetanggaan dari setiap simpul
        public void printGraph()
        {
            for (int i = 0; i < this._nSimpul; i++)
            {
                Console.Write("\nSimpul yang bertetanggan dengan simpul " + _dictionary[i] + " adalah");
                //Console.Write(myDictionary[i]);

                foreach (var item in _adj[i])
                {
                    Console.Write(" {0} ", _dictionary[item]);
                }
                Console.WriteLine();
            }
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
                var keynya = _dictionary.FirstOrDefault(x => x.Value == item).Key;
                mentah.Add(keynya);
            }

            //menambahkan simpul yang bersisian
            int Nmentah = mentah.Count;

            for (int i = 0; i < Nmentah; i += 2)
            {
                //Console.WriteLine("{0}  {1}", i, i + 1);
                this.addEdge(mentah[i], mentah[i + 1]);
            }
            
        }
    }

    class Driver
    {
        // membaca file dan mengembalikan array of string
        static string[] readFile(string fileName)
        {
            string currentDir = Environment.CurrentDirectory.ToString();
            DirectoryInfo d = new DirectoryInfo(currentDir);
            string parentDir = d.Parent.Parent.Parent.Parent.ToString();

            // alternatif (ganti sama directory file test berada)
            //var fileContent = File.ReadAllText(@"C:\sem4\stima\tubes 2\ConsoleApp1\ConsoleApp1\test\" + fileName); 
            var newPath = Path.GetFullPath(Path.Combine(parentDir, @"test", fileName));
            //Console.WriteLine(newPath);
            var fileContent = File.ReadAllText(newPath);
            var Result = fileContent.Split((string[])null, StringSplitOptions.RemoveEmptyEntries);
            return Result;
        }

        // mengembalikan hasil mapping index dengan string, menerima masukan array of string dan integer
        static Dictionary<int, string> generateDictionary(string[] Result, int N)
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
            //arraystring.ForEach(Console.WriteLine);

            // membuat array of integer sebanyak dari 0..N-1
            List<int> arrayint = new List<int>();
            for (int i = 0; i < N; i++)
            {
                arrayint.Add(i);
            }
            //arrayint.ForEach(Console.WriteLine);

            // mapping nama simpul dengan angka
            var dictionary = arrayint.Zip(arraystring, (k, v) => new { Key = k, Value = v })
                            .ToDictionary(x => x.Key, x => x.Value);

            // mencetak hasil mapping
            foreach (var a in dictionary)
                Console.WriteLine("Key : {0}, Value : {1}", a.Key, a.Value);
            // cara akses dictionary : dictionary[key]
            //Console.WriteLine(dictionary[1]);
            return dictionary;
        }

        public static void StartDFS(string start, string destination, Graph graph)
        {
            List<string> route = new List<string>();
            var _visited = new HashSet<string>();
            int idx = 0;
            int degreeConnection = 0;
            string value = "";
            foreach (var a in graph.getDictionary())
            {
                graph.getDictionary().TryGetValue(a.Key, out value);
                if(Equals(value,start))
                {
                    idx = a.Key;
                    break;
                }
            }
            DepthFirstSearch(idx, start, destination, route, graph, _visited);
            if (route.Contains(destination))
            {
                foreach (var a in route)
                {
                    if (!Equals(a, destination)) {
                        Console.Write(a + "->");
                    }
                    else
                    {
                        Console.WriteLine(a);
                    }
                    degreeConnection++;
                }
                Console.WriteLine(degreeConnection-2 + "-th connection"); // use converter later for st, nd, rd, th...
            }
            else
            {
                Console.WriteLine("No connection");
            }
        }

        public static void DepthFirstSearch(int i, string start, string destination, List<string> route, Graph graph, HashSet<string> _visited)
        {
            _visited.Add(start);
            if(!_visited.Contains(destination)){
                route.Add(start);
                foreach (var b in graph.getAdjacent()[i])
                {
                    if (!_visited.Contains(graph.getDictionary()[b]))
                    {
                        DepthFirstSearch(b, graph.getDictionary()[b], destination, route, graph, _visited);
                    }
                }
            }
            if(Equals(start,destination))
            {
                route.Add(destination);
            }
        }

        public static int GetMax(int[] BanyakMutual, int Nelement)
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

        public static void friendrecommendation(string Akun, int BanyakAkun, Graph graph)
        {
            //LinkedList<int>[] mutual = new LinkedList<int>[BanyakAkun];
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
            //for (int i = 0; i< BanyakAkun; i++)
            //{
            //    mutual[i] = new LinkedList<int>();
            //}

            for (int i = 0; i < BanyakAkun; i++)
            {
                BanyakMutual[i] = 0;
            }
            //Console.WriteLine("Simpul " + graph.getDictionary()[idx] + " bertetangga dengan ");
            foreach (var node in graph.getAdjacent()[idx])
            {
                //Console.WriteLine(graph.getDictionary()[node] + " dan mutual dengan ");
                foreach (var tetangga in graph.getAdjacent()[node])
                {
                    //mutual[tetangga].AddLast(node);
                    BanyakMutual[tetangga]++;
                    //Console.WriteLine(graph.getDictionary()[tetangga] + " ");
                }
            }

            BanyakMutual[idx] = 0;
            foreach (var node in graph.getAdjacent()[idx])
            {
                BanyakMutual[node] = 0;
            }

            //foreach (var node in mutual)
            //{
            //    foreach (var tetangga in mutual.)
            //    {
            //        Console.WriteLine(graph.getDictionary()[tetangga]);
            //    }
            //}

            //print banyak mutual
            //for (int i = 0; i < BanyakAkun; i++)
            //{
            //    Console.WriteLine(graph.getDictionary()[i] + " banyak mutualfriend : " + BanyakMutual[i]);
            //}

            //ambil dari nilai yang terbesar
            Console.WriteLine("Daftar rekomendasi teman untuk akun " + graph.getDictionary()[idx] + ":");
            int idxmax = GetMax(BanyakMutual, BanyakAkun);
            while (BanyakMutual[idxmax] != 0)
            {
                Console.WriteLine("Nama Akun: " + graph.getDictionary()[idxmax]);
                Console.WriteLine(BanyakMutual[idxmax] + " mutual friends: ");
                foreach (var node in graph.getAdjacent()[idx])
                {
                    foreach (var node2 in graph.getAdjacent()[idxmax])
                    {
                        if (node == node2 && node2 != idx)
                        {

                            Console.WriteLine(graph.getDictionary()[node2]);
                        }
                    }
                }
                BanyakMutual[idxmax] = 0;
                idxmax = GetMax(BanyakMutual, BanyakAkun);

            }
        }

        // Main
        public static void Main(String[] args)
        {
            // MEMBACA FILE EKSTERNAL
            Console.Write("Masukan nama file : ");
            string fileName = Console.ReadLine();
            var Result = readFile(fileName);

            // menghitung jumlah simpul (N)
            int N = (from x in Result
                     select x).Distinct().Count();

            // generate dictionary
            var dictionary = generateDictionary(Result, N);

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
            StartDFS(pengguna1, pengguna2, g);
            int BanyakAkun = g.getNSimpul();
            friendrecommendation(pengguna1, BanyakAkun, g);
            // Console.WriteLine(g.getDictionary()[0]);
            Console.ReadKey();
        }
    }
}
