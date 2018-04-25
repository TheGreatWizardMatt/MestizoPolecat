using System;
using ModelingSandbox;

namespace ModelDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();

            Area area = new Area();

            Person vickie = new Person();
            vickie.Name = "Vickie";

            Location personStartLocation01 = new Location();
            personStartLocation01.X = 0;
            personStartLocation01.Y = 0;
            
            ManagerMessage response = manager.AddPerson(ref vickie, personStartLocation01);
            if (response.Success)
            {
                Console.WriteLine(response.Message);
            }

            Person mindy = new Person();
            mindy.Name = "Mindy";

            Location personStartLocation02 = new Location();
            personStartLocation02.X = 10;
            personStartLocation02.Y = 10;

            response = manager.AddPerson(ref mindy, personStartLocation02);
            if (response.Success)
            {
                Console.WriteLine(response.Message);
            }

            Console.ReadLine();
        }
    }
}
