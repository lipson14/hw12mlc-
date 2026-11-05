using System;
using System.Collections.Generic;
using System.Text;

namespace hw12ml
{
    internal static class ArrayHelper
    {
        public static void PrintReverse<T>(this T[] array)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }

        }


        public static T GetFirstElement<T>(this T[] array)
        {
            return array[0];
        }


        public static T GetLastElement<T>(this T[] array)
        {
            return array[array.Length - 1];
        }


        public static bool ContainsElement<T>(this T[] array, T el)
        {
            foreach (var item in array)
            {
                if (item.Equals(el))
                {
                    return true;
                }

            }
            return false;
        }


        public static int CountElements<T>(this T[] array)
        {
            int count = 0;
            foreach (var item in array)
            {
                count++;
            }

            return count;
        }

        

        public static int FindIndex<T>(this T[] array, T el)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(el))
                {
                    return i;
                }
            }

            return -1;
        }

        public static T[] Swap<T>(this T[] array, int index1, int index2)
        {
            T temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;

            return array;
        }

    }
}
