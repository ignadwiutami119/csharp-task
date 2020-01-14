// ========================================================
// Multiplication of two arrays
// ========================================================

// int[] firstArray = {1, 3, -5, 4};
// int[] secondArray = {1, 4, -5, -2};
//
// MultiplyArray(firstArray, secondArray)
//
// Expected result { 1, 12, 25, -8 }

using System;

namespace ChallengeApp
{
    public class MultiplicationOfTwoArray
    {
        public static int[] MultiplyArray(int[] array1, int[] array2) {
        
        int panjang = array1.Length;
        int[] hasil = new int[panjang];
        
        for(int i=0;i<panjang;i++)
        {
            hasil[i] = array1[i]*array2[i];
            Console.WriteLine("{0}",hasil[i]);
         }
        return hasil;
        throw new NotImplementedException();
       
        }
    }
}
