using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Motorcycle moto = new Motorcycle();
            MotorcycleNotifyHandler notifyHandler = new MotorcycleNotifyHandler(ShowMessage);
            moto.RegisterHandler(notifyHandler);

            moto.Move(1000);
            moto.Move(19500);

            Console.ReadKey();
        }

        public static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
