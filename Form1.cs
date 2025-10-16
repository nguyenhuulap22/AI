using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace EulerDemo
{
    public partial class Form1 : Form
    {
        private readonly Graph graph = new Graph();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddVertex_Click(object sender, EventArgs e)
        {
            string v = txtVertex.Text.Trim();
            if (graph.AddVertex(v))
            {
                lstVertices.Items.Add(v);
                txtVertex.Clear();
            }
            else
            {
                MessageBox.Show(" Đỉnh không hợp lệ hoặc đã tồn tại!");
            }
        }

        private void btnRemoveVertex_Click(object sender, EventArgs e)
        {
            if (lstVertices.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn 1 đỉnh để xóa!");
                return;
            }

            string v = lstVertices.SelectedItem.ToString();
            graph.RemoveVertex(v);
            lstVertices.Items.Remove(v);

            // Cập nhật danh sách cạnh
            lstEdges.Items.Clear();
            foreach (var (u, w) in graph.Edges)
                lstEdges.Items.Add($"{u}-{w}");

            MessageBox.Show($" Đã xóa đỉnh {v} và các cạnh liên quan!");
        }

        private void btnAddEdge_Click(object sender, EventArgs e)
        {
            string input = txtEdge.Text.Trim();
            if (string.IsNullOrEmpty(input) || !input.Contains('-'))
            {
                MessageBox.Show("Nhập đúng định dạng: A-B");
                return;
            }

            var parts = input.Split('-');
            string u = parts[0].Trim();
            string v = parts[1].Trim();

            if (graph.AddEdge(u, v))
            {
                lstEdges.Items.Add($"{u}-{v}");
                txtEdge.Clear();
            }
            else
            {
                MessageBox.Show(" Hai đỉnh phải tồn tại trước khi thêm cạnh!");
            }
        }

        private void btnRemoveEdge_Click(object sender, EventArgs e)
        {
            if (lstEdges.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn 1 cạnh để xóa!");
                return;
            }

            string selected = lstEdges.SelectedItem.ToString();
            var parts = selected.Split('-');
            string u = parts[0].Trim();
            string v = parts[1].Trim();

            if (graph.RemoveEdge(u, v))
            {
                lstEdges.Items.RemoveAt(lstEdges.SelectedIndex);
                MessageBox.Show($"Đã xóa cạnh {u}-{v}");
            }
        }

        private void btnEuler_Click(object sender, EventArgs e)
        {
            txtResult.Text = graph.FindEuler();
        }

        private void lblResult_Click(object sender, EventArgs e)
        {
        }
    }
}