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

        //public bool Enqueue(DataFile d)
        //{
        //    if (freeIndex == -1 || freeIndex == 0)
        //    {
        //        freeIndex = 1;
        //        DataFile[] temp = new DataFile[freeIndex];
        //        temp[0] = d;
        //        dataFiles = temp;
        //        return true;
        //    }
        //    else if (freeIndex == dataFiles.Length) 
        //    {
        //        DataFile[] temp = new DataFile[freeIndex + 1];
        //        for (int i = 0; i < dataFiles.Length; i++) 
        //        {
        //            if (CompareFiles.EqualFiles(dataFiles[i], d))
        //            {
        //                Console.WriteLine("File already exists in the queue");
        //                return false;
        //            }
        //            temp[i + 1] = dataFiles[i];
        //        }
        //        freeIndex++;
        //        dataFiles = temp;
        //    }
        //    else if (dataFiles.Length < freeIndex)
        //    {
        //        freeIndex++;
        //        DataFile[] temp = new DataFile[freeIndex];
        //        for (int i = 0; i < dataFiles.Length; i++)
        //        {
        //            temp[i + 1] = dataFiles[i];
        //        }
        //        dataFiles = temp;

        //    }
        //    dataFiles[0] = d;
        //    return true;
        //}
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
        public DataFile Dequeue() // returns the first file but removes the last
        {
            DataFile[] temp = new DataFile[dataFiles.Length - 1];
            DataFile newFile = dataFiles[0];
            for (int i = 0; i < freeIndex - 1; i++)
            {
                temp[i] = dataFiles[i + 1];
            }
            freeIndex--;
            //dataFiles[freeIndex] = null;
            Array.Resize(ref dataFiles, temp.Length);
            temp.CopyTo(dataFiles, 0);
            dataFiles = temp;
            return newFile;
        }
        //public void Enqueue(DataFile d)
        //{

        //}

        //public DataFile Dequeue() // my Dequeue function - keeping to compare
        //{
        //    if (freeIndex == -1)
        //    {
        //        return null;
        //    }
        //    DataFile[] temp = new DataFile[dataFiles.Length - 1];
        //    DataFile file = dataFiles[0];
        //    for (int i = 0; i < dataFiles.Length - 1; i++)
        //    {
        //        temp[i] = dataFiles[i + 1];
        //    }
        //    dataFiles = temp;
        //    freeIndex--;
        //    return file;
        //}

        //public DataFile Peek()
        //{
        //    DataFile topFile = null;
        //    if (freeIndex == -1 || freeIndex == 0 || dataFiles.Length == 0) return null;
        //    //topFile = dataFiles[0];
        //    topFile = dataFiles[freeIndex-1];
        //    return topFile;
        //}

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

        //public DataFile BigFile(QueueFiles temp) // keeping for reference
        //{
        //    int size=0, length;
        //    length = dataFiles.Length;
        //    DataFile max = new DataFile();
        //    DataFile current,next;
        //    if(dataFiles == null) return null;
        //    if(freeIndex == 1)
        //    {
        //        Console.WriteLine("There is only one file in the queue");
        //        return null;
        //    }
        //    for (int i = 0; i < length; i++)
        //    {
        //        temp.Enqueue(Dequeue());
        //        current = temp.Peek();
        //        next = Peek();
        //        if (next != null)
        //        {
        //            size = CompareFiles.CompareSizeFiles(current, next);
        //            if (size == 0 || size == 1)
        //            {
        //                max = current;
        //            }
        //            else if (size == -1) max = next;
        //        }
        //    }
        //    for (int j = 0; j < length; j++)
        //    {
        //        Enqueue(temp.Dequeue());
        //    }
        //    return max;
        //}

        //public void PrintQueue(QueueFiles que) // keeping for reference
        //{
        //    int length = dataFiles.Length;
        //    DataFile file;
        //    for (int i = 0; i < length; i++)
        //    {
        //        que.Enqueue(Dequeue()); // null reference - items disappearing
        //        file = que.Peek();
        //        file.Dir();

        //    }
        //    //ReturnQueue(temp, length);
        //}
    }
}
