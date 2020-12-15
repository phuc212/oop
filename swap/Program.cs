using System;

namespace swap
{
    class Program
    {
        static void Main(string[] args)
        {
            // int a=5;
            // int b=7;
            // Console.WriteLine("ban dau",a,b);
            // swap(ref a,ref b);
            System.Console.WriteLine(FindPrime(10,20));

        }
        //   static void swap(int n1,int n2)
        // {
        //     int temp;
        //     temp = n1;
        //     n1 = n2;
        //     n2 = temp;
            
        // }
        static int FindPrime(int start, int end)
        {
            bool check = true;
            for(int i = start; i<=end; i++)
            {
                for(int j =2; j < i; j++)
                {
                    if( i % j == 0)
                    {
                        check = false ;
                    }
                    if(check == true)
                    {
                        return i;
                    }
                    check = true;
                }
                return 0;
            }
        }
    }
}
