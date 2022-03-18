using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            washing_machine washing_Machine = new washing_machine(2000, 2, "clothes", 3, "white");
            Console.WriteLine(washing_Machine.ToString());
            Console.WriteLine("\n___________________________________________________________________________________\n");
            Refrigerator refrigerator = new Refrigerator(1500, 1, "food", 3, "blue");
            Console.WriteLine(refrigerator.ToString());
            Console.WriteLine("\n___________________________________________________________________________________\n");
            phone phone = new phone(2000, 1, 1, "black", "20mp", 16, 500);
            Console.WriteLine(phone.ToString());
            Console.WriteLine("\n___________________________________________________________________________________\n");
           

            
        }
    }
}
