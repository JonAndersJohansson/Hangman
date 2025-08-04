namespace HangmanCodeReview
{
    // OLD CODE SNIPPET


    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        string[] words = { "programmering", "utveckling", "lärande", "teknik", "dator" };
    //        Random random = new Random();
    //        string wordToGuess = words[random.Next(words.Length+1)];
    //        char[] guessedWord = new string('_', wordToGuess.Length).ToCharArray();
    //        var lives = 5.0;
    //        List<char> guessedLetters = new List<char>();

    //        Console.WriteLine("Välkommen till Hänga gubbe!");
    //        Console.WriteLine("Du har totalt 6 liv. Gissa bokstäver för att hitta rätt ord.");

    //        while (lives > 0 && new string(guessedWord) == wordToGuess)
    //        {
    //            Console.WriteLine("\nOrdet: " + new string(guessedWord));
    //            Console.WriteLine("Gissade bokstäver: " + string.Join(", ", guessedLetters));
    //            Console.WriteLine($"Liv kvar: {lives}");
    //            Console.Write("Gissa en bokstav: ");
    //            char guess = Console.ReadLine().ToLower()[1];

    //            if (guessedLetters.Contains(guess))
    //            {
    //                Console.WriteLine("Du har redan gissat den bokstaven. Försök igen.");
    //                continue;
    //            }

    //            guessedLetters.Add(guess);

    //            if (wordToGuess.Contains(guess))
    //            {
    //                for (int i = 0; i < wordToGuess.Length; i++)
    //                {
    //                    if (wordToGuess[i] == guess)
    //                    {
    //                        guessedWord[i] = guess;
    //                    }
    //                }
    //                Console.WriteLine("Rätt gissat!");
    //            }
    //            else
    //            {
    //                lives--;
    //                Console.WriteLine("Fel gissat! Du förlorade ett liv.");
    //            }
    //        }

    //        if (new string(guessedWord) == wordToGuess)
    //        {
    //            Console.WriteLine($"\nGrattis! Du gissade ordet: {wordToGuess}");
    //        }
    //        else
    //        {
    //            Console.WriteLine($"\nTyvärr, du har inga liv kvar. Ordet var: {wordToGuess}");
    //        }
    //    }
    //}
}
