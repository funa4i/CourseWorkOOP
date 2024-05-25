using System.Text.Json;
using System.Text.Json.Serialization;
using VisBinaryTreeInputSearch.Enums;

namespace VisBinaryTreeInputSearch.BinaryTreeP
{
    public class ConditionOfTree
    {
        public EnumAct EnumAct { get; private set; }
        public BinaryTree Tree { get; private  set; }
        public int UseableData { get; private set; }
        public bool? result { get;  private set; }

        [JsonConstructor]
        public ConditionOfTree(EnumAct EnumAct, int UseableData, BinaryTree Tree, bool? result) 
        {
            this.EnumAct = EnumAct;
            this.Tree = Tree;
            this.UseableData = UseableData;
            this.result = result;
        }


    }
}
