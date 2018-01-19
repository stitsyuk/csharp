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
            var sLine = "";
            var words = 0;
            string[] text;
            ArrayList arrText = new ArrayList();
            while (sLine != null)
            {
                sLine = objReader.ReadLine();
                if (sLine == null)
                    break;
                text = sLine.Split(' ');
                Console.WriteLine("Number of words in this line: " + text.Length); /*I leave this sentence for you that you can see what he sees like words.
                You can check every line. Where 1 is written there are empty lines and he sees ' ' as a word.*/
                words += text.Length;
                arrText.Add(sLine);
            }
            objReader.Close();
            Console.WriteLine("Number of words in W6.md file: " + words);
            Console.ReadLine();
        }
    }
}