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

            QueueFiles que = new QueueFiles();
            int userSelection=0;
            bool flag = false;
            while (!flag)
            {
                Console.WriteLine("Please select your operation");
                Console.WriteLine("1) Add a default file");
                Console.WriteLine("2) Add a custom file");
                Console.WriteLine("3) Remove a file from the queue");
                Console.WriteLine("4) Display all files");
                Console.WriteLine("5) Display all files of selected extension");
                Console.WriteLine("6) Display the largest file");
                Console.WriteLine("7) Exit the program");
                userSelection = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (userSelection)
                {
                    case 1:
                        DataFile defaultFile = new DataFile();
                        que.Enqueue(defaultFile);
                        break;

                    case 2:
                        string fileName;
                        string fileData;
                        FileTypeExtension fileExtension;
                        Console.WriteLine("Please enter the file's name:");
                        fileName = Console.ReadLine();
                        Console.WriteLine("Please enter the file's data:");
                        fileData = Console.ReadLine();
                        Console.WriteLine("Please enter the file's type:\n1.TXT\n2.DOC\n3.DOCX\n4.PDF\n5.PPTX");
                        fileExtension = (FileTypeExtension)int.Parse(Console.ReadLine());
                        DataFile customFile = new DataFile(fileName,fileData,fileExtension);
                        que.Enqueue(customFile);
                        Console.Clear();
                        break;

                    case 3:
                        if (que.isEmpty())
                        { 
                            Console.WriteLine("Queue is empty, no files to remove");
                            break;
                        }
                        DataFile removed = new DataFile();
                        removed = que.Dequeue();
                        Console.WriteLine("File {0} has been removed from the queue", removed.getFileName());
                        Console.WriteLine("\n");
                        break;

                    case 4:
                        Console.WriteLine("The files in the queue are:");
                        que.PrintQueue();
                        Console.WriteLine("\n");
                        break;

                    case 5:
                        FileTypeExtension searchExtension;
                        Console.WriteLine("Please enter the file's type:\n1.TXT\n2.DOC\n3.DOCX\n4.PDF\n5.PPTX");
                        searchExtension = (FileTypeExtension)int.Parse(Console.ReadLine());
                        DataFile[] filesOfExtension = new DataFile[que.CountFileTypes(searchExtension)];
                        filesOfExtension = que.SearchFileByType(searchExtension);
                        foreach (DataFile item in filesOfExtension)
                        {
                            item.Dir();
                        }
                        Console.WriteLine("\n");

                        break;
                    case 6:
                        Console.WriteLine("The largest file is:");
                        DataFile largestFile = new DataFile();
                        largestFile = que.BigFile();
                        largestFile.Dir();
                        Console.WriteLine("\n");
                        break;

                    case 7:
                        Console.WriteLine("Closing the program");
                        flag = true;
                        break;

                    default:
                        break;

                    
                }
            }
        }
    }
}
