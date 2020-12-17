using System;
namespace lop_circle_cylinder
{
    public class Circle
    {
        private double _radius;
        public double Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }
        private string _color;
        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }
      public Circle(){

      }
     public Circle(double radius, string color){
         _radius = radius;
         _color = color;
     }
     public double AreaCircle(){
         return (_radius*_radius * Math.PI);
     }
    }
}