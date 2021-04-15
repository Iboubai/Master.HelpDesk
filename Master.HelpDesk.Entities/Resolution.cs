using System.ComponentModel.DataAnnotations;

namespace Master.HelpDesk.Entities
{
    public class Resolution
    {
        [Key]
        public int ResolutionId { get; set; }
        public string Libelle { get; set; }
    }
}
