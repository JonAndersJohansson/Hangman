using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanWithInterfaces.UI
{
    public class GameGraphics
    {
        public void GraphicsSixLives()
        {
            Console.WriteLine("       ___________");
            Console.WriteLine("        |/     |");
            Console.WriteLine("        |      O");
            Console.WriteLine("        |     -|-");
            Console.WriteLine("        |     / \\");
        }
        public void GraphicsFiveLives()
        {
            Console.WriteLine("       ___________");
            Console.WriteLine("        |/     |");
            Console.WriteLine("        |      O");
            Console.WriteLine("        |     -|-");
            Console.WriteLine("        |     / ");
        }
        public void GraphicsFourLives()
        {
            Console.WriteLine("       ___________");
            Console.WriteLine("        |/     |");
            Console.WriteLine("        |      O");
            Console.WriteLine("        |     -|-");
            Console.WriteLine("        |     ");
        }
        public void GraphicsThreeLives()
        {
            Console.WriteLine("       ___________");
            Console.WriteLine("        |/     |");
            Console.WriteLine("        |      O");
            Console.WriteLine("        |     -|");
            Console.WriteLine("        | ");
        }
        public void GraphicsTwoLives()
        {
            Console.WriteLine("       ___________");
            Console.WriteLine("        |/     |");
            Console.WriteLine("        |      O");
            Console.WriteLine("        |      |");
            Console.WriteLine("        | ");
        }
        public void GraphicsOneLives()
        {
            Console.WriteLine("       ___________");
            Console.WriteLine("        |/     |");
            Console.WriteLine("        |      O");
            Console.WriteLine("        | ");
            Console.WriteLine("        | ");
        }
        public void GraphicsZeroLives()
        {
            Console.WriteLine("       ___________");
            Console.WriteLine("        |/     |");
            Console.WriteLine("        |     ");
            Console.WriteLine("        |   DU ÄR DÖD ");
            Console.WriteLine("        |   ");
        }

        public void ShowHangmanStatus(int lives)
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
    }
}
