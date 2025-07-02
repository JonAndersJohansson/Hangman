namespace HangmanCodeReview.UI
{
    public class GameGraphics
    {
        public void GraphicsOneLives()
        {
            Console.WriteLine("                        ___________");
            Console.WriteLine("                         |/     |");
            Console.WriteLine("                         |      O");
            Console.WriteLine("                         |     /|\\");
            Console.WriteLine("                         |     / ");
            Console.WriteLine("                         | ");
        }
        public void GraphicsTwoLives()
        {
            Console.WriteLine("                        ___________");
            Console.WriteLine("                         |/     |");
            Console.WriteLine("                         |      O");
            Console.WriteLine("                         |     /|\\");
            Console.WriteLine("                         |     ");
            Console.WriteLine("                         | ");
        }
        public void GraphicsThreeLives()
        {
            Console.WriteLine("                        ___________");
            Console.WriteLine("                         |/     |");
            Console.WriteLine("                         |      O");
            Console.WriteLine("                         |      |\\");
            Console.WriteLine("                         |     ");
            Console.WriteLine("                         | ");
        }
        public void GraphicsFourLives()
        {
            Console.WriteLine("                        ___________");
            Console.WriteLine("                         |/     |");
            Console.WriteLine("                         |      O");
            Console.WriteLine("                         |      |");
            Console.WriteLine("                         | ");
            Console.WriteLine("                         | ");
        }
        public void GraphicsFiveLives()
        {
            Console.WriteLine("                        ___________");
            Console.WriteLine("                         |/     |");
            Console.WriteLine("                         |      O");
            Console.WriteLine("                         |      ");
            Console.WriteLine("                         | ");
            Console.WriteLine("                         | ");
        }
        public void GraphicsSixLives()
        {
            Console.WriteLine("                        ___________");
            Console.WriteLine("                         |/     |");
            Console.WriteLine("                         | ");
            Console.WriteLine("                         | ");
            Console.WriteLine("                         | ");
            Console.WriteLine("                         | ");
        }
        public void GraphicsZeroLives()
        {
            Console.WriteLine("                        ___________");
            Console.WriteLine("                         |/     |");
            Console.WriteLine("                         |      O");
            Console.WriteLine("                         |     /|\\");
            Console.WriteLine("                         |     / \\");
            Console.WriteLine("                         | ");
        }
        public void GraphicsLived()
        {
            Console.WriteLine("                            \\");
            Console.WriteLine("                            /\\");
            Console.WriteLine("                           /  \\           `");
            Console.WriteLine("                          /    \\           \\O__      ");
            Console.WriteLine("                         |             ~´\\_/_      ");
            Console.WriteLine("                         |    --o             \\,        ");
        }

        public void ShowHangmanStatus(sbyte lives)
        {
            if (lives == 6)
                GraphicsSixLives();
            else if (lives == 5)
                GraphicsFiveLives();
            else if (lives == 4)
                GraphicsFourLives();
            else if (lives == 3)
                GraphicsThreeLives();
            else if (lives == 2)
                GraphicsTwoLives();
            else if (lives == 1)
                GraphicsOneLives();
            else if (lives == 0)
                GraphicsZeroLives();
            else
                Console.WriteLine("Fel i ShowHangmanStatus");
        }
        public void MainGraphics()
        {
            Console.WriteLine(" _   _  _   _  _   _ _____   ___    _____ _   _____________ _____ ");
            Console.WriteLine("| | | |(_)_(_)| \\ | |  __ \\ / _ \\  |  __ \\ | | | ___ \\ ___ \\  ___|");
            Console.WriteLine("| |_| | / _ \\ |  \\| | |  \\// /_\\ \\ | |  \\/ | | | |_/ / |_/ / |__  ");
            Console.WriteLine("|  _  |/ /_\\ \\| . ` | | __ |  _  | | | __| | | | ___ \\ ___ \\  __| ");
            Console.WriteLine("| | | ||  _  || |\\  | |_\\ \\| | | | | |_\\ \\ |_| | |_/ / |_/ / |___ ");
            Console.WriteLine("\\_| |_/\\_| |_/\\_| \\_/\\____/\\_| |_/  \\____/\\___/\\____/\\____/\\____/ ");
            Console.WriteLine("   Du har totalt 6 liv. Gissa bokstäver för att hitta rätt ord.");
        }
    }
}
