using PsychotherapistWebSite.Core.Models;

namespace PsychotherapistWebSite.Core.Repositories
{
    public interface IWelcomeTextRepository
    {
        WelcomeText GetWelcomeText();
        void Create(WelcomeText welcomeText);
        void Delete(int id);
        void PutWelcomeText(WelcomeText welcomeText);
    }
}