using System;

namespace questao02
{
    class InverterString
    {
        public static void TrocarCarateres(string s1)
        {
          int length = s1.Length;
          string s2 = "";
          // char[] chars = new char[length];

          if(length % 2 == 0) {
            for (int i = 0; i < length; i++) {
              if(i % 2 == 0) {
                //chars[length - (length - i)] = s1[length - (length -i) + 1];
                s2 += s1[length - (length -i) + 1];
              } else {
                s2 += s1[length - (length -i) - 1];
              }
            }
          } else {
              for (int i = 0; i < length; i++)
              {
                s2 += s1[length - i - 1];
              }
            }
          //string s2 = new String(chars);
          Console.WriteLine($"{s1} >>> {s2}");  
        }
    }
}