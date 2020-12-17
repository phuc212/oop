using System;

namespace zoo_management
{
    class Program
    {
        public static Animal animal = new Animal();
        public static Cage cage = new Cage();
        
      
        public static Zoo zoo = new Zoo();
        static void Main(string[] args)
        {
        

            int choice;
            while(true)
            {
                Menu menu = new Menu();
                menu.menu();
                choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                case 1:
                int number;
                Console.Write("nhap so cage");
                number = Int32.Parse(Console.ReadLine());
                zoo.AddCage(number);
                break;
                case 2:
                removecage();
                break;
                case 3:
                addanimal();
                break;
                case 4:
                removeanimal();
                break;
                case 5:
                IterateAnimal();
                break;
                case 6:
                Environment.Exit(0);
                break;
                
                }
            }
        }
        public void addcage(){
            int number;
            Console.Write("nhap so cage");
            number = Int32.Parse(Console.ReadLine());
            zoo.AddCage(number);
        }
        public static void removecage()
        {
            int number;
            Console.Write("nhap cage can xoa");
            number = Int32.Parse(Console.ReadLine());
            zoo.RemoveCage(number);
        }
        public static void addanimal()
        {
           string name;
            string description;
           int age; 
           string speak;

            System.Console.Write("nhap ten : ");
            name = Console.ReadLine();

            System.Console.Write("nhap mieu ta: ");
            description = Console.ReadLine();

            System.Console.Write("nhap tuoi: ");
            age = int.Parse(Console.ReadLine()); 

            Console.Write("nhap tieng keu");
            speak = Console.ReadLine();

            for (int i = 0; i < zoo.CageList.Length; i++)
            {
                Console.WriteLine($"{i + 1}. Cage {zoo.CageList[i].cageNumber}");
            }
            Console.Write("Please choose cage to put animal: ");
            int choice = int.Parse(Console.ReadLine());
            choice = choice - 1;
            zoo.CageList[choice].AddAnimal(name,description,age,speak);
         
        }
        public static void removeanimal()
        {
            string name;
            Console.Write("nhap animal can xoa");
            name = Console.ReadLine();
            cage.RemoveAnimal(name);
        }
          public static void IterateAnimal()
        {
            for (int i = 0; i < zoo.CageList.Length; i++)
            {
                for (int j = 0; j < zoo.CageList[i].AnimalList.Length; j++)
                {
                    Console.Write(zoo.CageList[i].AnimalList[j].ViewInfor());
                }
            }  
            // for (int i = 0; i < cage.AnimalList.Length; i++)
            // {
            //     Console.Write(cage.AnimalList[i].ViewInfor());
            // }
        }
       
    }
}
