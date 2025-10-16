using System;
using System.Collections.Generic;
using System.Linq;

namespace EulerDemo
{
    internal class Graph
    {
        private readonly HashSet<string> vertices = new HashSet<string>();
        private readonly List<(string u, string v)> edges = new List<(string u, string v)>();

        public IReadOnlyCollection<string> Vertices => vertices;
        public IReadOnlyList<(string u, string v)> Edges => edges;

        // ===== THÊM / XÓA ĐỈNH =====
        public bool AddVertex(string name)
        {
            name = name.Trim();
            if (string.IsNullOrEmpty(name)) return false;
            return vertices.Add(name);
        }

        public bool RemoveVertex(string name)
        {
            if (!vertices.Remove(name))
                return false;

            edges.RemoveAll(e => e.u == name || e.v == name);
            return true;
        }

        // ===== THÊM / XÓA CẠNH =====
        public bool AddEdge(string u, string v)
        {
            u = u.Trim(); v = v.Trim();

            if (!vertices.Contains(u) || !vertices.Contains(v))
                return false;

            edges.Add((u, v));
            return true;
        }

        public bool RemoveEdge(string u, string v)
        {
            var edge = edges.FirstOrDefault(e =>
                (e.u == u && e.v == v) || (e.u == v && e.v == u));
            if (edge.Equals(default((string, string)))) return false;

            edges.Remove(edge);
            return true;
        }

        // ===== TÌM ĐƯỜNG / CHU TRÌNH EULER =====
        public string FindEuler()
        {
            if (edges.Count == 0)
                return "⚠️ Đồ thị rỗng — không có cạnh.";

            var g = new Dictionary<string, List<string>>();
            foreach (var v in vertices)
                g[v] = new List<string>();
            foreach (var (u, v) in edges)
            {
                g[u].Add(v);
                g[v].Add(u);
            }

            var odd = g.Where(x => x.Value.Count % 2 == 1).Select(x => x.Key).ToList();

            string start;
            string type;
            if (odd.Count == 0)
            {
                start = g.Keys.First();
                type = "chu trình Euler";
            }
            else if (odd.Count == 2)
            {
                start = odd[0];
                type = "đường Euler";
            }
            else
            {
                return "❌ Không tồn tại đường hoặc chu trình Euler (số đỉnh bậc lẻ > 2).";
            }

            var path = new List<string>();
            var stack = new Stack<string>();
            var local = g.ToDictionary(k => k.Key, v => new List<string>(v.Value));
            stack.Push(start);

            while (stack.Count > 0)
            {
                string v = stack.Peek();
                if (local[v].Count > 0)
                {
                    string u = local[v][0];
                    local[v].Remove(u);
                    local[u].Remove(v);
                    stack.Push(u);
                }
                else
                {
                    path.Add(v);
                    stack.Pop();
                }
            }

            path.Reverse();

            string result = $"✅ Tồn tại {type.ToUpper()}:\r\n" + string.Join(" → ", path);
            if (type == "chu trình Euler" && path.First() == path.Last())
                result += $"\r\n🔁 Chu trình khép kín tại đỉnh {path.First()}.";

            return result;
        }
    }
}
