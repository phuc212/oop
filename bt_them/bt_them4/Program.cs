using System;

namespace bt_them4
{
    class Program
    {
        static PhoneBook contact = new PhoneBook();
        static void Main(string[] args)
        {
           int choice;
           bool checkInput = false;
           while(true)
           {
               do
               {
                Menu();
                checkInput = int.TryParse(Console.ReadLine(), out choice);
               } while (!checkInput || choice < 0 || choice > 7 );
               switch(choice)
               {
                   case 1:
                addContact();
                   break;
                   case 2:
                   updateContact();
                   break;
                   case 3:
                   removeContact();
                   break;
                   case 4:
                   seachContact();
                   break;
                   case 5:
                   System.Console.WriteLine("list contacts ");
                   contact.ShowContact();
                   break;
                   case 6:
                   Environment.Exit(0);
                   break;
               }
           }
        }
        static void Menu(){
            System.Console.WriteLine("=============menu===========");
            System.Console.WriteLine("1: Add Contact ");
            System.Console.WriteLine("2:Update Contact ");
            System.Console.WriteLine("3 Remove Contact ");
            System.Console.WriteLine("4  Search Contract ");
            System.Console.WriteLine("5. Show Contacts ");
            System.Console.WriteLine("6. Exit ");
        }
        static void addContact(){
                string ten;
                int num;
                bool checkNum = false;
                    System.Console.WriteLine("nhap ten ");
                    ten = Console.ReadLine();
                    do
                    {
                        System.Console.WriteLine("nhap so ");
                        checkNum =int.TryParse(Console.ReadLine(), out num);
                    } while (!checkNum);
                  
                    contact.AddContact(ten, num);
        }
        static void updateContact(){
            string name;
            int newNum;
            bool checkNewNum = false;
            Console.WriteLine("nhap ten can update");
            name = Console.ReadLine();
           do
           {
                Console.WriteLine("sua number");
               checkNewNum = int.TryParse(Console.ReadLine(), out newNum);
           } while (!checkNewNum);
            contact.UpdateContact(name,newNum);

        }
        static void removeContact(){
            string name;
            Console.WriteLine("nhap ten càn xóa");
            name = Console.ReadLine();
            contact.RemoveContact(name);
        }
        static void seachContact(){
            string name;
            System.Console.WriteLine("nhap ten can tim kiem");
            name = Console.ReadLine();
            contact.SeachContact(name);
        }
    }
}
