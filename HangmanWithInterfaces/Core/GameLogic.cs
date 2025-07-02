using HangmanWithInterfaces.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanWithInterfaces.Core
{
    public class GameLogic : IGameLogic
    {
        private WordGenerator WordGenerator { get; set; }
        private GameGraphics GameGraphics { get; set; }
        private Difficulty Difficulty { get; set; }
        public GameLogic(WordGenerator wordGenerator, GameGraphics gameGraphics, Difficulty difficulty)
        {
            WordGenerator = wordGenerator;
            GameGraphics = gameGraphics;
            Difficulty = difficulty;
        }
        public void Game(int difficulty)
        {
            string wordToGuess = WordGenerator.GetRandomWord(difficulty);
            char[] guessedWord = new string('_', wordToGuess.Length).ToCharArray();
            var lives = 6;
            List<char> guessedLetters = new List<char>();

            while (lives > 0 && new string(guessedWord) != wordToGuess)
            {
                Console.Clear();
                GameGraphics.ShowHangmanStatus(lives);
                Console.WriteLine();


                Console.WriteLine("\nOrdet: " + new string(guessedWord));
                Console.WriteLine("Gissade bokstäver: " + string.Join(", ", guessedLetters.Select(letter => letter.ToString().ToUpper())));
                Console.WriteLine($"Liv kvar: {lives}");
                Console.Write("Gissa en bokstav: ");
                string input = Console.ReadLine().ToLower();
                if (input.Length != 1 || !char.IsLetter(input[0]))
                {
                    Console.WriteLine("Var god skriv bara en bokstav.");
                    continue;
                }
                char guess = input[0];

                if (guessedLetters.Contains(guess))
                {
                    Console.WriteLine("Du har redan gissat den bokstaven. Försök igen.");
                    continue;
                }

                guessedLetters.Add(guess);

                if (wordToGuess.Contains(guess))
                {
                    for (int i = 0; i < wordToGuess.Length; i++)
                    {
                        if (wordToGuess[i] == guess)
                            guessedWord[i] = guess;
                    }
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Rätt gissat!");
                    Console.ResetColor();
                    Thread.Sleep(1500);
                }
                else
                {
                    lives--;
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Fel gissat! Du förlorade ett liv.");
                    Console.ResetColor();
                    Thread.Sleep(1500);
                }
            }

            if (new string(guessedWord) == wordToGuess)
            {
                Console.Clear();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("GRATTIS!");
                Console.ResetColor();
                Console.WriteLine($"Du gissade ordet: {wordToGuess}");
            }
            else
                Console.WriteLine($"\nTyvärr, du har inga liv kvar. Ordet var: {wordToGuess}");

            Console.WriteLine("Vill du spela igen? J/N");
            string continueQuestion = Console.ReadLine();

            // Gör inmatningen case-insensitive
            if (continueQuestion.ToUpper() == "J")
                Difficulty.ChooseGameDifficulty();
            else
            {
                Console.WriteLine("Hejdå");
                Thread.Sleep(1000);
                Environment.Exit(0);
            }

        }
    }
}
