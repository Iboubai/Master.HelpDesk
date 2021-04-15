using System.ComponentModel.DataAnnotations;

namespace Master.HelpDesk.Entities
{
    public class Utilisateur
    {
        [Key]
        public int UtilisateurId { get; set; }
        public string Numero { get; set; }
    }
}
