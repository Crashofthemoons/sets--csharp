using System;
using System.Collections.Generic;

namespace dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> showroom = new HashSet<string>();
                showroom.Add("Jeep");
                showroom.Add("Honda");
                showroom.Add("Toyota");
                showroom.Add("Mazda");


                showroom.Add("Jeep");

            HashSet<string> usedLot = new HashSet<string>();
                usedLot.Add("Truck");
                usedLot.Add("SUV");
                showroom.UnionWith(usedLot);
                showroom.Remove("SUV");
            foreach (var car in showroom)
            {
                Console.WriteLine(car);
            }
        }
    }
}
