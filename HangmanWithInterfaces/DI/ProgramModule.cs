using Autofac;
using HangmanWithInterfaces.Core;
using HangmanWithInterfaces.UI;

namespace HangmanWithInterfaces.DI
{
    public class ProgramModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<StartScreen>()
                   .AsSelf();

            builder.RegisterType<Difficulty>()
                   .AsSelf()
                   .OnActivated(e =>
                   {
                       var gameLogic = e.Context.Resolve<GameLogic>();
                       e.Instance.SetGameLogic(gameLogic);
                   })
                   .SingleInstance();

            builder.RegisterType<DisplayList>()
                   .AsSelf()
                   .SingleInstance();

            builder.RegisterType<GameLogic>()
               .As<IGameLogic>();

            builder.RegisterType<GameGraphics>()
                   .AsSelf()
                   .SingleInstance();

            builder.RegisterType<WordGenerator>()
                   .AsSelf()
                   .SingleInstance();

            builder.RegisterType<App>()
                   .AsSelf()
                   .SingleInstance();

            builder.RegisterType<Random>()
                   .AsSelf()
                   .SingleInstance();
        }
    }
}
