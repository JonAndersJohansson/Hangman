using Autofac;
using HangmanWithInterfaces.Core;
using HangmanWithInterfaces.UI;

namespace HangmanWithInterfaces.DI
{
    public class Program
    {
        static void Main(string[] args)
        {
            var myContainerBuilder = new ContainerBuilder();
            myContainerBuilder.RegisterModule<ProgramModule>();
            var myContainer = myContainerBuilder.Build();

            var startScreen = myContainer.Resolve<StartScreen>();
            var difficulty = myContainer.Resolve<Difficulty>();
            var displayList = myContainer.Resolve<DisplayList>();
            var gameLogic = myContainer.Resolve<GameLogic>();
            var gameGraphics = myContainer.Resolve<GameGraphics>();
            var wordGenerator = myContainer.Resolve<WordGenerator>();
            var app = myContainer.Resolve<App>();
            var random = myContainer.Resolve<Random>();

            app.Run();
        }
    }
}
