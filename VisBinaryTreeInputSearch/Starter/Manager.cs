using VisBinaryTreeInputSearch.BinaryTreeP;
using VisBinaryTreeInputSearch.Enums;
using VisBinaryTreeInputSearch.StarterPack;
using VisBinaryTreeInputSearch.StorageConditons;

namespace VisBinaryTreeInputSearch.Starter
{
    public class Manager
    {
        private BinaryTree Tree;
        public bool result { get; private set;}

        public Manager(BinaryTree  tree) 
        {
            this.Tree = tree;
        }
        /// <summary>
        /// Принимает начальные параметры для создания Storage
        /// </summary>
        /// <param name="igniter"></param>
        /// <returns></returns>
        public Storage addIgniter(Igniter igniter)
        {
            Storage toRet = new Storage();
            toRet.addCondition(Tree.CreateNewCondition(igniter.act, igniter.data));
            bool? buf;
            switch (igniter.act)
            {
                case EnumAct.Find:  
                    do
                    {
                        buf = Tree.DoFind(igniter.data);
                        toRet.addCondition(Tree.CreateNewCondition(igniter.act, igniter.data));
                    } while (buf == null);
                    result = buf ?? false;
                    toRet.SetNullPosition();
                    return toRet;
                case EnumAct.Insert:
                    do
                    {
                        buf = Tree.DoInsert(igniter.data);
                        toRet.addCondition(Tree.CreateNewCondition(igniter.act, igniter.data));
                    } while (!buf ?? false);
                    result = buf ?? false;
                    toRet.SetNullPosition();
                    return toRet;
            }
            return toRet;
        }
    }
}
