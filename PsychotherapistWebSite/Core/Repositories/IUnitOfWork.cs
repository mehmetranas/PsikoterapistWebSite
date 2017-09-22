namespace PsychotherapistWebSite.Core.Repositories
{
    public interface IUnitOfWork
    {
        IServiceRepository Service { get; }
        ISlideRepsitory Slide { get; }
        IMottoRepository Motto { get; }

        void Complete();
    }
}
