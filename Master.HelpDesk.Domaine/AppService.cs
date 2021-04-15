using Master.HelpDesk.Adapter.Dal;
using Master.HelpDesk.Entities;
using Master.HelpDesk.Port;

namespace Master.HelpDesk.Domaine
{
    public class AppService : IAppService
    {
        public Personne GetPersonne(int id)
        {
            try
            {
                using (var db = new DatabaseContext())
                {
                    //var personne = new Personne
                    //{
                    //    Nom = "Doumbouya",
                    //    Prenom = "Ibrahima",
                    //    Email = "doumbouyaibrahima@gmail.com",
                    //    Information = "Haha",
                    //    MotPasse = null,
                    //    Telephone = "0737621750"
                    //};

                    //db.Personnes.Add(personne);
                    //db.SaveChanges();
                    //return db.Personnes.Find(id);
                }
            }
            catch
            {
                return null;
            }
            return null;
        }
    }
}
