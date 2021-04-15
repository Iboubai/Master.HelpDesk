using System.ComponentModel.DataAnnotations;

namespace Master.HelpDesk.Entities
{
    public class Commentaire
    {
        [Key]
        public int CommentaireId { get; set; }
        public string Description { get; set; }
        public Ticket Ticket { get; set; }
        public Utilisateur Utilisateur { get; set; }
    }
}
