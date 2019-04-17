using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your array: ");
            int[] arr = new int[6];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Your array is: ");
            foreach (int a in arr)
            {
                Console.Write(a + " ");
            }

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
            ReverseArray.FirstReverse(firstInhArr);
            watchF.Stop();
            Console.WriteLine("first function time : " + watchF.Elapsed);

            var watchS = Stopwatch.StartNew();
            ReverseArray.SecondReverse(secondinhArr);
            watchS.Stop();
            Console.WriteLine("second function time : " + watchS.Elapsed);

            var watchT = Stopwatch.StartNew();
            ReverseArray.ThirdReverse(thirdInhArr);
            watchT.Stop();
            Console.WriteLine("third function time : " + watchT.Elapsed);
            Console.ReadKey();

            Console.ReadKey();
        }
    }
}
