using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _49
{
    class Node
    {
        public int X;
        public int Y;
        public int R;
        public int Inf;
        public int Number;
        public bool IsDrawn;
        public List<Node> neighbors = new List<Node>();
        public List<Edge> edges = new List<Edge>();
        public bool IsCheck;
        public bool IsVisit;
    }
    class Edge
    {
        public int Weight;
        public Node LeftNode;
        public Node RightNode;
        public bool IsDrawn;
    }
    class Graph
    {
        List<Node> Nodes = new List<Node>();
        List<Edge> Edges = new List<Edge>();

        Pen pen = new Pen(Color.Black, 3);
        Font MyFont = new Font("Arial", 12);

        int i = 0;

        public int GetNodesListCount()
        {
            return Nodes.Count;
        }

        public int GetEdgesListCount()
        {
            return Edges.Count;
        }

        public void AddNode(int x, int y, int r, int inf, Graphics g)
        {
            Node p = new Node();
            p.X = x;
            p.Y = y;
            p.Inf = inf;
            p.R = r;
            p.Number = i;
            i++;
            Nodes.Add(p);
        }
        public void DelNode(int x, int y)
        {
            Node p = FindByXY(x, y);
            if (p == null) return;

            Nodes.Remove(p);
            DelPairOfEdges();
        }

        private Node NodeForMove;

        public void MoveNode(int x, int y)
        {
            if (NodeForMove == null)
            {
                NodeForMove = FindByXY(x, y);
                return;
            }
            else
            {
                NodeForMove.X = x;
                NodeForMove.Y = y;
                NodeForMove = null;
            }
        }
        public void DelCheck()
        {
            foreach (Node p in Nodes)
                p.IsCheck = false;
        }

        public Node FindByXY(int x, int y)
        {
            foreach (Node p in Nodes)
            {
                if ((p.X - x) * (p.X - x) + (p.Y - y) * (p.Y - y) < p.R * p.R)
                {
                    p.IsCheck = true;
                    return p;
                }
            }
            return null;
        }

        

        private Node ForAddEdge;
        private Node ForAddEdge2;
        public void AddEdge(int inf, int x, int y)
        {
            if (ForAddEdge == null)
            {
                ForAddEdge = FindByXY(x, y);
                return;
            }
            else
            {
                Edge e = new Edge();
                ForAddEdge2 = FindByXY(x, y);
                e.Weight = inf;
                e.LeftNode = ForAddEdge;
                e.RightNode = ForAddEdge2;
                ForAddEdge.edges.Add(e);
                ForAddEdge2.edges.Add(e);
                ForAddEdge = null;
            }
            
        }

        private Node ForDelEdge;
        public void DellEdge(int x, int y)
        {
            if (ForDelEdge == null)
            {
                ForDelEdge = FindByXY(x, y);
                return;
            }
            Node n = FindByXY(x, y);
            Edge edge = new Edge();
            edge.LeftNode = ForDelEdge;
            edge.RightNode = n;
            if (IsSimple(ForDelEdge, edge))
            {
                ForDelEdge.edges.Remove(edge);
                DelPairOfEdges();
            }
            else
            {
                edge.LeftNode = n;
                edge.RightNode = ForDelEdge;
                ForDelEdge.edges.Remove(edge);
                DelPairOfEdges();
            }
        }

        public bool IsSimple(Node p, Edge e)
        {
            foreach (Edge n in p.edges)
            {
                if (n == e)
                    return true;
            }
            return false;
        }

        /*
        private Edge EdgeDel;
        public void DelEdge(int x, int y, int weight)
        {
            if (EdgeDel == null)
            {
                Node p = FindByXY(x, y);
                
                if (p != null)
                {
                    EdgeDel = new Edge();
                    EdgeDel.LeftNode = p;
                   
                }
                
                return;
            }
            else
            {
                Node n = FindByXY(x, y);
                if (n != null)
                {
                    EdgeAdd.RightNode = n;
                }
                n.edges.Remove(EdgeDel);
                EdgeAdd = null;
                DelPairOfEdges();
            }
        }
*/

        public void DelPairOfEdges()
        {
            for (int i = 0; i < Nodes.Count; i++)
                for (int j = 0; j < Nodes[i].edges.Count; j++)
                    if (Nodes[i].edges[j].LeftNode == null || Nodes[i].edges[j].RightNode == null)
                        Nodes[i].edges.RemoveAt(j);
        }

        ///////////////////////////////////РИСОВАНИЕ//////////////////////////////////////
        public void Draw(Graphics g)
        {
            foreach (Node p in Nodes)
            {
                p.IsDrawn = false;
            }
            foreach (Node p in Nodes)
            {
                if (p != null)
                    Draw(g, p);
            }
        }
        private void Draw(Graphics g, Node p)
        {
            if (p.IsDrawn)
                return;
            if (p.edges != null)
            {
                foreach (Edge n in p.edges)
                {
                    if (n.IsDrawn == false)
                    {
                        DrawEdge(g, n.LeftNode, n.RightNode);
                        n.IsDrawn = true;
                    }
                }
            }
            DrawNode(g, p);
            p.IsDrawn = true;

        }

        private void DrawEdge(Graphics g, Node p, Node n)
        {
            g.DrawLine(pen, p.X + p.R / 2, p.Y + p.R / 2, n.X + n.R / 2, n.Y + n.R / 2);
        }

        private void DrawNode(Graphics g, Node p)
        {
            if (p.IsCheck)
                g.FillEllipse(Brushes.Red, p.X, p.Y, p.R, p.R);
            else
                g.FillEllipse(Brushes.Blue, p.X, p.Y, p.R, p.R);
            g.DrawEllipse(pen, p.X, p.Y, p.R, p.R);

            string s = p.Inf.ToString();
            SizeF size = g.MeasureString(s, MyFont);
            g.DrawString(s, MyFont, Brushes.Black, p.X + p.R / 2 - size.Width / 2, p.Y + p.R / 2 - size.Width / 2);
        }
    }
}
