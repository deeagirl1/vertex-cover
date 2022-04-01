
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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Graph)).BeginInit();
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
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 138);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Graph";
            // 
            // btn_ViewGraph
            // 
            this.btn_ViewGraph.Location = new System.Drawing.Point(211, 100);
            this.btn_ViewGraph.Name = "btn_ViewGraph";
            this.btn_ViewGraph.Size = new System.Drawing.Size(116, 23);
            this.btn_ViewGraph.TabIndex = 6;
            this.btn_ViewGraph.Text = "View picture";
            this.btn_ViewGraph.UseVisualStyleBackColor = true;
            this.btn_ViewGraph.Click += new System.EventHandler(this.btn_ViewGraph_Click);
            // 
            // btn_ConnectGraph
            // 
            this.btn_ConnectGraph.Location = new System.Drawing.Point(211, 67);
            this.btn_ConnectGraph.Name = "btn_ConnectGraph";
            this.btn_ConnectGraph.Size = new System.Drawing.Size(116, 23);
            this.btn_ConnectGraph.TabIndex = 5;
            this.btn_ConnectGraph.Text = "Connect";
            this.btn_ConnectGraph.UseVisualStyleBackColor = true;
            this.btn_ConnectGraph.Click += new System.EventHandler(this.btn_ConnectGraph_Click);
            // 
            // btn_CreateGraph
            // 
            this.btn_CreateGraph.Location = new System.Drawing.Point(211, 34);
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
            this.pb_Graph.Size = new System.Drawing.Size(624, 562);
            this.pb_Graph.TabIndex = 1;
            this.pb_Graph.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 615);
            this.Controls.Add(this.pb_Graph);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Vertex Cover";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Graph)).EndInit();
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
    }
}

