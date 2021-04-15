using System.ComponentModel.DataAnnotations;

namespace Master.HelpDesk.Entities
{
    public class PieceJointe
    {
        [Key]
        public int PieceJointeId { get; set; }
        public string Nom { get; set; }
        public string Chemin { get; set; }
        public Ticket Ticket { get; set; }
    }
}
