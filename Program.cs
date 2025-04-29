using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicles vehicles = new Vehicles();
            vehicles.read();
            vehicles.show();
            Cars cars = new Cars();
            cars.read1();
            cars.show1();
            Console.ReadKey();
        }
    }
}
