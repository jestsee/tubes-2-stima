using System;
using System.Collections.Generic;
using System.Text;

namespace tubes2stima
{
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

        public void friendrecommendation(string Akun, int BanyakAkun, Graph graph, int algo)
        {
            DFS dfs = new DFS();

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
                if (algo == 1) //dengan algortima DFS
                {
                    dfs.StartDFS(Akun, graph.getDictionary()[idxmax], graph);
                }
                else
                {
                    //untuk BFS
                }
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

    }
}
