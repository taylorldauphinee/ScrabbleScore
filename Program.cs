using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Program.cs
/// June 12, 2021
/// Written by Taylor Dauphinee
/// A script to take a word and determine its scrabble score
/// </summary>

namespace ScrabbleScore
{
    class Program
    {
        static Dictionary<char, int> scrabbleTiles = new Dictionary<char, int>();

        // set up the tile value dictionary
        static void SetTileValues()
        {
            scrabbleTiles.Add('A', 1);
            scrabbleTiles.Add('B', 3);
            scrabbleTiles.Add('C', 3);
            scrabbleTiles.Add('D', 2);
            scrabbleTiles.Add('E', 1);
            scrabbleTiles.Add('F', 4);
            scrabbleTiles.Add('G', 2);
            scrabbleTiles.Add('H', 4);
            scrabbleTiles.Add('I', 1);
            scrabbleTiles.Add('J', 8);
            scrabbleTiles.Add('K', 5);
            scrabbleTiles.Add('L', 1);
            scrabbleTiles.Add('M', 3);
            scrabbleTiles.Add('N', 1);
            scrabbleTiles.Add('O', 1);
            scrabbleTiles.Add('P', 3);
            scrabbleTiles.Add('Q', 10);
            scrabbleTiles.Add('R', 1);
            scrabbleTiles.Add('S', 1);
            scrabbleTiles.Add('T', 1);
            scrabbleTiles.Add('U', 1);
            scrabbleTiles.Add('V', 4);
            scrabbleTiles.Add('W', 4);
            scrabbleTiles.Add('X', 8);
            scrabbleTiles.Add('Y', 4);
            scrabbleTiles.Add('Z', 10);
        }

        static void Main(string[] args)
        {
            // variables
            string givenWord;
            char[] brokenWord;
            int totalScore = 0;

            SetTileValues();

            // ask for word input
            Console.WriteLine("Type a word here:");
            givenWord = Console.ReadLine();

            // convert the string to a character array
            brokenWord = givenWord.ToCharArray();

            // read each character and add to the score
            foreach(char letter in brokenWord)
            {
                // check if the tile is legal
                if (!scrabbleTiles.TryGetValue(Char.ToUpper(letter), out int score))
                {
                    Console.WriteLine(letter + " is not a valid scrabble tile.");
                    totalScore = 0;
                    Console.ReadKey(true);
                    return;
                }
                totalScore += score;
            }

            Console.WriteLine("Your scrabble score is " + totalScore);

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey(true);
        }
    }
}
