using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    internal class DataFile
    {
        private string FileName;
        private DateTime LastUpdateTime;
        private string Data;

        public DataFile(string FileName, string Data)
        {
            setFileName(FileName);
            LastUpdateTime = DateTime.Now;
            this.Data = Data;
        }
        public DataFile() : this("someFile", "") { }
        public DataFile(DataFile other)
        {
            FileName = "copy of " + other.FileName;
            LastUpdateTime = DateTime.Now;
        }

        public string getFileName()
        {
            return FileName;
        }

        public void setFileName(string FileName)
        {
            char[] invalidChars = new char[] { '>', '<', '?', '/', ':', '*', '"', '\\' ,'|' };
            if(invalidChars.Any(FileName.Contains))
            {
                while (invalidChars.Any(FileName.Contains))
                {
                    Console.WriteLine("A file name cannot contain and of the following characters : \\ / : * ? \" < > | ");
                    Console.WriteLine("Please enter a new file name: ");
                    FileName = Console.ReadLine();
                }
            }
            this.FileName = FileName;
        }
        public string getData()
        {
            return this.Data;
        }
        public void setData(string Data)
        {
            this.Data = Data;
        }
        public void SetTime()
        {
            LastUpdateTime = DateTime.Now;
        }
        public DateTime GetTime()
        {
            return LastUpdateTime;
        }
        private float GetSize()
        {
            float size = 0;
            const int KByte = 1024;
            if(Data != null)
            {
                size = (float)Data.Length / KByte;
            }
            return size;
        }
        public void Dir()
        {
            Console.WriteLine($"{LastUpdateTime} {GetSize()}KB {FileName}.txt");
        }
    }
} 