using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MyTree<int> tree = new MyTree<int>();
        Graphics g;
        int x = 600;
        int y = 100;
        private void button1_Click(object sender, EventArgs e)
        {
            Refresh();
            tree.Add(Convert.ToInt32(textBox1.Text));
            label1.Text = tree.LNR();
            label3.Text = tree.NLR();
            label4.Text = tree.LRN();
            g.FillEllipse(new SolidBrush(Color.HotPink), x-20, y-20, 40, 40);
            g.DrawString(tree.root.Value.ToString(), new Font("Arial", 10), new SolidBrush(Color.Black), x-10, y-10);

            Draw(tree.root, x, y, 1);
        }

        //обратный обход
        private void Draw(TreeNode<int> subroot, float x, float y, float c)
        {
            if (subroot == null)
            {
                return;
            }
            
            if(subroot.Left != null)
            {
               
                float x1 = x - 120/c;
                float y1 = y + 70;
                g.DrawLine(new Pen(new SolidBrush(Color.Black)), x, y, x1, y1);
                g.FillEllipse(new SolidBrush(Color.HotPink), x1-20, y1-20, 40, 40);
                g.DrawString(subroot.Left.Value.ToString(), new Font("Arial", 10), new SolidBrush(Color.Black), x1-10, y1-10);
                Draw(subroot.Left, x1, y1, c*2);

                
            }
            if (subroot.Right != null)
            {
                float x2 = x + 120/c;
                float y2 = y + 70;
                g.DrawLine(new Pen(new SolidBrush(Color.Black)), x, y, x2, y2);
                g.FillEllipse(new SolidBrush(Color.HotPink), x2-20, y2-20, 40, 40);
                g.DrawString(subroot.Right.Value.ToString(), new Font("Arial", 10), new SolidBrush(Color.Black), x2-10, y2-10);
                Draw(subroot.Right, x2, y2, c*2);
            }
            


        }
       

        private void Form1_Load(object sender, EventArgs e)
        {
            g = CreateGraphics();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tree.Remove(Convert.ToInt32(textBox1.Text));
            Refresh();
            g.FillEllipse(new SolidBrush(Color.Aqua), x - 20, y - 20, 40, 40);
            g.DrawString(tree.root.Value.ToString(), new Font("Arial", 10), new SolidBrush(Color.Black), x - 10, y - 10);

            Draw(tree.root, x, y, 1);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = tree.LNR();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label3.Text = tree.NLR();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label4.Text = tree.LRN();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label2.Text = tree.GetDeep().ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            label5.Text = tree.Find(Convert.ToInt32(textBox1.Text)).Value.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label6.Text = tree.GetLeafs().ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label7.Text = tree.GetNodes().ToString();
        }
    }
}
