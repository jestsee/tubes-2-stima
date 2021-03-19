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
            Console.ReadKey();
        }
    }
}
