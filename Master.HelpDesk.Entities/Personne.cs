using System.ComponentModel.DataAnnotations;

namespace Master.HelpDesk.Entities
{
    public class Personne
    {
        [Key]
        public int PersonneId { get; set; }
        public string Prenom { get; set; }
        public string Nom { get; set; }
        public string Email { get; set; }
        public string Information { get; set; }
        public string MotPasse { get; set; }
        public string Telephone { get; set; }
    }
}
