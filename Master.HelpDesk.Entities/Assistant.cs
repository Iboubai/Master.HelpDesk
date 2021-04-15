using System.ComponentModel.DataAnnotations;

namespace Master.HelpDesk.Entities
{
    public class Assistant
    {
        [Key]
        public int AssistantId { get; set; }
        public string Matricule { get; set; }
        public string NiveauEscalade { get; set; }
        public Role Role { get; set; }
        public string Service { get; set; }
    }
}
