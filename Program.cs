using System;

namespace oop
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle newRec = new Rectangle();
            newRec.Width = 10;
            newRec._height = 20;
            Console.Write(newRec.Display());
        }
    }
    public class Rectangle{
        private double _width {get;set;}
        public double _height {get;set;}

        public double Width
        {
            get ; set;
        }

        public double Height
        {
            get {return _height;}
            set {_height = value;}
        }
        public Rectangle(){

        }
        public Rectangle(double width, double height) 
        {
            _width = width;
            _height = height;
        }
        public double GetArea()
        {
            return Width*Height;
        }
        public double GetPerimetter() 
        {
            return (Width*Height)*2;
        }
        public string Display()
        {
            return $"rectangle(width: {_width}, height: {Height})";
        } 
    }
}
