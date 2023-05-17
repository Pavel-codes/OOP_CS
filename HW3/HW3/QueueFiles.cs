using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    internal class QueueFiles
    {
        private static int freeIndex;
        private DataFile[] dataFiles;

        public QueueFiles()
        {
            dataFiles = new DataFile[0];
            freeIndex = -1;
        }

        public bool isEmpty()
        {
            if (freeIndex == -1)
            {
                Console.WriteLine("The Queue is empty");
                return true;
            }
            return false;
        }

        public void Enqueue(DataFile d)
        {
            if (freeIndex == -1) { freeIndex = 0; }
            for (int i = 0; i < freeIndex; i++)
            {
                if (CompareFiles.EqualFiles(dataFiles[i], d))
                {
                    Console.WriteLine("File already exists in the queue");
                    return;
                }
            }
            DataFile[] temp = new DataFile[dataFiles.Length + 1];
            dataFiles.CopyTo(temp, 0);
            dataFiles = temp;
            dataFiles[freeIndex++] = d;
        }
        public DataFile Dequeue()
        {
            DataFile[] temp = new DataFile[dataFiles.Length - 1];
            DataFile newFile = dataFiles[0];
            for (int i = 0; i < freeIndex - 1; i++)
            {
                temp[i] = dataFiles[i + 1];
            }
            freeIndex--;
            Array.Resize(ref dataFiles, temp.Length);
            temp.CopyTo(dataFiles, 0);
            dataFiles = temp;
            return newFile;
        }

        public int CountFileTypes(FileTypeExtension type)
        {
            int count = 0;
            foreach (DataFile item in dataFiles)
            {
                if (item.GetType() == type) count++;
            }
            return count;
        }

        public DataFile BigFile()
        {
            int counter = freeIndex, size=0;
            DataFile max,current;
            DataFile[] tempFiles = new DataFile[dataFiles.Length];
            dataFiles.CopyTo(tempFiles, 0);
            if(dataFiles.Length == 0) return null;
            if(freeIndex == 1)
            {
                Console.WriteLine("There is only one file in the queue");
                max = Dequeue();
                Enqueue(max);
                return max;
            }
            else
            {
                max = Dequeue();
                for (int i = 0; i < counter-1; i++)
                {
                    
                    current = Dequeue();
                    if (current == null) break;
                    size = CompareFiles.CompareSizeFiles(max, current);
                    if (size == 1 || size == 0) continue;
                    else if(size == -1)
                    {
                        max = current;
                    }
                }
            }
            freeIndex = counter;
            Array.Resize(ref dataFiles, tempFiles.Length);
            tempFiles.CopyTo(dataFiles,0); 
            return max;
        }

        public void PrintQueue()
        {
            int count=freeIndex;
            DataFile current;
            DataFile[] tempFiles = new DataFile[dataFiles.Length];
            dataFiles.CopyTo(tempFiles, 0);
            for (int i = 0; i < tempFiles.Length; i++)
            {
                current = Dequeue();
                current.Dir();
            }
            freeIndex=count;
            Array.Resize(ref dataFiles, tempFiles.Length);
            tempFiles.CopyTo(dataFiles, 0);
        }

        public DataFile[] SearchFileByType(FileTypeExtension type)
        {
            int count=0, originalSize = freeIndex;
            DataFile currentFile = new DataFile();
            DataFile[] filesOfType = new DataFile[dataFiles.Length];
            DataFile[] tempFiles = new DataFile[dataFiles.Length];
            dataFiles.CopyTo(tempFiles, 0);
            if (dataFiles == null) return null;
            for (int i = 0; i < tempFiles.Length; i++)
            {
                currentFile = Dequeue();
                if (currentFile.GetType() != type) continue;
                else if(currentFile.GetType() == type) filesOfType[count++] = currentFile;
            }
            freeIndex = originalSize;
            Array.Resize(ref filesOfType, count);
            Array.Resize(ref dataFiles, tempFiles.Length);
            tempFiles.CopyTo(dataFiles, 0);
            return filesOfType;
        }

    }
}
