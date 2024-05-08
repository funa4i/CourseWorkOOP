using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisBinaryTreeInputSearch.BinaryTreeClasses
{
    public class ConditionOfTree
    {
        public EnumAct EnumAct { get; private set; }
        public BinaryTree Tree { get; private set; }
        public int? UseableData { get; private set; }
        
        public ConditionOfTree(EnumAct enumAct, int? useableData, BinaryTree tree) 
        {
            EnumAct = enumAct;
            Tree = tree;
            UseableData = useableData;
        }


    }
}
