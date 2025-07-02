using HangmanWithInterfaces.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanWithInterfaces.Core
{
    public class Difficulty
    {
        private List<string> listOfDifficulties = new List<string>
        {
        "1. Lätt", "2. Normal", "3. Svår"
        };
        private DisplayList DisplayList { get; set; }
        private GameLogic GameLogic { get; set; }

        public Difficulty(DisplayList displayList)
        {
            DisplayList = displayList;
        }

        public void SetGameLogic(GameLogic gameLogic)
        {
            GameLogic = gameLogic;
        }
        public void ChooseGameDifficulty()
        {
            switch (DisplayList.BrowseList(listOfDifficulties))
            {
                case 0:
                    GameLogic.Game(1);
                    break;
                case 1:
                    GameLogic.Game(2);
                    break;
                case 2:
                    GameLogic.Game(3);
                    break;
                default:
                    Console.WriteLine("Ogiltigt alternativ difficulty, försök igen.");
                    Thread.Sleep(2000);
                    break;
            }
        }

    }
}
