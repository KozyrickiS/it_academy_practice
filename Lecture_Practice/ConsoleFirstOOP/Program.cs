using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFirstOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Motorcycle moto = new Motorcycle();
            FuelBike fuelBike = new FuelBike();
            fuelBike.ShowVinNumber();
            OverFuelBike overFuelBike = new OverFuelBike();
            //overFuelBike.Move(10);

            Motorcycle bike = new FuelBike() { Distance = 10, Fuel = 23, FuelUsage = 1, Tank = 233, Weight = 34 };
            var type = bike.GetType();
            var baseType = bike.GetType().BaseType;
            Console.WriteLine(type);
            Console.WriteLine(baseType);
            var der = (FuelBike)bike;
            Console.WriteLine(der.Fuel);
            Console.ReadKey();
        }
    }
    public class Motorcycle
    {
        public uint Weight { get; set; }
        public uint Distance { get; set; }

        protected Guid VinNumber { get; private set; }

        public Motorcycle()
        {
            VinNumber = Guid.NewGuid();
        }

        internal virtual void Move(uint km)
        {
            Distance += km;
        }
    }
    internal class FuelBike : Motorcycle
    {
        internal int Tank { get; set; }
        internal float Fuel { get; set; }
        internal float FuelUsage { get; set; }

        internal override void Move(uint km)
        {
            base.Move(km);
            Fuel -= km * FuelUsage / 100;
        }
        internal void ShowVinNumber()
        {
            Console.WriteLine(VinNumber);
        }

    }
    internal class OverFuelBike : FuelBike
    {
        internal float Col { get; set; }

        internal override void Move(uint km)
        {
            base.Move(km);

            Col = Fuel * 10;
        }
    }
}
