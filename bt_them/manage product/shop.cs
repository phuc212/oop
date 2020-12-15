using System;
namespace manage_product
{
    public class Shop
    {
        Product[] productlist = new Product[0];
        public  void AddProduct(string name, double price, string description)
        {
            Product product = new Product(name,price,description);
            Array.Resize(ref productlist,productlist.Length + 1);
            productlist[productlist.Length -1] = product;
        }
        public void RemoveProduct(string name)
        {
            for (int i = 0; i < productlist.Length; i++)
            {
                if(productlist[i].Name == name)
                {
                    for (int j = i; j < productlist.Length -1 ; j++)
                    {
                        productlist[j] = productlist[j +1];
                    }
                    Array.Resize(ref productlist,productlist.Length -1);
                }
            }
        }
        public void ShowProduct()
        {
            foreach (var item in productlist)
            {
                Console.WriteLine(item.infor());
            }
        }
        public void Seachproduct(string name){
            for(int i = 0; i < productlist.Length; i++ )
            {
                if(name == productlist[i].Name)
                {
                    Console.WriteLine(productlist[i].infor());
                    break;
                } else
                {
                    Console.WriteLine("khong có sp trong danh sach");
                }
            }
        }
    }    
    
}