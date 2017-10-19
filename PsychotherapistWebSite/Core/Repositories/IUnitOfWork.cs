namespace PsychotherapistWebSite.Core.Repositories
{
    public interface IUnitOfWork
    {
        IServiceRepository Service { get; }
        ISlideRepsitory Slide { get; }
        IMottoRepository Motto { get; }
        IImageRepository Image { get; }
        IWelcomeTextRepository WelcomeText { get; }
        IFaqRepository Faq { get; }
        IInfoRepository Info { get; set; }
        IAdressRepository Adress { get; set; }
        IMessageRepository Message { get; set; }

        void Complete();
        void Dispose();
    }
}
