using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VertexCover
{
    public partial class Form1 : Form
    {
        Graph graph = new Graph();
        VC_ALG algorithm = new VC_ALG();

        public Form1()
        {
            InitializeComponent();
        }

        private void displayGraph()
        {
            Process dot = new Process();
            dot.StartInfo.FileName = "dot.exe";
            dot.StartInfo.Arguments = "-Tpng graph.dot -o graph.png";
            dot.Start();
            dot.WaitForExit();
            pb_Graph.ImageLocation = "graph.png";
        }

        private void btn_CreateGraph_Click(object sender, EventArgs e)
        {
            int prob = 0;
            try
            {
                int vertices = Convert.ToInt32(tb_NrOfVertices.Text);
                prob = Convert.ToInt32(tb_Probability.Text);

                if (prob < 0 || prob > 100)
                {
                    prob = 0;
                    throw new Exception();
                }
                graph.create_graph(vertices);
            }
            catch
            {
                MessageBox.Show("Enter a valid integer.");
            }
            graph.add_edges_on_probability(prob);
            graph.components();
            graph.write_graph_to_file();
            displayGraph();
        }



        private void btn_ConnectGraph_Click(object sender, EventArgs e)
        {
            graph.connect();
            graph.components();
            graph.write_graph_to_file();
            displayGraph();
        }

        private void btn_bruteForce_Click(object sender, EventArgs e)
        {
            graph.IsOkVertex = true;
            bool algResult = algorithm.BruteForce(graph, new bool[graph.Vertices], graph.Vertices, 0, Convert.ToInt32(txt_bruteForce.Text));
            if (algResult)
            {
                if(graph.progress <= 100)
                {
                    pb.Value = graph.progress;
                    graph.progress = 0;
                }
                else
                {
                    pb.Value = 100;
                    graph.progress = 0;
                }
                MessageBox.Show("True");
            }
            else
            {
                pb.Value = 0;
                graph.progress = 0;
                MessageBox.Show("False");
            }

        }

        private void btn_coloringGraph_Click(object sender, EventArgs e)
        {
            try
            {
                graph.kernelization(Convert.ToInt32(txt_KEdges.Text));
                graph.updateColorGraphToFile();
                displayGraph();
            }
            catch { MessageBox.Show("Write k in textbox"); }
        }

        private void btn_pendentPlus_Click(object sender, EventArgs e)
        {
            graph.pendants_increment();
            graph.updateColorGraphToFile();
            graph.kernelization(Convert.ToInt32(txt_KEdges.Text));
            displayGraph();

        }

        private void btn_TopPlus_Click(object sender, EventArgs e)
        {
            graph.top_increment(Convert.ToInt32(txt_KEdges.Text));
            graph.updateColorGraphToFile();
            graph.kernelization(Convert.ToInt32(txt_KEdges.Text));
            displayGraph();
        }

        private void btn_pendentMinus_Click(object sender, EventArgs e)
        {
            graph.pendants_decrement();
            graph.updateColorGraphToFile();
            graph.kernelization(Convert.ToInt32(txt_KEdges.Text));
            displayGraph();
        }

        private void btn_Top_plus_Click(object sender, EventArgs e)
        {
            graph.top_decrement(Convert.ToInt32(txt_KEdges.Text));
            graph.updateColorGraphToFile();
            graph.kernelization(Convert.ToInt32(txt_KEdges.Text));
            displayGraph();
        }

        private void btn_enchanced_brute_force_Click(object sender, EventArgs e)
        {
            int[] coverInitial = preprocess();
            graph.IsOkVertex = true;

            bool algResult = algorithm.enhanced_brute_force(graph, coverInitial, graph.Vertices, 0, Convert.ToInt32(txt_bruteForce.Text));
            if (algResult)
            {
                if (graph.progress <= 100)
                {
                    pb.Value = graph.progress;
                    graph.progress = 0;
                }
                else
                {
                    pb.Value = 100;
                    graph.progress = 0;
                }
                MessageBox.Show("True");
            }
            else
            {
                pb.Value = 0;
                graph.progress = 0;
                MessageBox.Show("False");
            }
        }


        private int[] preprocess()
        {
            graph.kernelization(Convert.ToInt32(txt_bruteForce.Text));
            int[] cover = new int[graph.Vertices];

            foreach (int top in graph.Tops)
            {
                cover[top] = 2;
            }

            foreach (int pendant in graph.Pendants)
            {
                cover[graph.get_adjacent_list()[pendant][0]] = 2;
            }

            return cover;
        }

        private void btn_approximation_Click(object sender, EventArgs e)
        {
            //prints size of vertex cover
            int size_covered_vertices = algorithm.ValidateAprox(graph, graph.Vertices);
            MessageBox.Show($"The graph can be covered with {size_covered_vertices} vertices");
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            try
            {
                var process = new Process();
                process.StartInfo = new ProcessStartInfo(@"graph.png")
                {
                    UseShellExecute = true
                };
                process.Start();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_view_dot_file_Click(object sender, EventArgs e)
        {
            try
            {
                var process = new Process();
                process.StartInfo = new ProcessStartInfo(@"graph.dot")
                {
                    UseShellExecute = true
                };
                process.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
