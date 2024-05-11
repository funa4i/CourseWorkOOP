using VisBinaryTreeInputSearch.Enums;

namespace VisBinaryTreeInputSearch.StarterPack
{
    public class Igniter
    {
        public EnumAct act { get; private set; }

        public int data { get; private set; }    

        public Igniter(EnumAct act, int data)
        {
            this.act = act;
            this.data = data;
        }
    }
}
