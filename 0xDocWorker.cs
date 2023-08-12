using System.Drawing;
using Xceed.Words.NET;

namespace _0xDocWorker
{
    class _0xDocWorker
    {
        public static DocX? Doc { get; set; }

        public _0xDocWorker() 
        {
        
        }

        public static void ReplaceText(string filename, string textFind, string textReplace)
        {
            Doc = DocX.Load(filename);
            Doc.ReplaceText(textFind, textReplace);
            Doc.Save();
        }
    }
}
