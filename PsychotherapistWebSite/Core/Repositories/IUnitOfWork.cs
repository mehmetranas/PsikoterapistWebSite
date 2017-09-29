namespace PsychotherapistWebSite.Core.Repositories
{
    public interface IUnitOfWork
    {
        IServiceRepository Service { get; }
        ISlideRepsitory Slide { get; }
        IMottoRepository Motto { get; }
        IImageRepository Image { get; }
        IWelcomeTextRepository WelcomeText { get; }

        void Complete();
        void Dispose();
    }
}
