using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    internal class Vehicles
    {
        protected string name;
        protected string manufacturer;
        protected int id;
        protected double mileage;
        protected int years;
        public void read()
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
            Console.WriteLine();
        }
        public void show()
        {
            Console.WriteLine("Pojazd:");
            Console.WriteLine(name);
            Console.WriteLine(manufacturer);
            Console.WriteLine(id);
            Console.WriteLine(mileage);
            Console.WriteLine(years);
            Console.WriteLine();
        }
    }
}
