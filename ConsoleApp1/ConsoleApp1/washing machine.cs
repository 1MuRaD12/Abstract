using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class washing_machine:Electronic
    {
        public string Clothes;

        public washing_machine(int price, byte guarantee,string clothes, byte durability, string color):base(price, guarantee,durability,color)
        {
            Clothes = clothes;
        }
        public override string ToString()
        {
            return $"Price:{Price}, Guarantee:{Guarantee}, Clothes:{Clothes}, Durability:{Durability}, Color:{Color}";
        }

        //public override void brand()
        //{
        //    Console.WriteLine ($"Toshiba");
        //}
    }
}
