using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice15_Delegate
{
    delegate void Feedback(int value);

    delegate void SendMessage();
    delegate int CalcPluss(int num1, int num2);

    class Program
    {
        static void Main(string[] args)
        {
            //SendMessage sendMessage = new SendMessage(ShowMessage);
            SendMessage sendMessage = ShowMessage;
            sendMessage();

            Program program = new Program();
            CalcPluss calcPluss = program.Add;

            var result = calcPluss.Invoke(23, 45);
            var res = calcPluss(23, 45);
            Console.WriteLine(res);

            Console.ReadLine();
        }

        static void ShowMessage()
        {
            Console.WriteLine("Message ...");
        }

        static void ShowAnotheMessage(string str)
        {
            Console.WriteLine(str);
        }

        int Add(int arg1, int arg2)
        {
            return (arg1 + arg2);
        }
    }
}
