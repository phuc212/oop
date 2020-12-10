using System;

namespace lop_giai_phuong_trinh_bac_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double delta;
           GiaiPhuongTrinh giaiPhuongTrinh = new GiaiPhuongTrinh(2,4,-6);
           delta = giaiPhuongTrinh.Delta();
           if(delta < 0)
           {Console.WriteLine("phuong trinh vo nghiem");}
           else if(delta > 0)
           {
               Console.WriteLine("phuong tring cos 2 nghiem:");
               Console.WriteLine($"nghiem 1 = {giaiPhuongTrinh.Nghiem1()}");
                Console.WriteLine($"nghiem 2 = {giaiPhuongTrinh.Nghiem2()}");            
           }else
           {Console.WriteLine($"nghiem kep = {giaiPhuongTrinh.Nghiemkep()}")};
        }
    }
    public class GiaiPhuongTrinh
    {
        private double _a ;
        private double _b ;
        private double _c ;

         public double A
    {
        get{ return _a;}
        set{_a = value;}
    }

    public double B
    {
        get{ return _b;}
        set{ _b = value;}
    }

    public double C
    {
        get{ return _c;}
        set{ _c = value;}
    }
    public GiaiPhuongTrinh(){

    }
    public GiaiPhuongTrinh(double a, double b, double c )
    {
        _a = a;
        _b = b;
        _c = c;

    }
    public double Delta ()
    {
        double delta;
         delta = (_b*_b - 4*_a*_c);
         return delta;
    }
    public double Nghiem1()
    {
        return ((- _b - Math.Sqrt(Delta())) / 2 * _a);
    }
    public double Nghiem2 ()
    {
        return  ((- _b + Math.Sqrt(Delta())) / 2 * _a);
    }
    public double Nghiemkep(){
        return -_b/(2*_a);
    }

    }
   
}
