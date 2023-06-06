using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_gui_2
{
    enum ColorOfProduct
    {
        Black,
        Red,
        Blue,
        Green,
        Yellow,
        White,
    }

    enum MeasurementSize
    {
        Small,
        Medium,
        Large,
        ExtraLarge
    }
    internal class Product
    {
        protected string name;
        protected float price;
        protected ColorOfProduct colorOfItem;
        protected MeasurementSize sizeOfItem;

        public Product(string name, float price, ColorOfProduct color, MeasurementSize size)
        {
            this.name = name;
            this.price = price;
            colorOfItem = color;
            sizeOfItem = size;
        }

        public string Name
        {
            get { return name; } 
            set { name = value; }
        }

        public float Price 
        { 
            get { return price; }
            set { price = value; }
        }

        public ColorOfProduct ColorOfItem
        { 
            get { return colorOfItem; }
            set { colorOfItem = value; }
        }

        public MeasurementSize SizeOfItem
        { 
            get { return sizeOfItem;}
            set { sizeOfItem = value; }
        }

        public new virtual string ToString()
        {
            return $"{Name} {ColorOfItem} {SizeOfItem} {Price}";
        }

    }
}
