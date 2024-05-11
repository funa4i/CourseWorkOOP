using Newtonsoft.Json;
using System.Text.Json.Serialization;
using VisBinaryTreeInputSearch.Enums;

namespace VisBinaryTreeInputSearch.BinaryTreeP
{
    public class BinaryTree
    {
        public MyTreeNode? head { get; set; }
     
        public int size { get; set; }

        private BinaryTree(int data)
        {
            head = new MyTreeNode(data);
            size = 1;
        }
        
        private BinaryTree(MyTreeNode node, int size)
        {
            head = MyTreeNode.Clone(node);
            this.size = size;
        }
        
        public BinaryTree() 
        {
            head = null;
            size = 0;
        }

        /// <summary>
        /// Выполнение шага вставки
        /// </summary>
        /// <param name="data"></param>
        /// <returns>True - если вставка реализовалась<br/>
        /// False - если нет</returns>
        public bool DoInsert(int data)
        {
            MyTreeNode? curentNode = this.FindCurrentNode();
            if (curentNode == null)
            {
                if (head == null)
                {
                    head = new MyTreeNode(data);
                    size += 1;
                    return true;
                }
                MyTreeNode.SwapChoose(null, head);
                return false;
            }
            if (curentNode?.data > data)
            {
                if (curentNode.left == null)
                {
                    curentNode.left = new MyTreeNode(data);
                    MyTreeNode.SwapChoose(curentNode, null);
                    size++;
                    return true;
                }
                MyTreeNode.SwapChoose(curentNode, curentNode.left);
                curentNode = curentNode.left;
            }
            else if (curentNode?.data <= data)
            {
                if (curentNode.right == null)
                {
                    curentNode.right = new MyTreeNode(data);
                    MyTreeNode.SwapChoose(curentNode,null);
                    size++;
                    return true;
                }
                MyTreeNode.SwapChoose(curentNode, curentNode.right);
                curentNode = curentNode.right;
            }
            return false;
        }

        /// <summary>
        /// Выполнение шага поиска
        /// </summary>
        /// <param name="data"></param>
        /// <returns>True - объект найдет<br/>
        /// False - если нет<br/>
        /// null - если не дошли до конца дерева</returns>
        public bool? DoFind(int data)
        {
            if(head == null)
            {
                return false;
            }
            MyTreeNode? curentNode = this.FindCurrentNode();
            if (curentNode == null)
            {
                MyTreeNode.SwapChoose(curentNode, head);
                return null;
            }
            if (curentNode.data == data)
            {
                MyTreeNode.SwapChoose(curentNode, null);
                return true;
            }
            if (curentNode.data > data)
            {
                MyTreeNode.SwapChoose(curentNode, curentNode.left);
                if (curentNode.left == null)
                {
                    return false;
                }
                return null;
            }

            if (curentNode.data < data)
            {
                MyTreeNode.SwapChoose(curentNode, curentNode.right);
                if (curentNode.right == null)
                {
                    return false;
                }
                return null;
            }
            return false;
        }
        /// <summary>
        /// Находит текущий выбранный узел
        /// </summary>
        /// <returns>Объект MyTreeNode если узел есть<br/>
        /// null - если такого узла нет</returns>
        public MyTreeNode? FindCurrentNode()
        {
            return DoFindCurrentNode(this.head);
        }

        private MyTreeNode? DoFindCurrentNode(MyTreeNode? curObj)
        {
            if (curObj == null)
            {
                return null;
            }
            else if (curObj._isChoosen)
            {
                return curObj;
            }
            return DoFindCurrentNode(curObj.right) ?? DoFindCurrentNode(curObj.left);
        }

        /// <summary>
        /// Глубока копия дерева
        /// </summary>
        /// <param name="binTree"></param>
        /// <returns>Полноценную копию дерева</returns>
        public static BinaryTree DeepClone(BinaryTree binTree)
        {
            if (binTree.head == null)
            {
                return new BinaryTree();
            }
            BinaryTree binaryTreeNew = new BinaryTree(binTree.head, binTree.size);
            return binaryTreeNew;
        }
        /// <summary>
        /// Фиксирует текущее состояние
        /// </summary>
        /// <param name="enumAct"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public ConditionOfTree CreateNewCondition(EnumAct enumAct, int data)
        {
            return new ConditionOfTree(enumAct, data, DeepClone(this));
        }


        public void SetCondition(ConditionOfTree condition)
        {
            head = MyTreeNode.Clone(condition.Tree.head);
            size = condition.Tree.size;
        }
   
    }
}
