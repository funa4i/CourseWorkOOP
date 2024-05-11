using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisBinaryTreeInputSearch.BinaryTreeP
{
    public class MyTreeNode
    {
        
        public int data { get; set; }
        
        public MyTreeNode? left { get; set; }
        
        public MyTreeNode? right { get; set; }
    
        public bool _isChoosen { get; set; } = false;
        public MyTreeNode(int data)
        {
            this.data = data;
            left = null;
            right = null;
        }

        public static int GetRightChilds(MyTreeNode? node) 
        {
            if (node == null)
            {
                return 0;
            }
            return GetAllChilds(node.right);
        }

        public static  int GetLeftChilds(MyTreeNode? node)
        {
            if (node == null) { return 0;}
            return GetAllChilds(node.left);
        }

        private static int GetAllChilds(MyTreeNode? node)
        {
            if (node == null)
            {
                return 0;
            }
            return 1 + GetAllChilds(node.left) + GetAllChilds(node.right); 
        }
        

        /// <summary>
        /// Иземеняет поле _isChoosen первого объекта first на false, объекта sec на true
        /// </summary>
        public static void SwapChoose(MyTreeNode? f, MyTreeNode? s)
        {
            if (f != null) 
            {
                f._isChoosen = false;
            }
            if (s != null)
            {
                s._isChoosen = true;
            }
        }

        /// <summary>
        /// Глубокое копирование объекта списка
        /// </summary>
        /// <returns>Глубокая копия объекта</returns>
        public static MyTreeNode? Clone(MyTreeNode? objForCopy)
        {
            if (objForCopy == null)
            {
                return null;
            }
            MyTreeNode node = new MyTreeNode(objForCopy.data);
            node.left = Clone(objForCopy?.left);  
            node.right = Clone(objForCopy?.right);
            node._isChoosen = objForCopy?._isChoosen ?? false;
            return node;
        }
    }
}
