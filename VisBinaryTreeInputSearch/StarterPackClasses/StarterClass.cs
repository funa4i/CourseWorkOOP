using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisBinaryTreeInputSearch.BinaryTreeClasses;

namespace VisBinaryTreeInputSearch.StarterPackClasses
{
    public class StarterClass
    {
        public EnumAct act { get; set; }

        public int data { get; set; }

        public StarterClass(EnumAct act, int data)
        {
            this.act = act;
            this.data = data;
        }
    }
}
