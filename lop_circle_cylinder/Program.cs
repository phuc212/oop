using System;

namespace lop_circle_cylinder
{
    class Program
    {
        static void Main(string[] args)
        {
           Circle a = new Circle();
           Cylinder b = new Cylinder(3,"xanh",4);
           Console.WriteLine($"{b.AreaCircle()}");

        }
    }
}
