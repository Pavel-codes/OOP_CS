using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_gui_2
{
    [Serializable]
    internal class NoItemSelectedException : Exception
    {
        public NoItemSelectedException() { }
        public NoItemSelectedException(string s) : base(s = "No item selected, please select an item") { }
    }
}
