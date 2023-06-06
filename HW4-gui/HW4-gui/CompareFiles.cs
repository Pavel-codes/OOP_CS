using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_gui
{
    internal class CompareFiles
    {
        public static bool EqualFiles(DataFile first, DataFile second)
        {
            return first.getFileName().Equals(second.getFileName()) && first.getData().Equals(second.getData());
        }

        public static int CompareSizeFiles(DataFile first, DataFile second)
        {
            if (first.GetSize() == second.GetSize()) { return 0; }
            return first.GetSize() > second.GetSize() ? 1 : -1;
        }
    }
}
