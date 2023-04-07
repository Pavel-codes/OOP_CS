using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            DataFile d1 = new DataFile();
            DataFile d2 = new DataFile("myFile", "How much data do i need to write to get a significant number of characters for the function to show at least 0.1KB");
            d1.Dir();
            d2.Dir();
            d1.setFileName("myFileRenewed");
            d1.setData("Renamed the file and added some data");
            d1.Dir();
        }
    }
}
