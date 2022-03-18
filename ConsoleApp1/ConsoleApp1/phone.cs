using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class phone:Electronic
    {
        public string Camera;
        public byte Ram;
        public int Memory;
        public phone(int price, byte guarantee, byte durability, string color, string camera, byte ram, int memory):base(price,guarantee,durability,color)
        {
            Camera = camera;
            Ram = ram;
            Memory = memory;
           
        }
        public override string ToString()
        {
            return $"Price:{Price}, Guarantee:{Guarantee}, Durability:{Durability}, Color:{Color}, Camera:{Camera}, Ram:{Ram}, Memory:{Memory}";
        }

        //public override void brand()
        //{
        //    Console.WriteLine($"iphone");
        //}
    }
}
