using System.ComponentModel.DataAnnotations;

namespace Master.HelpDesk.Entities
{
    public class Statut
    {
        [Key]
        public int StatutId { get; set; }
        public string Libelle { get; set; }
    }
}
