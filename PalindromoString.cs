using System;
using System.Linq;

namespace questao02
{
    class PalindromoString
    {
        public static void VerificarPalindromo(string s1)
        {
            bool palindromo = false;
            int length = s1.Length;
                for (int i = 0; i < length / 2; i++)
                {
                    if (s1[i] != s1[length - i - 1]) {
                        palindromo = false;
                    } else {
                        palindromo = true;    
                    }
                    
                }
            // bool palindromo = s1.SequenceEqual(s1.Reverse());
            if(palindromo) {
                Console.WriteLine($"{s1} é um palíndromo.");
            } else {
                Console.WriteLine($"{s1} não é um palíndromo.");
            }   
        }
    }
}