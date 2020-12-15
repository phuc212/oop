using System;

namespace manage_product
{
    class Program
    {
        public static Shop shop = new Shop();
        static void Main(string[] args)
        {
            int choice; 
            while (true)
            {
                Menu menus = new Menu();
                 menus.menu();
                 choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        string name;
                        string desc;
                        double price;
                        System.Console.Write("nhap ten sp: ");
                        name = Console.ReadLine();
                        System.Console.Write("nhap mieu ta: ");
                        desc = Console.ReadLine();
                        System.Console.Write("nhap gia: ");
                        price = double.Parse(Console.ReadLine());
                        shop.AddProduct(name, price, desc);
                        break;
                        case 2:
                        Console.WriteLine("danh sach sp");
                        shop.ShowProduct();
                        break;
                        case 3:
                        Console.Write("thong tin sp: ");
                        string seachProduct;
                        seachProduct = Console.ReadLine();
                        shop.Seachproduct(seachProduct);
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                }

            }
        }

    }
}
