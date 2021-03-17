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
            Console.ReadKey();
        }
    }
}
