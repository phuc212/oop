using System;

namespace bt_ham
{
    class Program
    {
        static void Main(string[] args)
        {

            bool checkInput = false;
            int Input;
            int [,] newArray = new int[0,0];
          

            while (true)
            {
                Menu();
                do
                {
                    Console.WriteLine(" chon menu");
                    checkInput = Int32.TryParse(Console.ReadLine(), out Input);
                } while (!checkInput || Input < 0 || Input > 5);

                switch (Input)
                {
                    case 1:
                    Console.WriteLine(" ma tran da duoc tao");
                    newArray = CreateMatrix(3,3);
                    break;
                    case 2:
                    Console.WriteLine("hien thi ma tran");
                    DisplayMatrix(newArray);
                    break;
                    case 3:
                    Console.WriteLine("tong ma tran");
                    Sum(newArray);
                    break;
                    case 4:
                    Environment.Exit(0);
                    break;
                }
            }



        }
        static int[,] CreateMatrix(int row, int column)
        {
            int[,] array = new int[row, column];
            Random arr = new Random();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    array[i, j] = arr.Next(10, 101);
                }
            }
            return array;
        }
        static void DisplayMatrix(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static int Sum (int[,] array) 
        {
            int sum = 0 ;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                   sum += array[i,j]; 
                }
            }
            return sum;
        }
        static void Menu()
        {
            Console.WriteLine("menu");
            Console.WriteLine("nhap 1: hien trhi ma tran");
            Console.WriteLine("nhap 2: tinh tong ma tran");
            Console.WriteLine("nhap 3: tinh tich ma tran");
            Console.WriteLine("nhap 4: thoat !!!");
        }

    }
}
