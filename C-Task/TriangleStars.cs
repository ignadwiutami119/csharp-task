// ========================================================
// Generate triangle
// ========================================================
//
// TriangleStars(5);
//
// Expected result
// *
// **
// ***
// ****
// *****
//
// TriangleStars(2);
//
// Expected result
// *
// **

using System;

namespace ChallengeApp
{
    public class TriangleStars
    {
        public static string Run(int input)
        {   
            string hasil = "";
            int count = input;
            for(int i=1;i<=input;++i) {
                
                for(int j=1;j<=i;++j){
                    Console.Write("*");
                    hasil += "*";
                } 
                Console.Write("\n");
                hasil += "\n";
            }
            return hasil;
                    
             throw new NotImplementedException();
        }
    }
}
