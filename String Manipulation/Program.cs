using System;
using System.Collections.Generic;

namespace String_Manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalNum = 0;

            for (int i = 999 ; i < 1000000; i++)
            {
                string number ="";
                string tempVar = "";

                number = Convert.ToString(i);

                char[] varChar = number.ToCharArray();

                for (int j = varChar.Length-1; j >= 0; j--)
                      tempVar += varChar[j];
                if (tempVar == Convert.ToString(i))
                      Console.WriteLine(i);
            }

        }
    }
}
