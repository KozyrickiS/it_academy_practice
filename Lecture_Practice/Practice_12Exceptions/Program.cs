using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_12Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //NullReferenceException
            //StackOverflowException
            //Motorcycle motorcycle = new Motorcycle();
            //motorcycle.Fuel = 17;
            //motorcycle.Date = DateTime.Now;
            //Console.WriteLine(motorcycle.Fuel);

            try
            {
                Motorcycle motorcycle = null;
                motorcycle.Fuel = 17;
                //Console.WriteLine(motorcycle.Fuel);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.GetType()}: Message -{ex.Message}, StackTrace -{ex.StackTrace}");
                //throw;
            }

            Console.WriteLine("AAAAAAA");
            Console.ReadKey();
        }
    }

    class Motorcycle
    {
        //public DateTime Date { get; set; }
        public int Fuel { get; set; }
    }
}
