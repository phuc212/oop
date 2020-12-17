using System;

namespace lop_stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[100000];
            Random arrRandom = new Random();
            for( int i =0; i < arr.Length; i++)
            {
                arr[i] = arrRandom.Next(1,1001);
            }
            Stopwatch runStopwatch = new Stopwatch();
            runStopwatch.Start();
            sortArr(ref arr);
            runStopwatch.Stop();
            
            Console.WriteLine($"{runStopwatch.GetElapsedTime()}");

        }
        static int[] sortArr(ref int[] array)
        {
            for(int i= 0; i < array.Length; i++)
            {
                int minIndex = i;
                for(int j = i; j < array.Length; j++)
                {
                    if(array[minIndex] > array[j]) minIndex = array[j];

                }
                int temp = array[i];
                array[i] = array[minIndex];
                array[minIndex] = temp;
            }
            return array;  
        }
    }
}
