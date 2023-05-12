using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    enum FileTypeExtension
    {
        TXT=1,
        DOC,
        DOCX,
        PDF,
        PPTX
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            DataFile d1 = new DataFile();
            Console.WriteLine(d1.getFileCount());
            DataFile d2 = new DataFile("myFile", "How much data do i need to write to get a significant number of characters for the function to show at least 0.1KB", FileTypeExtension.TXT);
            DataFile d3 = new DataFile();
            //d1.Dir();
            //d2.Dir();
            //d1.setFileName("myFileRenewed");
            d1.setData("Renamed the file and added some data");
            //d3.setFileName("myFileRenewed");
            //d3.setData("Renamed the file and added some data");
            //Console.WriteLine(CompareFiles.EqualFiles(d1, d3));
            //Console.WriteLine(CompareFiles.CompareSizeFiles(d1, d3));
            //d1.IncreaseFileCount();
            d1.Dir();
            Console.WriteLine(d1.getFileCount());
            //Console.WriteLine(d1.getFileCount());
            d3.Dir();
            //Console.WriteLine(d2.getFileCount());
        }
    }
}
