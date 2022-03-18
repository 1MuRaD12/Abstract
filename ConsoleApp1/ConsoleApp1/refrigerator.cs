using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Refrigerator:Electronic
    {
        public string Food;
       
        public Refrigerator(int price, byte guarantee, string food, byte durability, string color) :base (price,guarantee,durability,color)
        {
                Food = food;
        }
        public override string ToString()
        {
            return $"Price:{Price}, Guarantee:{Guarantee}, Food:{Food}, Durability:{Durability}, Color:{Color}";
        }

        //public override void brand()
        //{
        //    Console.WriteLine($"Beko");
        //}
    }
}
