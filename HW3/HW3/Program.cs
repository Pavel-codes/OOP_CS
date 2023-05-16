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
            DataFile test = new DataFile();
            Console.WriteLine(d1.getFileCount());
            DataFile d2 = new DataFile("myFile", "How much data do i need to write to get a significant number of characters for the function to show at least 0.1KB", FileTypeExtension.TXT);
            DataFile d3 = new DataFile();
            DataFile d4 = new DataFile();
            QueueFiles q1 = new QueueFiles();
            //QueueFiles q2 = new QueueFiles();

            q1.Enqueue(d1);
            q1.Enqueue(d2);
            q1.Enqueue(d3);
            q1.Enqueue(d4);
            //test = q1.Dequeue();


            //q1.PrintQueue(q2); // null ref

            d4 = q1.BigFile(); // stopped working

        }
    }
}
