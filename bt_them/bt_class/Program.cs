using System;

namespace bt_class
{
    class Program
    {
        static void Main(string[] args)
        {
          int[,] arr = {
              {2,3,4},
              {3,2,4,},
              {4,3,1}
              };
              Newarray newarray = new Newarray();
             Console.WriteLine(newarray.SumDuongBien(arr));
        }
    }
}
