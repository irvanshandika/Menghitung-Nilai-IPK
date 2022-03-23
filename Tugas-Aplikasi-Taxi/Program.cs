using System;

namespace taxi
{
    class Program
    {
        static void Main(string[] args)
        {
            // pertama membuat objek terlebih dahulu, yaitu Taxi
            Taxi taxi = new Taxi();

            // menentukan nilai properties
            taxi.DriverName = "Jono";
            taxi.OnDuty = true;
            taxi.NumPassenger = 10;

            //membuat method
            taxi.TaxiInfo();
            taxi.PickUpPassenger();
            taxi.DroppOffPassenger();

            Console.ReadKey();
        }
    }
}