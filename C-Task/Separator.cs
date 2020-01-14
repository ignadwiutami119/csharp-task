// ========================================================
// Letter separators
// ========================================================

// new Separator("minum susu sapi")
// Expected output: m-i-n-u-m-s-u-s-u-s-a-p-i
//
// new Separator("minum susu sapi", '*')
// Expected output: m*i*n*u*m*s*u*s*u*s*a*p*i

using System;
using System.Text;

namespace ChallengeApp
{
    public class Separator
    {
        public static string Run(string word, char charac)
        {
            // char[] array = word.ToCharArray();
            // int panjang = array.Length;
            // for(int i=0;i<panjang;i++) {
            //     Console.Write("{0}",array[i]);
            //     if (i<panjang-1) {
            //     Console.Write("{0}",charac); 
            //     }
            // }
            // return null;

            string repl = word.Replace(" ",String.Empty);
            var br = string.Join(charac,repl.ToCharArray()); // membuat concate dengan ketentuan parameter : string.Join(karakteryangakanmemisahkan, array)

            foreach (var a in br)
            {
                Console.Write(a);               
            }
            
            return br;
            throw new NotImplementedException();
        }
    }
}
