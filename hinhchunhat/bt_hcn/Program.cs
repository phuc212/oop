using System;

namespace bt_hcn
{
    class Program
    {
        static void Main(string[] args)
         {
            int a;
            int b;
        System.Console.WriteLine("nhap a");
        a =Int32.Parse(Console.ReadLine());
        System.Console.WriteLine("nhap b");
        b = Int32.Parse(Console.ReadLine());
         Rectangle rectangle = new Rectangle(a,b);
        //  rectangle.Weight=5;
        //  rectangle.Height=4;

         System.Console.WriteLine($"dien tich = {rectangle.area()}" );
         Console.WriteLine(rectangle.Display());
         Console.WriteLine($"chu vi hcn la {rectangle.Cv()}");


        }
    }
}
