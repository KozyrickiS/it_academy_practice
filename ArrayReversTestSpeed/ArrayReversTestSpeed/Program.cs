using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayReversTestSpeed
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of array you want: ");
            int numbElements = Convert.ToInt32(Console.ReadLine());
            int[] parentArray = new int[numbElements];
            for (int i = 0; i < parentArray.Length; i++)
            {
                parentArray[i] = Int16.MaxValue;
            }
            int[] firstInhArr = parentArray;
            int[] secondinhArr = parentArray;
            int[] thirdInhArr = parentArray;
            Console.WriteLine($"Checked testspeed on {numbElements} numbers");

            var watchF = Stopwatch.StartNew();
            FirstReverse(firstInhArr);
            watchF.Stop();
            Console.WriteLine("first function time : " + watchF.Elapsed);

            var watchS = Stopwatch.StartNew();
            SecondReverse(secondinhArr);
            watchS.Stop();
            Console.WriteLine("second function time : " + watchS.Elapsed);

            var watchT = Stopwatch.StartNew();
            ThirdReverse(thirdInhArr);
            watchT.Stop();
            Console.WriteLine("third function time : " + watchT.Elapsed);
            Console.ReadKey();
        }

        private static void FirstReverse(int[] array)
        {
            int rev = 0;
            for (int i = 0, j = array.Length - 1; i < array.Length / 2; i++, j--)
            {
                rev = array[i];
                array[i] = array[j];
                array[j] = rev;
            }
        }

        private static void SecondReverse(int[] array)
        {
            int rev = 0;
            int leng = array.Length - 1;
            for (int i = 0; i < array.Length / 2; i++)
            {
                rev = array[i];
                array[i] = array[leng - i];
                array[leng - i] = rev;
            }
        }
        private static void ThirdReverse(int[] array)
        {
            int[] newArray = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[array.Length - 1 - i];
            }
            array = newArray;
        }
    }
}
