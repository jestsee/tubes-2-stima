using System;
using System.Linq;
using System.Collections.Generic;

namespace tubes2stima
{
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
            return (_dictionary.FirstOrDefault(x => Equals(x.Value,n)).Key);
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
                var keynya = this.getKey(item);
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
}
