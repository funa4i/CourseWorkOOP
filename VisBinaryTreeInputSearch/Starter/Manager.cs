using VisBinaryTreeInputSearch.BinaryTreeP;
using VisBinaryTreeInputSearch.Enums;
using VisBinaryTreeInputSearch.StarterPack;
using VisBinaryTreeInputSearch.StorageConditons;

namespace VisBinaryTreeInputSearch.Starter
{
    public class Manager
    {
        private BinaryTree Tree;

        public Storage? _storage { get; private set; }

        public Manager(BinaryTree  tree) 
        {
            this.Tree = tree;
            _storage = new Storage();
        }
        /// <summary>
        /// Принимает начальные параметры для создания Storage
        /// </summary>
        /// <param name="igniter"></param>
        /// <returns></returns>
        public void addIgniter(Igniter igniter)
        {
            Tree.SetCondition(_storage.SetLastPostion());
            bool? buf = null;
            switch (igniter.act)
            {
                case EnumAct.Find:  
                    do
                    {
                        buf = Tree.DoFind(igniter.data);
                        _storage?.addCondition(Tree.CreateNewCondition(igniter.act, igniter.data, buf));
                    } while (buf == null);
                    break;
                case EnumAct.Insert:
                    do
                    {
                        buf = Tree.DoInsert(igniter.data);
                        _storage?.addCondition(Tree.CreateNewCondition(igniter.act, igniter.data, buf));
                    } while (!buf ?? false);
                    break;
            }
        }
    }
}
