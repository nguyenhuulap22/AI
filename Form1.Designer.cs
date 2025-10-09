namespace EulerDemo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblVertex = new System.Windows.Forms.Label();
            this.txtVertex = new System.Windows.Forms.TextBox();
            this.btnAddVertex = new System.Windows.Forms.Button();
            this.btnRemoveVertex = new System.Windows.Forms.Button();
            this.lstVertices = new System.Windows.Forms.ListBox();
            this.lblEdge = new System.Windows.Forms.Label();
            this.txtEdge = new System.Windows.Forms.TextBox();
            this.btnAddEdge = new System.Windows.Forms.Button();
            this.btnRemoveEdge = new System.Windows.Forms.Button();
            this.lstEdges = new System.Windows.Forms.ListBox();
            this.btnEuler = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblVertex
            // 
            this.lblVertex.AutoSize = true;
            this.lblVertex.Location = new System.Drawing.Point(13, 13);
            this.lblVertex.Name = "lblVertex";
            this.lblVertex.Size = new System.Drawing.Size(71, 16);
            this.lblVertex.TabIndex = 0;
            this.lblVertex.Text = "Nhập đỉnh:";
            // 
            // txtVertex
            // 
            this.txtVertex.Location = new System.Drawing.Point(90, 9);
            this.txtVertex.Name = "txtVertex";
            this.txtVertex.Size = new System.Drawing.Size(100, 22);
            this.txtVertex.TabIndex = 1;
            // 
            // btnAddVertex
            // 
            this.btnAddVertex.Location = new System.Drawing.Point(231, 6);
            this.btnAddVertex.Name = "btnAddVertex";
            this.btnAddVertex.Size = new System.Drawing.Size(83, 29);
            this.btnAddVertex.TabIndex = 2;
            this.btnAddVertex.Text = "Thêm đỉnh";
            this.btnAddVertex.UseVisualStyleBackColor = true;
            this.btnAddVertex.Click += new System.EventHandler(this.btnAddVertex_Click);
            // 
            // btnRemoveVertex
            // 
            this.btnRemoveVertex.Location = new System.Drawing.Point(361, 5);
            this.btnRemoveVertex.Name = "btnRemoveVertex";
            this.btnRemoveVertex.Size = new System.Drawing.Size(81, 30);
            this.btnRemoveVertex.TabIndex = 3;
            this.btnRemoveVertex.Text = "Xóa đỉnh";
            this.btnRemoveVertex.UseVisualStyleBackColor = true;
            this.btnRemoveVertex.Click += new System.EventHandler(this.btnRemoveVertex_Click);
            // 
            // lstVertices
            // 
            this.lstVertices.FormattingEnabled = true;
            this.lstVertices.ItemHeight = 16;
            this.lstVertices.Location = new System.Drawing.Point(16, 53);
            this.lstVertices.Name = "lstVertices";
            this.lstVertices.Size = new System.Drawing.Size(443, 116);
            this.lstVertices.TabIndex = 4;
            // 
            // lblEdge
            // 
            this.lblEdge.AutoSize = true;
            this.lblEdge.Location = new System.Drawing.Point(16, 207);
            this.lblEdge.Name = "lblEdge";
            this.lblEdge.Size = new System.Drawing.Size(75, 16);
            this.lblEdge.TabIndex = 5;
            this.lblEdge.Text = "Nhập cạnh:";
            // 
            // txtEdge
            // 
            this.txtEdge.Location = new System.Drawing.Point(97, 204);
            this.txtEdge.Name = "txtEdge";
            this.txtEdge.Size = new System.Drawing.Size(100, 22);
            this.txtEdge.TabIndex = 6;
            // 
            // btnAddEdge
            // 
            this.btnAddEdge.Location = new System.Drawing.Point(231, 205);
            this.btnAddEdge.Name = "btnAddEdge";
            this.btnAddEdge.Size = new System.Drawing.Size(83, 30);
            this.btnAddEdge.TabIndex = 7;
            this.btnAddEdge.Text = "Thêm cạnh";
            this.btnAddEdge.UseVisualStyleBackColor = true;
            this.btnAddEdge.Click += new System.EventHandler(this.btnAddEdge_Click);
            // 
            // btnRemoveEdge
            // 
            this.btnRemoveEdge.Location = new System.Drawing.Point(361, 205);
            this.btnRemoveEdge.Name = "btnRemoveEdge";
            this.btnRemoveEdge.Size = new System.Drawing.Size(81, 29);
            this.btnRemoveEdge.TabIndex = 8;
            this.btnRemoveEdge.Text = "Xóa cạnh";
            this.btnRemoveEdge.UseVisualStyleBackColor = true;
            this.btnRemoveEdge.Click += new System.EventHandler(this.btnRemoveEdge_Click);
            // 
            // lstEdges
            // 
            this.lstEdges.FormattingEnabled = true;
            this.lstEdges.ItemHeight = 16;
            this.lstEdges.Location = new System.Drawing.Point(19, 248);
            this.lstEdges.Name = "lstEdges";
            this.lstEdges.Size = new System.Drawing.Size(440, 116);
            this.lstEdges.TabIndex = 9;
            // 
            // btnEuler
            // 
            this.btnEuler.Location = new System.Drawing.Point(563, 53);
            this.btnEuler.Name = "btnEuler";
            this.btnEuler.Size = new System.Drawing.Size(85, 29);
            this.btnEuler.TabIndex = 10;
            this.btnEuler.Text = "Tìm Euler";
            this.btnEuler.UseVisualStyleBackColor = true;
            this.btnEuler.Click += new System.EventHandler(this.btnEuler_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(560, 104);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(55, 16);
            this.lblResult.TabIndex = 11;
            this.lblResult.Text = "Kết quả:";
            this.lblResult.Click += new System.EventHandler(this.lblResult_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(563, 123);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(225, 46);
            this.txtResult.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnEuler);
            this.Controls.Add(this.lstEdges);
            this.Controls.Add(this.btnRemoveEdge);
            this.Controls.Add(this.btnAddEdge);
            this.Controls.Add(this.txtEdge);
            this.Controls.Add(this.lblEdge);
            this.Controls.Add(this.lstVertices);
            this.Controls.Add(this.btnRemoveVertex);
            this.Controls.Add(this.btnAddVertex);
            this.Controls.Add(this.txtVertex);
            this.Controls.Add(this.lblVertex);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVertex;
        private System.Windows.Forms.TextBox txtVertex;
        private System.Windows.Forms.Button btnAddVertex;
        private System.Windows.Forms.Button btnRemoveVertex;
        private System.Windows.Forms.ListBox lstVertices;
        private System.Windows.Forms.Label lblEdge;
        private System.Windows.Forms.TextBox txtEdge;
        private System.Windows.Forms.Button btnAddEdge;
        private System.Windows.Forms.Button btnRemoveEdge;
        private System.Windows.Forms.ListBox lstEdges;
        private System.Windows.Forms.Button btnEuler;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtResult;
    }
}

