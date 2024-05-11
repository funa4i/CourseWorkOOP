using System.IO;
using System.Text.Json;

using VisBinaryTreeInputSearch.Forms;
using VisBinaryTreeInputSearch.BinaryTreeP;

namespace VisBinaryTreeInputSearch
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        { 
            ApplicationConfiguration.Initialize();
           Application.Run(new MainForm());
           
            

        }        
    }
}