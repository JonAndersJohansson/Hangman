using HangmanCodeReview.UI;

namespace HangmanCodeReview.Core
{
    public class Difficulty
    {
        private List<string> listOfDifficulties = new List<string>
        {
        "1. Lätt", "2. Normal", "3. Svår"
        };
        private DisplayList DisplayList { get; set; }

        public Difficulty(DisplayList displayList)
        {
            DisplayList = displayList;
        }

        //public void SetGameLogic(GameLogic gameLogic)
        //{
        //    GameLogic = gameLogic;
        //}
        public byte ChooseGameDifficulty()
        {
            switch (DisplayList.BrowseList(listOfDifficulties))
            {
                case 0:
                    return 1;
                case 1:
                    return 2;
                case 2:
                    return 3;
                default:
                    Console.WriteLine("Ogiltigt alternativ difficulty, försök igen.");
                    Thread.Sleep(2000);
                    return 0;
            }
        }

    }
}
