using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    internal class Cars:Vehicles
    {
        private string engine;
        private string color;
        public void read1()
        {
            Console.WriteLine("Podaj nazwe: ");
            name = Console.ReadLine();
            Console.WriteLine("Podaj producenta: ");
            manufacturer = Console.ReadLine();
            Console.WriteLine("Podaj id: ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj przebieg: ");
            mileage = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj rok: ");
            years = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj silnik: ");
            engine = Console.ReadLine();
            Console.WriteLine("Podaj kolor: ");
            color = Console.ReadLine();
            Console.WriteLine();
        }
        public void show1()
        {
            Console.WriteLine("Auto:");
            Console.WriteLine(name);
            Console.WriteLine(manufacturer);
            Console.WriteLine(id);
            Console.WriteLine(mileage);
            Console.WriteLine(years);
            Console.WriteLine(engine);
            Console.WriteLine(color);
            Console.WriteLine();
        }
    }
}
