using ListsLibrary;
using System;

namespace ListsConsole
{
    class Program
    {
        static void T1()
        {

            int N;
            string str = Console.ReadLine();
            N = Convert.ToInt32(str);
            int[] array = new int[N];

            for (int i = 0; i < N; i++)
            {
                str = Console.ReadLine();
                array[i] = Convert.ToInt32(str);
            }

            Console.WriteLine();
            // int[] arr = new int[N + 1];
            // for (int i = 0; i < array.Length; i++)
            //{
            //  arr[i] = array[i];
            //}

            //arr[arr.Length - 1] = 10;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //   Console.WriteLine(arr[i]);
            //}

            // Console.WriteLine();
            // int[] arr1 = new int[N + 1];
            // for (int i = 0; i < array.Length; i++)
            // {
            //    arr1[i + 1] = array[i];
            // }

            // arr1[0] = 10;
            // for (int i = 0; i < arr1.Length; i++)
            // {
            //     Console.WriteLine(arr1[i]);
            // }

            int M;
            string str1 = Console.ReadLine();
            M = Convert.ToInt32(str1);
            int[] array1 = new int[M];

            for (int j = 0; j < array1.Length; j++)
            {
                str1 = Console.ReadLine();
                array1[j] = Convert.ToInt32(str1);
            }

            Console.WriteLine();

            int[] arr2 = new int[N + M];
            for (int i = 0; i < N; i++)
            {
                arr2[i] = array[i];
            }

            for (int j = 0; j < array1.Length; j++)
            {
                arr2[j + N] = array1[j];
            }

            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine(arr2[i]);
            }
        }

        static void Main(string[] args)
        {
            ArrayList aList = new ArrayList();
            ArrayList bList = new ArrayList(10);

            aList.AddBack(10);
            aList.AddBack(20);
            aList.AddBack(30);
            aList.AddByIndex(1, 5);
            aList.AddByIndex(0, 2);
            aList.AddByIndex(5, 100);
            foreach (var item in aList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(aList.IndexOf(120));
        }
    }
}
