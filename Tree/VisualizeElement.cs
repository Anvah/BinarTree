using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    class VisualizeElement<T> : IComparable where T : IComparable 
    {
        public T Value { get; set; } 
        int x = 300;
        int y = 100;
        Graphics graph;
        Brush brush = new SolidBrush(Color.Aqua);
        public VisualizeElement(int X, int Y, T val, Graphics g)
        {
            x = X;
            y = Y;
            graph = g;
            Value = val;
        }
        public void Draw()
        {
            graph.FillEllipse(brush, x+20, y+20, 40, 40);
        }

        public int CompareTo(object obj)
        {
            return Value.CompareTo(obj);
        }
    }
}

