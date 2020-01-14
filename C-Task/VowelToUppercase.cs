// ========================================================
// Covert all vowel letters into uppercase
// ========================================================
// Input: rasanya otakku semakin keram
// Expected result
// rAsAnyA OtAkkU sEmAkIn kErAm
using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeApp
{
    public class VowelToUppercase
    {
        public static string Run(string word)
        {
            var newstr = new StringBuilder();
            var cr = new HashSet<char>(){'a','i','u','e','o'};
            foreach (var a in word) newstr.Append(cr.Contains(a)? char.ToUpper(a):a);
            Console.WriteLine(newstr);
            return newstr.ToString();
        }
    }
}
