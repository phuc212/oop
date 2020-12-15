using System;
namespace zoo_management
{
    public class Cage
    {
        public int cageNumber;
        Animal[] AnimalList = new Animal[0];
        public Cage()
        {
            
        }
        public Cage(int cageNumber)
        {
            this.cageNumber = cageNumber;
        }
        public void AddAnimal(string name, string description, int age, string speak)
        {
            Animal animal = new Animal();
            int choice;
            Console.WriteLine(" 1: tiger");
            Console.WriteLine("2: cat");
            Console.WriteLine("3:dog");
            choice= Int32.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                animal = new Tiger( name,  description,  age,  speak);
                break;
                case 2:
                animal = new cat( name,  description,  age,  speak);
                break;
                case 3:
                animal = new dog( name,  description,  age,  speak);
                break;
            }

            Array.Resize(ref AnimalList,AnimalList.Length +1);
            AnimalList[AnimalList.Length -1] = animal;
        }
        public void RemoveAnimal(string name)
        {
            for (int i = 0; i < AnimalList.Length; i++)
            {
                if(AnimalList[i].Name == name)
                {
                    for (int j = i; j < AnimalList.Length; j++)
                    {
                        AnimalList[j]= AnimalList[j+1];
                    }
                    Array.Resize(ref AnimalList, AnimalList.Length -1);
                }
            }
        }
        public void IterateAnimal()
        {
            Console.Write(AnimalList.Length);
            foreach (var item in AnimalList)
            {
                Console.Write(item.ViewInfor());
            }
        }
    }
}