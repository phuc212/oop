using System;
namespace zoo_management
{
    public class Zoo
    {
        Cage[] CageList = new Cage[0];
        public void AddCage(int cageNumber)
        {
            Cage cage = new Cage();
            Array.Resize(ref CageList,CageList.Length + 1 );
            CageList[CageList.Length - 1] = cage;
        }
        public void  RemoveCage(int number)
        {
            for (int i = 0; i < CageList.Length; i++)
            {
                if(CageList[i].cageNumber == number)
                {
                    for (int j = 0; j < CageList.Length; j++)
                    {
                        CageList[j] = CageList[CageList.Length + 1];
                    }
                    Array.Resize(ref CageList, CageList.Length - 1);
                }
            }
        }
    }
}