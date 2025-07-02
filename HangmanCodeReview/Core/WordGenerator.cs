namespace HangmanCodeReview.Core
{
    public class WordGenerator : IWordGenerator
    {
        private Random Random { get; set; }
        public WordGenerator(Random random)
        {
            Random = random;
        }
        private string FilePath { get; } = "../../../Data/words.txt";

        public string GetRandomWord(int difficulty)
        {
            if (difficulty == 1)
                return GetEasyWordFromList();
            else if (difficulty == 2)
                return GetNormalWordFromList();
            else if (difficulty == 3)
                return GetHardWordFromList();
            else
                return "Fel i GetRandomWord";

        }
        public string GetEasyWordFromList()
        {
            string[] words = File.ReadAllLines(FilePath)
                                  .Select(word => word.ToUpper())
                                  .Where(word => word.Length == 3 || word.Length == 4)
                                  .ToArray();
            return PickSomeRandomWord(words);
        }

        public string GetNormalWordFromList()
        {
            string[] words = File.ReadAllLines(FilePath)
                                  .Select(word => word.ToUpper())
                                  .Where(word => word.Length == 5 || word.Length == 6)
                                  .ToArray();
            return PickSomeRandomWord(words);
        }

        public string GetHardWordFromList()
        {
            string[] words = File.ReadAllLines(FilePath)
                                  .Select(word => word.ToUpper())
                                  .Where(word => word.Length >= 7)
                                  .ToArray();
            return PickSomeRandomWord(words);
        }

        private string PickSomeRandomWord(string[] words)
        {
            string wordToGuess = words[Random.Next(words.Length)];
            return wordToGuess;
        }
    }
}
