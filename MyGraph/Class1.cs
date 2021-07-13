using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GraphLibrary
{
    public class MyNode
    {
        public int X;
        public int Y;
        public int R;
        public int Inf;
        public int Number;
        public bool IsDrawn;
        public List<MyNode> neighbors = new List<MyNode>();
        public bool IsCheck;
        public bool IsVisit;
    }

    public class MyGraph
    {
        int i = 0;
        public List<MyNode> Nodes = new List<MyNode>();
        Pen pen = new Pen(Color.Black, 3);
        Font MyFont = new Font("Arial", 12);
        
        

        public void Clear()
        {
            Nodes.Clear();
        }
        public void AddNode(int x,int y, int r, int inf, Graphics g)
        {
            MyNode p = new MyNode();
            p.X = x;
            p.Y = y;
            p.Inf = inf;
            p.R = r;
            p.Number = i;
            i++;
            Nodes.Add(p);
            //Draw(g, p);
        }
         
        public MyNode Find(int x, int y)
        {
            return FindByXY(x, y);
        }
        private MyNode FindByXY(int x, int y)
        {
            foreach (MyNode p in Nodes)
            {
                if ((p.X - x) * (p.X - x) + (p.Y - y) * (p.Y - y) < p.R * p.R)
                {
                    p.IsCheck = true;
                    return p;
                }
            }
            return null;
        }

        public void Del(MyNode p)
        {
            DelNode(p);
        }
        private void DelNode(MyNode p)
        {
            if (p.neighbors != null)
            {
                foreach (MyNode n in p.neighbors)
                {
                    n.neighbors.Remove(p);
                    //p.neighbors.Remove(n);
                }
            }
            Nodes.Remove(p);
        }

        public void Add(MyNode p, MyNode n)
        {
            AddEdge(p, n);
        }
        private void AddEdge(MyNode p, MyNode n)
        {
            if (IsNeighbor(p, n))
                return;
            p.neighbors.Add(n);
            n.neighbors.Add(p);
            
        }

        public void Del(MyNode p, MyNode n)
        {
            DelEdge(p, n);
        }
        private void DelEdge(MyNode p, MyNode n)
        {
            if (IsNeighbor(p, n))
            {
                p.neighbors.Remove(n);
                n.neighbors.Remove(p);
            }
            else
                return;
        }

        public bool IsNeighbor(MyNode p, MyNode n)
        {
            bool a = false;
            if (p.neighbors != null)
            {
                foreach (MyNode k in p.neighbors)
                {
                    if (k == n)
                        a = true;
                }
            }
            return a;     
        }
        public void DelCheck()
        {
            foreach (MyNode p in Nodes)
                p.IsCheck = false;
        }

        private MyNode NodeForMove;

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

        //у каждогомузла сделать флаг на удаление
        // метод для нахождения цикла
        public MyNode MadeTree()
        {
            List<MyNode> list = new List<MyNode>();
            for (int k = 0; k < Nodes.Count; k++)
                list.Add(Nodes[k]);
            
            for (int i = 0; i < list.Count; i ++)
            {
                MyNode p = list[list.Count - 1 - i];
                list.RemoveAt(list.Count - 1 - i);
                if (IsTree(list))
                {
                    
                    return p;
                }
                list.Add(p);
            }
            return null;
        }

        public bool IsTree()
        {
            return IsTree(Nodes);
        }
        
       
        private bool IsTree(List<MyNode> list)
        {
            foreach (MyNode n in list)
            {
                n.IsVisit = false;
            }
            
            MyNode p = new MyNode();
            Stack<MyNode> stack = new Stack<MyNode>();
            List<int> path = new List<int>();
            stack.Push(list[0]);
            
            while (stack.Count != 0)
            {
                p = stack.Pop();

                for (int i = 0; i < path.Count; i++)
                {
                    if (p.Number == path[i])
                        return false;
                }
                
                path.Add(p.Number);
                p.IsVisit = true;

                foreach (MyNode n in p.neighbors)
                {
                    if (!n.IsVisit)
                        stack.Push(n);
                }
            }
            foreach (MyNode n in list)
            {
                if (!n.IsVisit)
                    return false;
            }
            return true;
        }
        //////////////////////////////////////////////////////////////////////
        
        //////////////////////////////////////////////////////////////////////


        public void Draw(Graphics g)
        {
            foreach (MyNode p in Nodes)
            {
                p.IsDrawn = false;
            }
            foreach (MyNode p in Nodes)
            {
                if (p != null)
                    Draw(g, p);
            }
        }
        private void Draw(Graphics g, MyNode p)
        {
            if (p.IsDrawn)
                return;

            if (p.neighbors != null)
            {
                foreach (MyNode n in p.neighbors)
                {
                    if (!n.IsDrawn)
                        DrawEdge(g, p, n);
                }
            }
            DrawNode(g, p);
            p.IsDrawn = true;

        }

        private void DrawEdge(Graphics g, MyNode p, MyNode n)
        {
            g.DrawLine(pen, p.X+p.R/2, p.Y+ p.R / 2, n.X+ n.R / 2, n.Y+ n.R / 2);
        }

        private void DrawNode(Graphics g, MyNode p)
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

        public MyGraph LoadGraph(string loadFileName)
        {
            int i = 0;
            MyGraph graphRGraph = new MyGraph();
            StreamReader reader = new StreamReader(loadFileName, Encoding.Default);
            string line = String.Empty;
            while ((line = reader.ReadLine()) != "nodesdone")
            {
                string[] arr = line.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                MyNode node = new MyNode();
                node.neighbors = new List<MyNode>();
                node.Number = Convert.ToInt32(arr[0]);
                node.X = Convert.ToInt32(arr[1]);
                node.Y = Convert.ToInt32(arr[2]);
                node.R = Convert.ToInt32(arr[3]);
                node.Inf = Convert.ToInt32(arr[4]);
                
                graphRGraph.Nodes.Add(node);
            }

            while ((line = reader.ReadLine()) != "edgesdone" || i < Nodes.Count)
            {
                string[] arr = line.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < arr.Length; j++)
                    foreach (MyNode p in graphRGraph.Nodes)
                    {
                        if (p.Number == Convert.ToInt32(arr[j]))
                            AddEdge(graphRGraph.Nodes[i], p);
                    }
                i++;
            }
            reader.Close();
            return graphRGraph;
        }

        public void Write(string writeFileName)
        {

            StreamWriter str = new StreamWriter(writeFileName);

            foreach (MyNode  p in Nodes)
            {
                str.WriteLine(p.Number.ToString() + " " + p.X.ToString() + " " + p.Y.ToString() + " " + p.R.ToString() + " " + p.Inf.ToString());
                
            }
            str.WriteLine("nodesdone");
            foreach (MyNode p in Nodes)
            {
                string s = " ";
                foreach (MyNode n in p.neighbors)
                    s = s + n.Number.ToString() + " ";
                str.WriteLine(s);
            }
            str.WriteLine("edgesdone");
            str.Close();
        }
    }

}
