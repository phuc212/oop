using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
           swap Change = new swap();
            Change.a = 5;
            Change.b = 10;
            Change.SwapNumber();
            Console.WriteLine(Change.a);
            Console.WriteLine(Change.b);
        }
    }
    class swap
    {
        public int a;

        public int b;
        public int temp;
        public swap(){

        }
        public void SwapNumber()
        {
        temp = a;
        a=b;
        b=temp;
        }    
    }
}
