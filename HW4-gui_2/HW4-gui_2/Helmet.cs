using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_gui_2
{
    internal class Helmet : Product
    {
        private bool isCameraMountable;
        public Helmet(string name, float price, ColorOfProduct color, MeasurementSize size, bool isCameraMountable) : base(name, price, color, size)
        {
            if (size == MeasurementSize.Large || size == MeasurementSize.ExtraLarge) this.price += 25;
            if (isCameraMountable) this.price *= (float)1.25;
            this.isCameraMountable = isCameraMountable;
            
        }

        public bool IsCameraMountable
        {
            get { return isCameraMountable; }
            set { isCameraMountable = value; } // add exception if needed
        }

        public override string ToString()
        {
            if (isCameraMountable) return $"{Name} of {SizeOfItem} size and {ColorOfItem} color, has camera slot, price: {Price}$";
            return $"{Name} of {SizeOfItem} size and {ColorOfItem} color, no camera slot, price: {Price}$";
        }
    }
}
