using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    class TreeNode<T> where T: IComparable //класс узел дерева
    {
        public TreeNode(T value)
        {
            this.Value = value;
        }
        //добавить свойства, вопрос правда какие
        public TreeNode<T> Left
        { get; set; }
        public TreeNode<T> Right
        { get; set; }
        public T Value
        { get; set; }
    }
}
