﻿
namespace VertexCover
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_ViewGraph = new System.Windows.Forms.Button();
            this.btn_ConnectGraph = new System.Windows.Forms.Button();
            this.btn_CreateGraph = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Probability = new System.Windows.Forms.TextBox();
            this.tb_NrOfVertices = new System.Windows.Forms.TextBox();
            this.pb_Graph = new System.Windows.Forms.PictureBox();
            this.gb_bruteForceSearch = new System.Windows.Forms.GroupBox();
            this.lbl_result = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_bruteForce = new System.Windows.Forms.Button();
            this.txt_bruteForce = new System.Windows.Forms.TextBox();
            this.pb = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Graph)).BeginInit();
            this.gb_bruteForceSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_ViewGraph);
            this.groupBox1.Controls.Add(this.btn_ConnectGraph);
            this.groupBox1.Controls.Add(this.btn_CreateGraph);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_Probability);
            this.groupBox1.Controls.Add(this.tb_NrOfVertices);
            this.groupBox1.Location = new System.Drawing.Point(14, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(405, 184);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Graph";
            // 
            // btn_ViewGraph
            // 
            this.btn_ViewGraph.Location = new System.Drawing.Point(241, 133);
            this.btn_ViewGraph.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_ViewGraph.Name = "btn_ViewGraph";
            this.btn_ViewGraph.Size = new System.Drawing.Size(133, 31);
            this.btn_ViewGraph.TabIndex = 6;
            this.btn_ViewGraph.Text = "View picture";
            this.btn_ViewGraph.UseVisualStyleBackColor = true;
            this.btn_ViewGraph.Click += new System.EventHandler(this.btn_ViewGraph_Click);
            // 
            // btn_ConnectGraph
            // 
            this.btn_ConnectGraph.Location = new System.Drawing.Point(241, 89);
            this.btn_ConnectGraph.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_ConnectGraph.Name = "btn_ConnectGraph";
            this.btn_ConnectGraph.Size = new System.Drawing.Size(133, 31);
            this.btn_ConnectGraph.TabIndex = 5;
            this.btn_ConnectGraph.Text = "Connect";
            this.btn_ConnectGraph.UseVisualStyleBackColor = true;
            this.btn_ConnectGraph.Click += new System.EventHandler(this.btn_ConnectGraph_Click);
            // 
            // btn_CreateGraph
            // 
            this.btn_CreateGraph.Location = new System.Drawing.Point(241, 45);
            this.btn_CreateGraph.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_CreateGraph.Name = "btn_CreateGraph";
            this.btn_CreateGraph.Size = new System.Drawing.Size(133, 31);
            this.btn_CreateGraph.TabIndex = 4;
            this.btn_CreateGraph.Text = "Create ";
            this.btn_CreateGraph.UseVisualStyleBackColor = true;
            this.btn_CreateGraph.Click += new System.EventHandler(this.btn_CreateGraph_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Probability";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number of vertices";
            // 
            // tb_Probability
            // 
            this.tb_Probability.Location = new System.Drawing.Point(24, 133);
            this.tb_Probability.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_Probability.Name = "tb_Probability";
            this.tb_Probability.Size = new System.Drawing.Size(135, 27);
            this.tb_Probability.TabIndex = 1;
            // 
            // tb_NrOfVertices
            // 
            this.tb_NrOfVertices.Location = new System.Drawing.Point(24, 77);
            this.tb_NrOfVertices.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_NrOfVertices.Name = "tb_NrOfVertices";
            this.tb_NrOfVertices.Size = new System.Drawing.Size(135, 27);
            this.tb_NrOfVertices.TabIndex = 0;
            // 
            // pb_Graph
            // 
            this.pb_Graph.Location = new System.Drawing.Point(425, 28);
            this.pb_Graph.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pb_Graph.Name = "pb_Graph";
            this.pb_Graph.Size = new System.Drawing.Size(713, 749);
            this.pb_Graph.TabIndex = 1;
            this.pb_Graph.TabStop = false;
            // 
            // gb_bruteForceSearch
            // 
            this.gb_bruteForceSearch.Controls.Add(this.lbl_result);
            this.gb_bruteForceSearch.Controls.Add(this.label4);
            this.gb_bruteForceSearch.Controls.Add(this.label3);
            this.gb_bruteForceSearch.Controls.Add(this.btn_bruteForce);
            this.gb_bruteForceSearch.Controls.Add(this.txt_bruteForce);
            this.gb_bruteForceSearch.Location = new System.Drawing.Point(14, 228);
            this.gb_bruteForceSearch.Name = "gb_bruteForceSearch";
            this.gb_bruteForceSearch.Size = new System.Drawing.Size(389, 160);
            this.gb_bruteForceSearch.TabIndex = 2;
            this.gb_bruteForceSearch.TabStop = false;
            this.gb_bruteForceSearch.Text = "Brute Force";
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Location = new System.Drawing.Point(86, 122);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(0, 20);
            this.lbl_result.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Result: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "The size K of the vertex cover:";
            // 
            // btn_bruteForce
            // 
            this.btn_bruteForce.Location = new System.Drawing.Point(226, 63);
            this.btn_bruteForce.Name = "btn_bruteForce";
            this.btn_bruteForce.Size = new System.Drawing.Size(133, 31);
            this.btn_bruteForce.TabIndex = 1;
            this.btn_bruteForce.Text = "Brute Force";
            this.btn_bruteForce.UseVisualStyleBackColor = true;
            this.btn_bruteForce.Click += new System.EventHandler(this.btn_bruteForce_Click);
            // 
            // txt_bruteForce
            // 
            this.txt_bruteForce.Location = new System.Drawing.Point(60, 65);
            this.txt_bruteForce.Name = "txt_bruteForce";
            this.txt_bruteForce.Size = new System.Drawing.Size(135, 27);
            this.txt_bruteForce.TabIndex = 0;
            // 
            // pb
            // 
            this.pb.Location = new System.Drawing.Point(14, 394);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(389, 40);
            this.pb.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 820);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.gb_bruteForceSearch);
            this.Controls.Add(this.pb_Graph);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Vertex Cover";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Graph)).EndInit();
            this.gb_bruteForceSearch.ResumeLayout(false);
            this.gb_bruteForceSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_ViewGraph;
        private System.Windows.Forms.Button btn_ConnectGraph;
        private System.Windows.Forms.Button btn_CreateGraph;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Probability;
        private System.Windows.Forms.TextBox tb_NrOfVertices;
        private System.Windows.Forms.PictureBox pb_Graph;
        private System.Windows.Forms.GroupBox gb_bruteForceSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_bruteForce;
        private System.Windows.Forms.TextBox txt_bruteForce;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.ProgressBar pb;
    }
}

