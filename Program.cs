using System;

namespace Koriscenje_naredbi_za_konrolu_toka_u_obradi_niza
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] array = { 12, 23, -22, -765, 43, 545, -4, -55, 43, 12, 351, -999, -87 };

            int positiveCount = 0;
            int negativeCount = 0;

            foreach (int num in array)
            {
                if (num > 0) 
                positiveCount++;

                else if (num < 0) 
                negativeCount++;
            }


            int[] positiveArray = new int[positiveCount];
            int[] negativeArray = new int [negativeCount];    

            int posNum = 0;
            int negNum = 0;


            foreach(int num in array)
            {
                if (num > 0) 
                positiveArray[posNum++] = num;

                else if (num < 0)
                negativeArray[negNum++] = num;
            }


            Array.Sort(positiveArray);
            Array.Sort(negativeArray);
           

            Console.Write("Pozitivni brojevi: ");
            foreach (int num in positiveArray) 
            {
                Console.Write(num + " ");
            }


            Console.WriteLine();


            Console.Write("Negativni brojevi: ");
            foreach (int num in negativeArray)
            {
                Console.Write(num + " ");
            }


            Console.WriteLine();




        }







    }




    

}
