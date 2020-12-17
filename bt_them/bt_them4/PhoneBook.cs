using System;
namespace bt_them4
{
    public class PhoneBook
    {
        Contact[] ContactList = new Contact[0];
        public void AddContact(string name, int number){
            Contact contact = new Contact(name,number);
            Array.Resize(ref ContactList, ContactList.Length + 1);
            ContactList[ContactList.Length - 1] = contact;
        }
        public void RemoveContact(string name)
        {
             for (int i = 0; i < ContactList.Length; i++)
            {
                if(ContactList[i].Name == name)
                {
                    for (int j = i; j < ContactList.Length -1 ; j++)
                    {
                        ContactList[j] = ContactList[j +1];
                    }
                    Array.Resize(ref ContactList,ContactList.Length -1);
                }
            }
        }
        public void SeachContact(string name)
        {
             for(int i = 0; i < ContactList.Length; i++ )
            {
                if(name == ContactList[i].Name)
                {
                    Console.WriteLine(ContactList[i].Info());
                    break;
                } else
                {
                    Console.WriteLine("Not exists");
                }
            }
        }
        public void ShowContact()
        {
            foreach (var item in ContactList)
            {
                Console.WriteLine(item.Info());
            }
        }
        public bool CheckContact(string name, out int index)
        {
            for (int i = 0; i < ContactList.Length; i++)
            {
                if(name == ContactList[i].Name){
                index = i;
                return true;
                }
            }
            index = -1;
            return false;
        }
        public void UpdateContact(string name, int newNumber)
        {
            if(CheckContact(name, out int index))
            {
               ContactList[index].Number = newNumber; 
            }
        }
    }
}