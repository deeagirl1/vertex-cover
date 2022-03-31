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
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ViewGraph_Click(object sender, EventArgs e)
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
            //graph.add_edges_on_probability(prob);
            //graph.connectedComponents();
            //graph.write_graph_to_file();

        }

        private void btn_ConnectGraph_Click(object sender, EventArgs e)
        {
            graph.connect();
            graph.connectedComponents();
            graph.write_graph_to_file();
        }
    }
}
