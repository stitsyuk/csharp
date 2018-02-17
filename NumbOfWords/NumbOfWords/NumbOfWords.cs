using System;
using System.IO;
using System.Collections;

namespace NumbOfWords
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader objReader = new StreamReader("W6.md");
            var s = "";
            var words = 0;
            ArrayList arrText = new ArrayList();
            s = objReader.ReadLine();
            for (var i = 1; i < s.Length; i++)
            {
                if (s == null)
                    break;
                if (s[i - 1] == ' ')
                {
                    if (s[i] == ' ')
                    {
                        continue;
                    }
                    continue;
                }
                if ((((s[i - 1] >= 'a' && s[i - 1] <= 'z') || (s[i - 1] > 'A' && s[i - 1] < 'Z')) && ((s[i] <= 'a') || ((s[i] >= 'z') && (s[i] < 'A')) || (s[i] > 'Z'))))
                {
                    words++;
                    continue;
                }
                else
                    continue;
            }
            objReader.Close();
            Console.WriteLine("Number of words in W6.md file: " + words);
            Console.ReadLine();
        }
    }
}