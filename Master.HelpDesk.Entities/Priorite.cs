using System.ComponentModel.DataAnnotations;

namespace Master.HelpDesk.Entities
{
    public class Priorite
    {
        [Key]
        public int PrioriteId { get; set; }
        public string Libelle { get; set; }
    }
}
