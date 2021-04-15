using System.ComponentModel.DataAnnotations;

namespace Master.HelpDesk.Entities
{
    public class Application
    {
        [Key]
        public int ApplicationId { get; set; }
        public string Libelle { get; set; }
        public string Version { get; set; }
    }
}
