// ========================================================
// Basic statistics - WITHOUT LINQ
// ========================================================

// int[] numbers = {5, 2, 5, 77, 100, 31, 3, -13, 4, 0, -19};
//
// FindMax(numbers);
//
// FindMin(numbers);
//
// CalculateAverage(numbers);
//
// CalculateTotal(numbers);

using System;

namespace ChallengeApp
{
    public class BasicStatistic
    {
        public static int FindMax(int[] numbers)
        {
            // Console.Write("Input the number :");
	        // numbers[] = Convert.ToInt32(Console.ReadLine()); 
            // Find maximum value "without" using LINQ
           var panjang = numbers.Length;
           int max = numbers[0];   

            for(int i=1;i<panjang;i++) {
                
                if(numbers[i]> max) {
                   max = numbers[i];
                }
            }
            
            Console.WriteLine(max);
            return max;
            throw new NotImplementedException();
        }

        public static int FindMin(int[] numbers)
        {
           var panjang = numbers.Length;
           int min = numbers[0];
            // Find minimum value "without" using LINQ
        
            for(int i=1;i<panjang;i++) {
                
                if(numbers[i]< min) {
                   min = numbers[i];
                }
            }
         
            Console.WriteLine(min);
            return min;
            throw new NotImplementedException();
            
        }

        public static int CalculateAverage(int[] numbers)
        {
            var panjang = numbers.Length;
        
            // Calculate average value "without" using LINQ
            int hasil1 = CalculateTotal(numbers);
            int hasilAverage = hasil1/panjang;
            
            Console.WriteLine(hasilAverage);
            return hasilAverage;

            throw new NotImplementedException();
        }

        public static int CalculateTotal(int[] numbers)
        {
            // Calculate total value "without" using LINQ
            int hasil=0;
            int panjang = numbers.Length;
            for(int i=0;i<panjang;i++) {
                hasil = hasil + numbers[i];
                }
            Console.WriteLine(hasil);
            return hasil;
            throw new NotImplementedException();
        }
    }
} 
