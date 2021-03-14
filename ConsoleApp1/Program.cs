using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

class Graph
{
    // menambahkan simpul yang bersisian
    static void addEdge(LinkedList<int>[] adj,
                        int u, int v)
    {
        adj[u].AddLast(v);
        adj[v].AddLast(u);
    }

    // mencetak daftar simpul yang bertetanggaan dari setiap simpul
    static void printGraph(LinkedList<int>[] adj, Dictionary<int, string> myDictionary)
    {
        for (int i = 0; i < adj.Length; i++)
        {
            Console.Write("\nSimpul yang bertetanggan dengan simpul "+myDictionary[i]+" adalah");
            //Console.Write(myDictionary[i]);

            foreach (var item in adj[i])
            {
                Console.Write(" {0} ",myDictionary[item]);
            }
            Console.WriteLine();
        }
    }

    // Driver Code 
    public static void Main(String[] args)
    {
        /*
        int V = 5;

        // inisialisasi graf dengan 5 simpul
        LinkedList<int>[] adj = new LinkedList<int>[V];


        for (int i = 0; i < V; i++)
            adj[i] = new LinkedList<int>();

        // Adding edges one by one 
        addEdge(adj, 0, 1); // 0 bertetangga dengan 1
        addEdge(adj, 0, 4); // 0 bertetangga dengan 4
        addEdge(adj, 1, 2);
        addEdge(adj, 1, 3);
        addEdge(adj, 1, 4);
        addEdge(adj, 2, 3);
        addEdge(adj, 3, 4);

        printGraph(adj);

        // Prevents the screen until a key is pressed
        Console.ReadKey(); 
        */
        
        // MEMBACA FILE EKSTERNAL
        Console.Write("Masukan nama file : ");
        string fileName = Console.ReadLine();

        // mengatur directory
        string currentDir = Environment.CurrentDirectory.ToString();
        DirectoryInfo d = new DirectoryInfo(currentDir);
        string parentDir = d.Parent.Parent.Parent.Parent.ToString();

        // alternatif (ganti sama directory file test berada)
        //var fileContent = File.ReadAllText(@"C:\sem4\stima\tubes 2\ConsoleApp1\ConsoleApp1\test\" + fileName); 
        var newPath = Path.GetFullPath(Path.Combine(parentDir, @"test",fileName));
        //Console.WriteLine(newPath);
        var fileContent = File.ReadAllText(newPath);
        var Result = fileContent.Split((string[])null, StringSplitOptions.RemoveEmptyEntries);

        // membuat list of nama simpul
        List<string> arraystring = new List<string>();
        foreach (var item in Result)
        {
            if(!arraystring.Contains(item)){
                arraystring.Add(item);
            }
        }
        //arraystring.ForEach(Console.WriteLine);

        // menghitung jumlah simpul (N)
        int N = (from x in Result
                 select x).Distinct().Count();

        // membuat array of integer sebanyak dari 0..N-1
        List<int> arrayint = new List<int>();
        for(int i = 0; i < N; i++)
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

        // konversi var Result menjadi list
        List<int> mentah = new List<int>();
        foreach (var item in Result)
        {
            // akses value by key
            var keynya = dictionary.FirstOrDefault(x => x.Value == item).Key;
            mentah.Add(keynya);
        }
        //Console.WriteLine("Mentahannya : ");
        //mentah.ForEach(Console.WriteLine);


        ///////////// MEMBUAT GRAF //////////////
        // inisialisasi graf dengan N simpul
        LinkedList<int>[] adj = new LinkedList<int>[N];

        for (int i = 0; i < N; i++)
            adj[i] = new LinkedList<int>();

        //menambahkan simpul yang bersisian
        int Nmentah = mentah.Count;

        for(int i=0; i < Nmentah; i+=2)
        {
            //Console.WriteLine("{0}  {1}", i, i + 1);
            addEdge(adj, mentah[i], mentah[i+1]);
        }
        printGraph(adj, dictionary);
        Console.ReadKey();
    }
}