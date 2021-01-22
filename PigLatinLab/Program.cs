using System;
using System.Linq;

namespace PigLatinLab
{
    class Program
    {
        static void Main(string[] args)
        {
            // apple -> appleway - vowel
            // strong -> ongstray - constatant

            Console.WriteLine("Welcome to the Pig Latin Translator!");
            Console.Write("Enter a line to be translated: ");
            string sentence = Console.ReadLine();
            string lowerSentence = sentence.ToLower();
            //Console.Write(lowerSentence);

            //string[] newWords = sentence.Split();
            //int length = newWords.Length;

            //TranslateToPigLatin(lowerSentence);

            const string vowels = "aeiou";
            foreach (string word in lowerSentence.Split())
            {
                string firstLetter = word.Substring(0, 1);
                string restOfWord = word.Substring(1, word.Length - 1);
                int currentLetter = vowels.IndexOf(firstLetter);



                //string[] newWords = new string[word.Length];

                //Console.WriteLine(firstLetter);
                //Console.WriteLine(restOfWord);
                //Console.WriteLine(currentLetter);

                var newWords = "";

                if (currentLetter == -1)
                {
                    newWords += restOfWord + firstLetter + "ay";
                }
                else
                {
                    newWords += word + "way ";
                }

                Console.WriteLine(newWords);

                /*if (currentLetter == -1)
                {
                    new
                }*/


            }

        /*public static string TranslateToPigLatin(string lowerSentence)
        {
            const string vowels = "aeiou";
            foreach (string word in lowerSentence.Split())
            {
                string firstLetter = word.Substring(0, 1);
                string restOfWord = word.Substring(1, word.Length - 1);
                int currentLetter = vowels.IndexOf(firstLetter);

                Console.WriteLine(firstLetter);
                Console.WriteLine(restOfWord);
                Console.WriteLine(currentLetter);

                if (currentLetter == -1)
                {
                    new
                }

                return firstLetter;
                


            }*/

    } 






    }
}
