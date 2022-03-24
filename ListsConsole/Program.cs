using System;

namespace ListsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //N
            //arr[N]
            //fill this array
            //add new element to the end of this array
            //print result array
            int N;
            string str = Console.ReadLine();
            N = Convert.ToInt32(str);
            int[] array = new int[N];
            for (int i = 0; i <array.Length; i++)
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
            
            Console.WriteLine();
            int[] arr1 = new int[N + 1];
            for (int i = 0; i < array.Length; i++)
            {
                arr1[i + 1] = array[i];
            }

            arr1[0] = 10;
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine(arr1[i]);
            }
        }
    }
}
