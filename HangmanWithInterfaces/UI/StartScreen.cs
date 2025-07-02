using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanWithInterfaces.UI
{
    public class StartScreen
    {
        private GameGraphics GameGraphics { get; set; }
        public StartScreen(GameGraphics gameGraphics)
        {
            GameGraphics = gameGraphics;
        }
        public void StartScreenGraphics()
        {
            while (!Console.KeyAvailable)
            {
                Console.Clear();
                Console.WriteLine("Välkommen till Hänga gubbe!");
                Console.WriteLine("Du har totalt 6 liv. Gissa bokstäver för att hitta rätt ord.");
                Console.WriteLine();
                GameGraphics.GraphicsSixLives();
                Console.WriteLine();
                Console.WriteLine("Tryck valfri tangent för att börja spela.");
                Thread.Sleep(1000);


                if (Console.KeyAvailable) break;

                Console.Clear();
                Console.WriteLine("Välkommen till Hänga gubbe!");
                Console.WriteLine("Du har totalt 6 liv. Gissa bokstäver för att hitta rätt ord.");
                Console.WriteLine();
                GameGraphics.GraphicsFiveLives();
                Console.WriteLine();
                Console.WriteLine("Tryck valfri tangent för att börja spela.");
                Thread.Sleep(1000);

                if (Console.KeyAvailable) break;

                Console.Clear();
                Console.WriteLine("Välkommen till Hänga gubbe!");
                Console.WriteLine("Du har totalt 6 liv. Gissa bokstäver för att hitta rätt ord.");
                Console.WriteLine();
                GameGraphics.GraphicsFourLives();
                Console.WriteLine();
                Console.WriteLine("Tryck valfri tangent för att börja spela.");
                Thread.Sleep(1000);

                if (Console.KeyAvailable) break;

                Console.Clear();
                Console.WriteLine("Välkommen till Hänga gubbe!");
                Console.WriteLine("Du har totalt 6 liv. Gissa bokstäver för att hitta rätt ord.");
                Console.WriteLine();
                GameGraphics.GraphicsThreeLives();
                Console.WriteLine();
                Console.WriteLine("Tryck valfri tangent för att börja spela.");
                Thread.Sleep(1000);

                if (Console.KeyAvailable) break;

                Console.Clear();
                Console.WriteLine("Välkommen till Hänga gubbe!");
                Console.WriteLine("Du har totalt 6 liv. Gissa bokstäver för att hitta rätt ord.");
                Console.WriteLine();
                GameGraphics.GraphicsTwoLives();
                Console.WriteLine();
                Console.WriteLine("Tryck valfri tangent för att börja spela.");
                Thread.Sleep(1000);

                if (Console.KeyAvailable) break;

                Console.Clear();
                Console.WriteLine("Välkommen till Hänga gubbe!");
                Console.WriteLine("Du har totalt 6 liv. Gissa bokstäver för att hitta rätt ord.");
                Console.WriteLine();
                GameGraphics.GraphicsOneLives();
                Console.WriteLine();
                Console.WriteLine("Tryck valfri tangent för att börja spela.");
                Thread.Sleep(1000);

                if (Console.KeyAvailable) break;
            }
            Console.WriteLine("");
            Console.ReadKey();
        }
    }
}
