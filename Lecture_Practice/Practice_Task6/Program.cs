using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            VoidArray();
            ObjectArray();
            MaxVAlueInArray();
        }
        private static void VoidArray()
        {
            int[] array = new int[0];
            Console.WriteLine(array.Length);
            Console.ReadKey();
        }
        private static void ObjectArray()
        {
            object[] array = new object[3] { 32, 'A', "Hello" };
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("array[i] = " + array[i]);
            }

            //int firstElement = Convert.ToInt32(array[0]);
            int first = (int)array[0] + 10;
            //firstElement += 10;
            array[0] = first;
            string thirdElement = Convert.ToString(array[2]);
            thirdElement += " , guys!";
            array[2] = thirdElement;
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("array[i] = " + array[i]);
            }

            Console.ReadKey();
        }
        private static void MaxVAlueInArray()
        {
            int[] array = new int[13];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(Int32.MinValue, Int32.MaxValue);
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("array[i] = " + array[i]);
            }
            int maxValue = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (maxValue < array[i])
                {
                    maxValue = array[i];
                }
            }
            Console.WriteLine("Max value in our array is : " + maxValue);
            Console.ReadKey();
        }
    }
}
