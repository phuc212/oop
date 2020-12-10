namespace bt_hcn
{
    
        public class Rectangle{
         private int _height;
         public int Height
         {
             get { return _height; }
             set { _height = value; }
         }
         private int _weight;
         public int Weight
         {
             get { return _weight; }
             set { _weight = value; }
         }
         public Rectangle(){

         }
         public Rectangle(int height, int weight)
         {
             _height = height;
             _weight = weight;
         }
         public int area (){
             return _height*_weight;
         }
         public int Cv (){
             return (_height + _weight)*2;
         }
         public string Display(){
             return "chieu dai " + Height +" chieu rong "+ Weight;
         }
         
         

        }
    
}