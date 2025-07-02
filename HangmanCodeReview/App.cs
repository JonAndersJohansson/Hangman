using HangmanCodeReview.Core;
using HangmanCodeReview.UI;

namespace HangmanCodeReview
{
    public class App
    {
        private StartScreen StartScreen { get; set; }
        private Difficulty Difficulty { get; set; }
        private GameLogic GameLogic { get; set; }
        private bool showStartScreenGraphics = true;
        public App(StartScreen startScreen, Difficulty difficulty, GameLogic gameLogic)
        {
            StartScreen = startScreen; 
            Difficulty = difficulty;
            GameLogic = gameLogic;
        }
        public void Run()
        {
            StartScreen.StartScreenGraphics(showStartScreenGraphics);
            GameLogic.Game();
        }
    }
}
