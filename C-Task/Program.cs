using System;

namespace ChallengeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------Basic Static--------");
            int[] numbers = { 1, 3, 6, 7, 9, 13, 4 };
            BasicStatistic.FindMax(numbers);
            BasicStatistic.FindMin(numbers);
            BasicStatistic.CalculateAverage(numbers);

            //--------------Flat Array---------------//
            Console.WriteLine("\n");
            Console.WriteLine("--------Flat Array--------");
            FlatArray.Combine();

            //-------------Triangle of Numbers-----------//
            Console.WriteLine("\n");
            Console.WriteLine("------------Triangle of Numbers-----------");
            TriangleOfNumbers.Run(5);

            //-------------Triangle of Stars-----------//
            Console.WriteLine("\n");
            Console.WriteLine("------------Triangle Stars-----------");
            TriangleStars.Run(7);

            //-------------Multiplication Array-----------//
            int[] firstArray = { 1, 3, -5, 4 };
            int[] secondArray = { 1, 4, -5, -2 };
            Console.WriteLine("\n");
            Console.WriteLine("------------Multiplication Array-----------");
            MultiplicationOfTwoArray.MultiplyArray(firstArray, secondArray);

            //-------------Count Duplicate-----------//
            int[] duplicate = { 1, 3, 5, 1, 4, 5, 2, 4, 3, 5, 3, 1 };
            Console.WriteLine("\n");
            Console.WriteLine("------------Count Duplicate-----------");
            HowManyDuplicates.Run(duplicate);

            //-------------Separator------------//
            Console.WriteLine("\n");
            string kata = "minum susu sapi";
            char karakter = '*';
            Console.WriteLine("------------Separator-----------");
            Separator.Run(kata, karakter);

            //-------------To Uppercase-----------//
            Console.WriteLine("\n");
            Console.WriteLine("------------To Uppercase-----------");
            VowelToUppercase.Run("qwertyuiop");


            //-------------Generate Calender-----------//
            Console.WriteLine("\n");
            Console.WriteLine("------------Generate Calendar-----------");
            Console.WriteLine("\n");
            GenerateCalendar.Run(2020, 3);

        }
    }
}
