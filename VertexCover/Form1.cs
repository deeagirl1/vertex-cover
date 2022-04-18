using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
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

        //private void btn_ViewGraph_Click(object sender, EventArgs e)
        //{
        //    Process dot = new Process();
        //    dot.StartInfo.FileName = "dot.exe";
        //    dot.StartInfo.Arguments = "-Tpng graph.dot -o graph.png";
        //    dot.Start();
        //    dot.WaitForExit();
        //    pb_Graph.ImageLocation = "graph.png";
        //}

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
            bool algResult = algorithm.Validate(graph, new bool[graph.Vertices], graph.Vertices, 0, Convert.ToInt32(txt_bruteForce.Text));
            if (algResult)
            {
                lbl_result.Text = "TRUE";
                lbl_result.ForeColor = Color.Green;
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
              

            }
            else
            {
                lbl_result.Text = "FALSE";
                lbl_result.ForeColor = Color.Red;
                pb.Value = 0;
                graph.progress = 0;
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
            graph.PendantIncrement();
            graph.updateColorGraphToFile();
            graph.kernelization(Convert.ToInt32(txt_KEdges.Text));
            displayGraph();

        }

        private void btn_TopPlus_Click(object sender, EventArgs e)
        {
            graph.TopIncrement(Convert.ToInt32(txt_KEdges.Text));
            graph.updateColorGraphToFile();
            graph.kernelization(Convert.ToInt32(txt_KEdges.Text));
            displayGraph();
        }

        private void btn_pendentMinus_Click(object sender, EventArgs e)
        {
            graph.PendantDecrement();
            graph.updateColorGraphToFile();
            graph.kernelization(Convert.ToInt32(txt_KEdges.Text));
            displayGraph();
        }

        private void btn_Top_plus_Click(object sender, EventArgs e)
        {
            graph.TopDecrement(Convert.ToInt32(txt_KEdges.Text));
            graph.updateColorGraphToFile();
            graph.kernelization(Convert.ToInt32(txt_KEdges.Text));
            displayGraph();
        }
    }
}
