using HangmanCodeReview.UI;

namespace HangmanCodeReview.Core
{
    public class GameLogic
    {
        private IWordGenerator WordGenerator { get; set; }
        private GameGraphics GameGraphics { get; set; }
        private Difficulty Difficulty { get; set; }
        public GameLogic(IWordGenerator wordGenerator, GameGraphics gameGraphics, Difficulty difficulty)
        {
            WordGenerator = wordGenerator;
            GameGraphics = gameGraphics;
            Difficulty = difficulty;
        }
        public void Game()
        {
            while (true)
            {
                byte levelOfDifficulty = Difficulty.ChooseGameDifficulty();
                string wordToGuess = WordGenerator.GetRandomWord(levelOfDifficulty).ToUpper();

                char[] guessedWord = new string('_', wordToGuess.Length).ToCharArray();
                sbyte lives = 6;
                List<char> guessedLetters = new List<char>();

                while (lives > 0 && new string(guessedWord) != wordToGuess)
                {
                    Console.Clear();
                    GameGraphics.MainGraphics();
                    GameGraphics.ShowHangmanStatus(lives);
                    Console.WriteLine();


                    Console.WriteLine("\nOrdet: " + new string(guessedWord));
                    Console.WriteLine("Gissade bokstäver: " + string.Join(", ", guessedLetters.Select(letter => letter.ToString().ToUpper())));
                    Console.WriteLine($"Liv kvar: {lives}");
                    Console.Write("Gissa en bokstav: ");
                    string input = Console.ReadLine().ToUpper();
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
                    GameGraphics.MainGraphics();
                    Console.WriteLine();
                    GameGraphics.GraphicsLived();
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("GRATTIS!");
                    Console.ResetColor();
                    Console.Write($"Du gissade ordet: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($"{wordToGuess}\n");
                    Console.ResetColor();
                }
                else
                {
                    Console.Clear();
                    GameGraphics.MainGraphics();
                    Console.WriteLine();
                    GameGraphics.ShowHangmanStatus(lives);
                    Console.WriteLine();
                    Console.Write("\nTyvärr, du har inga liv kvar. Ordet var: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($"{wordToGuess}\n");
                    Console.ResetColor();
                }

                Console.WriteLine("Vill du spela igen? J/N");
                string continueQuestion = Console.ReadLine();

                // Gör inmatningen case-insensitive
                if (continueQuestion.ToUpper() == "J")
                    continue;
                else
                {
                    Console.WriteLine("Hejdå");
                    Thread.Sleep(1000);
                    Environment.Exit(0);
                    break;
                }
            }
            

        }
    }
}
