using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_gui_2
{
    internal class Clothing : Product
    {
        protected bool isProtective;
        public Clothing(string name, float price, ColorOfProduct color, MeasurementSize size, bool isProtective) : base(name, price, color, size)
        {
            switch (name)
            {
                case "Jacket":
                    if (size == MeasurementSize.Large || size == MeasurementSize.ExtraLarge) this.price += 50;
                    if (isProtective) this.price *= (float)2.0;
                    break;
                case "Pants":
                    if (size == MeasurementSize.Large || size == MeasurementSize.ExtraLarge) this.price += 50;
                    if (isProtective) this.price *= (float)1.5;
                    break;
                case "Gloves":
                    if (size == MeasurementSize.Large || size == MeasurementSize.ExtraLarge) this.price += 25;
                    if (isProtective) this.price *= (float)1.25;
                    break;
                default:
                    break;
            }
            this.isProtective = isProtective;
        }

        public bool IsProtective
        {
            get { return isProtective; }
            set { isProtective = value; } // add exception if needed
        }

        public override string ToString()
        {
            if(isProtective) return $"{Name} of {SizeOfItem} size and {ColorOfItem} color, protective, price: {Price}$";
            return $"{Name} of {SizeOfItem} size and {ColorOfItem} color, non-protective, price: {Price}$";
        }
    }
}
