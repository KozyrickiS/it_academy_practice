using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntArrays
{
    public class ReverseArray
    {
        public static void FirstReverse(int[] array)
        {
            int rev = 0;
            for (int i = 0, j = array.Length - 1; i < array.Length / 2; i++, j--)
            {
                rev = array[i];
                array[i] = array[j];
                array[j] = rev;
            }
        }

        public static void SecondReverse(int[] array)
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
        public static void ThirdReverse(int[] array)
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
