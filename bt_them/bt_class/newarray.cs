using System;
namespace bt_class
{
    public class Newarray
    {
        private int _number1;
        public int Number1
        {
            get { return _number1; }
            set { _number1 = value; }
        }
        private int _number2;
        public int Number2
        {
            get { return _number2; }
            set { _number2 = value; }
        }
        public Newarray(){

        }
        public Newarray(int number1, int number2)
        {
            _number1 = number1;
            _number2 = number2;
        }
        public int [,] CreateMatrix(int number1, int number2)
        {
            int [,] array = new int [0,0];
            Random arr = new Random();
            for (int i = 0; i < number1  ; i++)
            {
                for (int j = 0; j < number2; j++)
                {
                    array[i,j] = arr.Next(10,101);
                }
            }
            return array;
        }
        public void Display(int [,] array )
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($" {array[i,j]} ");
                }
                Console.WriteLine();
            }
        }
        public int Sum(int [,] array)
        {
            int sum = 0;
               for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                  sum += array[i,j];
                }
            }
            return sum;
        }
        public bool Snt(int a)
        {
            if(a < 2) return false;
            for(int i = 2; i <= Math.Sqrt(a); i++)
            {
                if(a % i == 0) return false;
            }
            return true;
        }
        public int DemSnt(int [,] array)
        {
            int count =0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if( Snt(array[i,j]) )
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        public int Demsole(int[,] array)
        {
            int countSoLe = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i,j] % 2 == 0)
                    {
                        countSoLe += 1;
                    }
                }
            }
             return countSoLe;
        }
        
        public int SumDuongBien(int [,] array)
        {
            int sumDuongBien = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                sumDuongBien += array[i,0];
                sumDuongBien += array[i,array.GetLength(1)-1];     
            }
            for(int j= 1;j < array.GetLength(1)-1 ;j++)
            {
                sumDuongBien += array[0,j];
                sumDuongBien += array[array.GetLength(0)-1,j];

            }
            return sumDuongBien;
            
        }
             
        
    }
}