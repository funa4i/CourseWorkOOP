using VisBinaryTreeInputSearch.Enums;

namespace VisBinaryTreeInputSearch.BinaryTreeP
{
    public class ConditionOfTree
    {
        public EnumAct EnumAct { get;  set; }
        public BinaryTree Tree { get;  set; }
        public int UseableData { get;  set; }
        
        public ConditionOfTree(EnumAct enumAct, int useableData, BinaryTree tree) 
        {
            EnumAct = enumAct;
            Tree = tree;
            UseableData = useableData;
        }


    }
}
