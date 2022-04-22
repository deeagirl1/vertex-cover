
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
            this.btn_ConnectGraph = new System.Windows.Forms.Button();
            this.btn_CreateGraph = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Probability = new System.Windows.Forms.TextBox();
            this.tb_NrOfVertices = new System.Windows.Forms.TextBox();
            this.pb_Graph = new System.Windows.Forms.PictureBox();
            this.gb_bruteForceSearch = new System.Windows.Forms.GroupBox();
            this.btn_enchanced_brute_force = new System.Windows.Forms.Button();
            this.lbl_result = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_bruteForce = new System.Windows.Forms.Button();
            this.txt_bruteForce = new System.Windows.Forms.TextBox();
            this.pb = new System.Windows.Forms.ProgressBar();
            this.gb_kernelization = new System.Windows.Forms.GroupBox();
            this.btn_TopPlus = new System.Windows.Forms.Button();
            this.btn_Top_plus = new System.Windows.Forms.Button();
            this.btn_pendentMinus = new System.Windows.Forms.Button();
            this.btn_pendentPlus = new System.Windows.Forms.Button();
            this.btn_coloringGraph = new System.Windows.Forms.Button();
            this.lbl_Tops = new System.Windows.Forms.Label();
            this.txt_KEdges = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Graph)).BeginInit();
            this.gb_bruteForceSearch.SuspendLayout();
            this.gb_kernelization.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_ConnectGraph);
            this.groupBox1.Controls.Add(this.btn_CreateGraph);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_Probability);
            this.groupBox1.Controls.Add(this.tb_NrOfVertices);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 138);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Graph";
            // 
            // btn_ConnectGraph
            // 
            this.btn_ConnectGraph.Location = new System.Drawing.Point(211, 84);
            this.btn_ConnectGraph.Name = "btn_ConnectGraph";
            this.btn_ConnectGraph.Size = new System.Drawing.Size(116, 23);
            this.btn_ConnectGraph.TabIndex = 5;
            this.btn_ConnectGraph.Text = "Connect";
            this.btn_ConnectGraph.UseVisualStyleBackColor = true;
            this.btn_ConnectGraph.Click += new System.EventHandler(this.btn_ConnectGraph_Click);
            // 
            // btn_CreateGraph
            // 
            this.btn_CreateGraph.Location = new System.Drawing.Point(211, 55);
            this.btn_CreateGraph.Name = "btn_CreateGraph";
            this.btn_CreateGraph.Size = new System.Drawing.Size(116, 23);
            this.btn_CreateGraph.TabIndex = 4;
            this.btn_CreateGraph.Text = "Create ";
            this.btn_CreateGraph.UseVisualStyleBackColor = true;
            this.btn_CreateGraph.Click += new System.EventHandler(this.btn_CreateGraph_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Probability";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number of vertices";
            // 
            // tb_Probability
            // 
            this.tb_Probability.Location = new System.Drawing.Point(21, 100);
            this.tb_Probability.Name = "tb_Probability";
            this.tb_Probability.Size = new System.Drawing.Size(119, 23);
            this.tb_Probability.TabIndex = 1;
            // 
            // tb_NrOfVertices
            // 
            this.tb_NrOfVertices.Location = new System.Drawing.Point(21, 58);
            this.tb_NrOfVertices.Name = "tb_NrOfVertices";
            this.tb_NrOfVertices.Size = new System.Drawing.Size(119, 23);
            this.tb_NrOfVertices.TabIndex = 0;
            // 
            // pb_Graph
            // 
            this.pb_Graph.Location = new System.Drawing.Point(372, 21);
            this.pb_Graph.Name = "pb_Graph";
            this.pb_Graph.Size = new System.Drawing.Size(624, 254);
            this.pb_Graph.TabIndex = 1;
            this.pb_Graph.TabStop = false;
            // 
            // gb_bruteForceSearch
            // 
            this.gb_bruteForceSearch.Controls.Add(this.btn_enchanced_brute_force);
            this.gb_bruteForceSearch.Controls.Add(this.lbl_result);
            this.gb_bruteForceSearch.Controls.Add(this.label4);
            this.gb_bruteForceSearch.Controls.Add(this.label3);
            this.gb_bruteForceSearch.Controls.Add(this.btn_bruteForce);
            this.gb_bruteForceSearch.Controls.Add(this.txt_bruteForce);
            this.gb_bruteForceSearch.Location = new System.Drawing.Point(12, 155);
            this.gb_bruteForceSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_bruteForceSearch.Name = "gb_bruteForceSearch";
            this.gb_bruteForceSearch.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_bruteForceSearch.Size = new System.Drawing.Size(340, 120);
            this.gb_bruteForceSearch.TabIndex = 2;
            this.gb_bruteForceSearch.TabStop = false;
            this.gb_bruteForceSearch.Text = "Brute Force";
            // 
            // btn_enchanced_brute_force
            // 
            this.btn_enchanced_brute_force.Location = new System.Drawing.Point(164, 84);
            this.btn_enchanced_brute_force.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_enchanced_brute_force.Name = "btn_enchanced_brute_force";
            this.btn_enchanced_brute_force.Size = new System.Drawing.Size(147, 23);
            this.btn_enchanced_brute_force.TabIndex = 6;
            this.btn_enchanced_brute_force.Text = "Enchaned Brute Force";
            this.btn_enchanced_brute_force.UseVisualStyleBackColor = true;
            this.btn_enchanced_brute_force.Click += new System.EventHandler(this.btn_enchanced_brute_force_Click);
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Location = new System.Drawing.Point(75, 92);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(0, 15);
            this.lbl_result.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Result: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "The size K of the vertex cover:";
            // 
            // btn_bruteForce
            // 
            this.btn_bruteForce.Location = new System.Drawing.Point(180, 49);
            this.btn_bruteForce.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_bruteForce.Name = "btn_bruteForce";
            this.btn_bruteForce.Size = new System.Drawing.Size(116, 23);
            this.btn_bruteForce.TabIndex = 1;
            this.btn_bruteForce.Text = "Brute Force";
            this.btn_bruteForce.UseVisualStyleBackColor = true;
            this.btn_bruteForce.Click += new System.EventHandler(this.btn_bruteForce_Click);
            // 
            // txt_bruteForce
            // 
            this.txt_bruteForce.Location = new System.Drawing.Point(21, 50);
            this.txt_bruteForce.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_bruteForce.Name = "txt_bruteForce";
            this.txt_bruteForce.Size = new System.Drawing.Size(119, 23);
            this.txt_bruteForce.TabIndex = 0;
            // 
            // pb
            // 
            this.pb.Location = new System.Drawing.Point(12, 280);
            this.pb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(340, 30);
            this.pb.TabIndex = 3;
            // 
            // gb_kernelization
            // 
            this.gb_kernelization.Controls.Add(this.btn_TopPlus);
            this.gb_kernelization.Controls.Add(this.btn_Top_plus);
            this.gb_kernelization.Controls.Add(this.btn_pendentMinus);
            this.gb_kernelization.Controls.Add(this.btn_pendentPlus);
            this.gb_kernelization.Controls.Add(this.btn_coloringGraph);
            this.gb_kernelization.Controls.Add(this.lbl_Tops);
            this.gb_kernelization.Controls.Add(this.txt_KEdges);
            this.gb_kernelization.Location = new System.Drawing.Point(12, 321);
            this.gb_kernelization.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_kernelization.Name = "gb_kernelization";
            this.gb_kernelization.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_kernelization.Size = new System.Drawing.Size(340, 167);
            this.gb_kernelization.TabIndex = 4;
            this.gb_kernelization.TabStop = false;
            this.gb_kernelization.Text = "Kernelization";
            // 
            // btn_TopPlus
            // 
            this.btn_TopPlus.Location = new System.Drawing.Point(90, 75);
            this.btn_TopPlus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_TopPlus.Name = "btn_TopPlus";
            this.btn_TopPlus.Size = new System.Drawing.Size(49, 23);
            this.btn_TopPlus.TabIndex = 11;
            this.btn_TopPlus.Text = "T++";
            this.btn_TopPlus.UseVisualStyleBackColor = true;
            this.btn_TopPlus.Click += new System.EventHandler(this.btn_TopPlus_Click);
            // 
            // btn_Top_plus
            // 
            this.btn_Top_plus.Location = new System.Drawing.Point(90, 103);
            this.btn_Top_plus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Top_plus.Name = "btn_Top_plus";
            this.btn_Top_plus.Size = new System.Drawing.Size(49, 23);
            this.btn_Top_plus.TabIndex = 10;
            this.btn_Top_plus.Text = "T--";
            this.btn_Top_plus.UseVisualStyleBackColor = true;
            this.btn_Top_plus.Click += new System.EventHandler(this.btn_Top_plus_Click);
            // 
            // btn_pendentMinus
            // 
            this.btn_pendentMinus.Location = new System.Drawing.Point(21, 103);
            this.btn_pendentMinus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_pendentMinus.Name = "btn_pendentMinus";
            this.btn_pendentMinus.Size = new System.Drawing.Size(49, 23);
            this.btn_pendentMinus.TabIndex = 9;
            this.btn_pendentMinus.Text = "P--";
            this.btn_pendentMinus.UseVisualStyleBackColor = true;
            this.btn_pendentMinus.Click += new System.EventHandler(this.btn_pendentMinus_Click);
            // 
            // btn_pendentPlus
            // 
            this.btn_pendentPlus.Location = new System.Drawing.Point(21, 75);
            this.btn_pendentPlus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_pendentPlus.Name = "btn_pendentPlus";
            this.btn_pendentPlus.Size = new System.Drawing.Size(49, 23);
            this.btn_pendentPlus.TabIndex = 8;
            this.btn_pendentPlus.Text = "P++";
            this.btn_pendentPlus.UseVisualStyleBackColor = true;
            this.btn_pendentPlus.Click += new System.EventHandler(this.btn_pendentPlus_Click);
            // 
            // btn_coloringGraph
            // 
            this.btn_coloringGraph.Location = new System.Drawing.Point(180, 67);
            this.btn_coloringGraph.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_coloringGraph.Name = "btn_coloringGraph";
            this.btn_coloringGraph.Size = new System.Drawing.Size(116, 39);
            this.btn_coloringGraph.TabIndex = 6;
            this.btn_coloringGraph.Text = "Kernelization";
            this.btn_coloringGraph.UseVisualStyleBackColor = true;
            this.btn_coloringGraph.Click += new System.EventHandler(this.btn_coloringGraph_Click);
            // 
            // lbl_Tops
            // 
            this.lbl_Tops.AutoSize = true;
            this.lbl_Tops.Location = new System.Drawing.Point(21, 33);
            this.lbl_Tops.Name = "lbl_Tops";
            this.lbl_Tops.Size = new System.Drawing.Size(51, 15);
            this.lbl_Tops.TabIndex = 7;
            this.lbl_Tops.Text = "K Edges:";
            // 
            // txt_KEdges
            // 
            this.txt_KEdges.Location = new System.Drawing.Point(21, 50);
            this.txt_KEdges.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_KEdges.Name = "txt_KEdges";
            this.txt_KEdges.Size = new System.Drawing.Size(119, 23);
            this.txt_KEdges.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 615);
            this.Controls.Add(this.gb_kernelization);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.gb_bruteForceSearch);
            this.Controls.Add(this.pb_Graph);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Vertex Cover";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Graph)).EndInit();
            this.gb_bruteForceSearch.ResumeLayout(false);
            this.gb_bruteForceSearch.PerformLayout();
            this.gb_kernelization.ResumeLayout(false);
            this.gb_kernelization.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.GroupBox gb_kernelization;
        private System.Windows.Forms.Label lbl_Tops;
        private System.Windows.Forms.TextBox txt_KEdges;
        private System.Windows.Forms.Button btn_coloringGraph;
        private System.Windows.Forms.Button btn_TopPlus;
        private System.Windows.Forms.Button btn_Top_plus;
        private System.Windows.Forms.Button btn_pendentMinus;
        private System.Windows.Forms.Button btn_pendentPlus;
        private System.Windows.Forms.Button btn_enchanced_brute_force;
    }
}

