using Autofac;
using HangmanCodeReview.Core;
using HangmanCodeReview.UI;

namespace HangmanCodeReview.DI
{
    public class ProgramModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<StartScreen>()
                   .AsSelf();

            builder.RegisterType<Difficulty>()
                   .AsSelf()
                   //.OnActivated(e =>
                   //{
                   //    var gameLogic = e.Context.Resolve<GameLogic>();
                   //    e.Instance.SetGameLogic(gameLogic);
                   //})
                   .SingleInstance();

            builder.RegisterType<DisplayList>()
                   .AsSelf()
                   .SingleInstance();

            builder.RegisterType<GameLogic>()
                   .AsSelf()
                   .SingleInstance();

            builder.RegisterType<GameGraphics>()
                   .AsSelf()
                   .SingleInstance();

            builder.RegisterType<WordGenerator>()
                   .As<IWordGenerator>()
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
