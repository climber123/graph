using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _49
{
    public partial class Number49 : Form
    {
        Graphics g;
        Graph graph;
        public Number49()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();
            graph = new Graph();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            g.Clear(Color.AliceBlue);
            if (e.Button == MouseButtons.Right)
            {
                graph.DelCheck();
            }
            if (AddNode.Checked)
            {
                int inf;
                inf = Convert.ToInt32(textBox1.Text);
                graph.AddNode(e.X, e.Y, 40, inf, g);
                graph.Draw(g);
            }
            if (DelNode.Checked)
            {
                graph.DelNode(e.X, e.Y);
                graph.Draw(g);
            }
            if (MoveNode.Checked)
            {
                graph.MoveNode(e.X, e.Y);
                graph.Draw(g);
            }
            if (AddEdge.Checked)
            {
                graph.AddEdge(Convert.ToInt32(textBox2.Text), e.X, e.Y);
                graph.Draw(g);
            }
            if (DelEdge.Checked)
            {
                graph.DellEdge(e.X, e.Y);
                graph.Draw(g);
            }
        }

        private void Number49_Load(object sender, EventArgs e)
        {

        }
    }
}
