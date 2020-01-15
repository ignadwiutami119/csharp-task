// ========================================================
// How many duplicates
// ========================================================

// int[] dups = {1, 3, 5, 1, 4, 5, 2, 4, 3, 5, 3, 1};
//
// Expected result
// 1 -> 3x
// 2 -> 1x
// 3 -> 3x
// 4 -> 2x
// 5 -> 2x

using System;
using System.Collections.Generic;

namespace ChallengeApp
{
    public class HowManyDuplicates
    {
        public static string Run(int[] arr)
        {
            var diction = new Dictionary<int,int>();
            foreach(int kunci in arr) {
                if(diction.ContainsKey(kunci))
                {
                    diction[kunci]++; //get or set the element value in spesific key
                }
                else
                {
                    diction[kunci]=1; //get or set the element value in spesific key
                }
            }

            string stc="";
            foreach(var match in diction)
            {
                Console.WriteLine("jumlah {0} sebanyak {1}",match.Key, match.Value);
                stc+="jumlah "+ match.Key +" sebanyak "+ match.Value+"\n";
            }
            return stc;
            throw new NotImplementedException();
        }
    }
}
