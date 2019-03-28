using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderSol
{
    class Program
    {
        static void Main(string[] args)
        {
            //StringBuilder sb = new StringBuilder();
            //Console.WriteLine(sb.Capacity);
            //Console.WriteLine(sb.Length);
            //Console.WriteLine(sb.MaxCapacity);

            string a = "Hello";
            string b = "HELLO";
            var res = a.Equals(b, StringComparison.OrdinalIgnoreCase);
            Console.WriteLine(res);

            var c = "hello my";
            var d = "helao my";
            var e = string.Compare(c, d);
            Console.WriteLine(e);

            var cult = System.Globalization.CultureInfo.CurrentCulture;
            Console.WriteLine($"{cult.DisplayName}");
            foreach (var item in cult.DateTimeFormat.DayNames)
            {
                Console.Write($"{item} - ");
            }

            Console.ReadKey();
        }
    }
}
