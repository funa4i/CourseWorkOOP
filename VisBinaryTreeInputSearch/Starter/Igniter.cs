using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisBinaryTreeInputSearch.BinaryTreeP;
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
