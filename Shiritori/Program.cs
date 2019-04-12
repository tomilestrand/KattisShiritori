using System;
using System.Collections.Generic;

namespace Shiritori
{
    class Program
    {
        static void Main(string[] args)
        {
            var rounds = int.Parse(Console.ReadLine());
            var usedWords = new HashSet<string>();
            string newWord;
            string oldWord =" ";
            int playerNumber = -1;

            for (int i = 0; i < rounds; i++)
            {
                newWord = Console.ReadLine();
                if (usedWords.Add(newWord) && newWord[0] == oldWord[oldWord.Length-1] || i == 0)
                {
                    oldWord = newWord;
                }
                else
                {
                    playerNumber = i % 2;
                    break;
                }
            }
            if (playerNumber == -1)
            {
                Console.WriteLine("Fair Game");
            }
            else
            {
                Console.WriteLine($"Player {playerNumber+1} lost");

            }
        }
    }
}
