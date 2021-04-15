using Master.HelpDesk.Entities;

namespace Master.HelpDesk.Port
{
    public interface IAppService
    {
        Personne GetPersonne(int id);
    }
}