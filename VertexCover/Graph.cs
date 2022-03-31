﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VertexCover
{
    public class Graph
    {
        private List<int> verticiesToConnect = new List<int>();
        private List<List<int>> adjacent_list;
        private int vertices;
        private Random random = new Random();

        public List<List<int>> get_adjacent_list()
        {
            return adjacent_list;
        }

        public int get_vertices() { return vertices; }


        public void create_graph (int v)
        {
            this.vertices = v;
            adjacent_list = new List<List<int>>();

            for (int i = 0; i < v; i++)
            {
                adjacent_list.Add(new List<int>());
            }
        }

        public bool add_edge(int source, int destination)
        {
            if (adjacent_list[source].Contains(destination) || source == destination)
            {
                return false;
            }
            adjacent_list[source].Add(destination);
            adjacent_list[destination].Add(source);
            return true;
        }

        public void connect()
        {
            foreach (var vertex in verticiesToConnect)
            {
                add_edge(verticiesToConnect[0], vertex);
            }
        }

        public void ReachableVert(int v, bool[] visited, bool foundArbitraryVertice)
        {
            if (!foundArbitraryVertice)
            {
                verticiesToConnect.Add(v);
                foundArbitraryVertice = true;
            }

            // Mark the current node as visited and print it
            visited[v] = true;
            Console.Write(/*"f "+*/ v + " ");
            // Recur for all the vertices
            // adjacent to this vertex
            foreach (int x in adjacent_list[v])
            {
                if (!visited[x])
                {
                    ReachableVert(x, visited, foundArbitraryVertice);
                }
                    
            }
        }



        public void connectedComponents()
        {
            // Mark all the vertices as not visited
            bool[] visited = new bool[vertices];
            for (int v = 0; v < vertices; v++)
            {
                if (!visited[v])
                {
                    // print all reachable vertices
                    // from v
                    ReachableVert(v, visited, false);
                    Console.WriteLine();
                }
            }
        }

        public void add_edges_on_probability(int prob)
        {
            for (int i = 0; i< vertices; i++)
            {
                for(int j = i + 1; j < vertices; j++)
                {
                    int probability = random.Next(1, 101);
                       if (probability <= prob)
                       {
                          add_edge(i, j);
                       }
                }
            }
        }

       public void write_graph_to_file()
        {
            FileStream fileStream = null;
            StreamWriter streamWriter = null;

            try
            {
                fileStream = new FileStream("graph.dot", FileMode.Open, FileAccess.Write);
                streamWriter = new StreamWriter(fileStream);

                streamWriter.WriteLine("graph my_graph { node[fontname = Arial, style = \"filled,setlinewidth(4)\",shape = circle]");

                for (int i = 0; i < adjacent_list.Count(); i++)
                {
                    streamWriter.WriteLine("node" + i + "[ label =\" " + i + "\"]");
                }

                for (int i = 0; i < adjacent_list.Count(); i++)
                {
                    for (int j = 0; j < adjacent_list[i].Count(); j++)
                    {
                        if (adjacent_list[i][j] >= i)
                        {
                            streamWriter.WriteLine("node" + i + "--" + "node" + adjacent_list[i][j]);
                        }
                    }
                }
                streamWriter.WriteLine("}");

            }
            catch (IOException)
            {
                throw;
            }
            finally
            {
                if (streamWriter != null)
                {
                    streamWriter.Close();
                }
            }

        }
    }
}
