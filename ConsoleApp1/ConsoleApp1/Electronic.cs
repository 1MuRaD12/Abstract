using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    abstract class Electronic
    {
        public int Price;
        public byte Guarantee;
        public byte Durability;
        public string Color;


        public Electronic(int price, byte guarantee,byte durability,string color)
        {
            Price = price;
            Guarantee = guarantee;
            Durability = durability;
            Color = color;
        }

        //public abstract void brand();

    }
}
