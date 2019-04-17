using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Motorcycle moto = new Motorcycle();
            //Motorcycle moto;
            moto.Name = "Moto";
            var type = moto.GetType();
            //Object obj;
            Console.WriteLine(moto.GetHashCode());
            Console.WriteLine(moto.GetType());*/
            int counters = 0;
            Rectangle[] rectangles = new Rectangle[100];
            Random random = new Random();
            for (int i = 0; i < rectangles.Length; i++)
            {
                rectangles[i].height = random.Next(1, 100);
                rectangles[i].weigth = rectangles[i].height;
            }
            Rectangle rect = rectangles[0];
            for (int i = 0; i < rectangles.Length; i++)
            {
                if (rect.Equals(rectangles[i]))
                    counters++;
            }
            Console.WriteLine(counters);
            Console.WriteLine(Moto.One);
            Moto m = new Moto();
            m = Moto.Two;
            Console.WriteLine(m);
            Console.WriteLine((int)m);

            var moto = new
            {
                Name = "Honda",
                Year = 2000,
                Odometr = 3500
            };
            Console.WriteLine(moto);
            Console.WriteLine($" n - {moto.Name} {moto.Year} {moto.Odometr}");
            Console.WriteLine(moto.GetType());
            Console.WriteLine(moto.GetHashCode());
            Console.ReadKey();
        }
        public enum Moto
        {
            One,
            Two
        }
        struct Motorcycle
        {
            public string Name { get; set; }
        }
        struct Rectangle
        {
            public int height { get; set; }
            public int weigth { get; set; }
        }
    }
}
