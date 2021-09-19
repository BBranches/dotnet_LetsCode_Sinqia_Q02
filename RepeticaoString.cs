using System;

namespace questao02
{
    class RepeticaoString
    {
        public static void VerificarRepeticaoCaractere(string s1)
        {
            string s2 = ""; 
            foreach (char caractere in s1)
            {
                if (s2.IndexOf(caractere) == -1)
                {
                    s2 += caractere;
                }
            }

            Console.WriteLine($"{s1} >>> {s2}");
        }
    }
}