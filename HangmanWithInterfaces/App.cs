using HangmanWithInterfaces.Core;
using HangmanWithInterfaces.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanWithInterfaces
{
    public class App
    {
        private StartScreen StartScreen { get; set; }
        private Difficulty Difficulty { get; set; }
        public App(StartScreen startScreen, Difficulty difficulty)
        {
            StartScreen = startScreen;
            Difficulty = difficulty;
        }
        public void Run()
        {
            StartScreen.StartScreenGraphics();
            Difficulty.ChooseGameDifficulty();
        }
    }
}
