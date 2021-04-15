using Master.HelpDesk.Domaine;
using Master.HelpDesk.Entities;
using Master.HelpDesk.Port;

namespace Master.HelpDesk.Controllers
{
    public class Proxy
    {
        public IAppService appService;
        public Personne GetPersonne(int id)
        {
             appService = new AppService();
            return appService.GetPersonne(id);
        }
    }
}