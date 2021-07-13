using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GraphLibrary;
using System.IO;

namespace Graph1
{
    public partial class Form1 : Form
    {
        Graphics g;
        MyGraph graph;
        List<MyNode> list;
        int k = 0;
        public Form1()
        {
            InitializeComponent();
            
            graph = new MyGraph();
            list = new List<MyNode>();
        }


        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            g.Clear(Color.AliceBlue);
            
            if (AddEl.Checked)
            {
                graph.AddNode(e.X, e.Y, 40, Convert.ToInt32(textBox1.Text), g);
                graph.Draw(g);
                int c = Convert.ToInt32(textBox1.Text);
                c++;
                textBox1.Text = c.ToString();
            }

            if (DelEl.Checked)
            {
                MyNode p = graph.Find(e.X, e.Y);
                if (p != null)
                    graph.Del(p);
                graph.Draw(g);
                int c = Convert.ToInt32(textBox1.Text);
                c--;
                textBox1.Text = c.ToString();
            }

            if (AddEdge.Checked)
            {
                MyNode p = graph.Find(e.X, e.Y);

                if (p != null)
                list.Add(p);
                
                graph.Draw(g);

                if (list.Count == 2)
                {
                    graph.Add(list[0], list[1]);
                    graph.Draw(g);
                    list.Clear();
                    graph.DelCheck();
                }
                graph.Draw(g);
            }

            if (DelEdge.Checked)
            {
                MyNode p = graph.Find(e.X, e.Y);

                if (p != null)
                    list.Add(p);

                if (list.Count == 2)
                {
                    graph.Del(list[0], list[1]);
                    graph.Draw(g);
                    list.Clear();
                    graph.DelCheck();
                }
                graph.Draw(g);
            }

            if (MoveNode.Checked)
            {
                graph.MoveNode(e.X, e.Y);
                graph.Draw(g);
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            g = pictureBox1.CreateGraphics();
            g.Clear(Color.AliceBlue);
            textBox1.Text = "1";
            
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        { 
            if (e.Button == MouseButtons.Right)
            {
                list.Clear();
                graph.DelCheck();
                graph.Draw(g);
            }            
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            graph.Clear();
            g.Clear(Color.AliceBlue);
        }

        private void IsGraph_Click(object sender, EventArgs e)
        {
            if (graph.IsTree())
                label1.Text = "Да, это дерево";
            else
                label1.Text = "Нет, это не дерево";
        }

        private void MadeTree_Click(object sender, EventArgs e)
        {
            MyNode p = new MyNode();

            if (graph.IsTree())
                label2.Text = "Это уже дерево";
            else
            {
                p = graph.MadeTree();
                if (p != null)
                    label2.Text = "Деревво можно создать, убрав \n" + p.Number.ToString() + " элемент с значением " + p.Inf;
                else
                    label2.Text = "Дерево создать нельзя";
            }
            graph.Draw(g);
        }

  
        private void OpenFile_Click(object sender, EventArgs e)
        {
            g = pictureBox1.CreateGraphics();
            g.Clear(Color.AliceBlue);
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            graph = graph.LoadGraph(openFileDialog1.FileName);
            graph.Draw(g);

        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            graph.Write(saveFileDialog1.FileName);

        }
    }
}
