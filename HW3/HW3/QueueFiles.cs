using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    internal class QueueFiles
    {
        private static int freeIndex = 0;
        private DataFile[] dataFiles;
        
        public QueueFiles()
        {
            dataFiles = new DataFile[0];
            freeIndex = -1;
        }
    }
}
