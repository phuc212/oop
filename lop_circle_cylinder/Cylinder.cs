namespace lop_circle_cylinder
{
    public class Cylinder : Circle
    {
        private double _height;
        public double Height
        {
            get { return _height; }
            set { _height = value; }
        }
        public Cylinder(){
            
        }
        public Cylinder(double radius, string color, double height) : base(radius,color)
        {
            _height = height;
        }
        public double TheTich(){
            return (AreaCircle()*_height);
        }
        
    }
}