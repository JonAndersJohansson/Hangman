namespace HangmanCodeReview.UI
{
    public class StartScreen
    {
        private GameGraphics GameGraphics { get; set; }
        public StartScreen(GameGraphics gameGraphics)
        {
            GameGraphics = gameGraphics;
        }
        public bool StartScreenGraphics(bool flag)
        {
            sbyte itterationInStartGraphics = 6;
            while (!Console.KeyAvailable)
            {
                if (itterationInStartGraphics == -1)
                    itterationInStartGraphics = 6;
                Console.Clear();
                GameGraphics.MainGraphics();
                Console.WriteLine();
                GameGraphics.ShowHangmanStatus(itterationInStartGraphics);
                Console.WriteLine();
                Console.WriteLine("          Tryck valfri tangent för att börja spela.");
                Thread.Sleep(100);
                itterationInStartGraphics--;

                if (Console.KeyAvailable) break;
            }
            Console.ReadKey();
            return flag = false;
        }
    }
}
