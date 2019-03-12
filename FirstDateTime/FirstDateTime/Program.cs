using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan time = DateTime.Now.TimeOfDay;
            if (time.Hours > 9 && time.Hours < 12)
            {
                Console.WriteLine("Good morning, guys");
            }
            else if (time.Hours >= 12 && time.Hours <= 15)
            {
                Console.WriteLine("Good day, guys");
            }
            else if (time.Hours > 15 && time.Hours <= 22)
            {
                Console.WriteLine("Good evening guys");
            }
            else
            {
                Console.WriteLine("Go back to sleep");
            }
            Console.ReadKey();
        }
    }
}
