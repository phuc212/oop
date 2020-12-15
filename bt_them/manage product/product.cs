namespace manage_product
{
    public class Product
    {
     private string _name;
     public string Name
     {
         get { return _name; }
         set { _name = value; }
     }
     private double _price;
     public double Price
     {
         get { return _price; }
         set { _price = value; }
     }
     private string _description;
     public string Description
     {
         get { return _description; }
         set { _description = value; }
     }
     int[ ] rate = new int[0];
     public string infor()
     {
         return $"{_name}\t\t{_price}\t\t{_description}";
     }
   
     public Product(string name, double price, string description)
     {
         _name = name;
         _price = price;
         _description = description;
     }


     
     
     
    }
}