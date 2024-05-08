using VisBinaryTreeInputSearch.BinaryTreeClasses;
using System.IO;
using System.Text.Json;

namespace VisBinaryTreeInputSearch
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        { 
            ApplicationConfiguration.Initialize();
            BinaryTree binary = new BinaryTree();
            while (!binary.DoInsert(11)) { };
            while (!binary.DoInsert(9)) { };
            BinaryTree? binary1 = BinaryTree.DeepClone(binary);
            while (!binary1.DoInsert(10)) { };
        }        
    }
}