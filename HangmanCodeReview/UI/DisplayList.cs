namespace HangmanCodeReview.UI
{
    public class DisplayList
    {
        private GameGraphics GameGraphics { get; }
        public DisplayList(GameGraphics gameGraphics)
        {
            GameGraphics = gameGraphics;
        }
        public int BrowseList(List<string> menuItems)
        {
            int selectedIndex = 0;
            ConsoleKeyInfo key;
            Console.CursorVisible = false;

            while (true)
            {
                Console.Clear();
                GameGraphics.MainGraphics();
                GameGraphics.GraphicsSixLives();
                Console.WriteLine();
                Console.WriteLine("Välj svårhetsgrad med pil upp/ned och tryck enter");

                for (int i = 0; i < menuItems.Count; i++)
                {
                    if (i == selectedIndex)
                    {
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.WriteLine($"{menuItems[i]}");
                }

                Console.ResetColor();

                key = Console.ReadKey(intercept: true);

                if (key.Key == ConsoleKey.UpArrow)
                    selectedIndex = selectedIndex > 0 ? selectedIndex - 1 : menuItems.Count - 1;

                else if (key.Key == ConsoleKey.DownArrow)
                    selectedIndex = selectedIndex < menuItems.Count - 1 ? selectedIndex + 1 : 0;

                else if (key.Key == ConsoleKey.Enter)
                    return selectedIndex;
            }
        }
    }
}
