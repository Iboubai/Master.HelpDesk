using System.ComponentModel.DataAnnotations;

namespace Master.HelpDesk.Entities
{
    public class TypeTicket
    {
        [Key]
        public int TypeTicketId { get; set; }
        public string Libelle { get; set; }
    }
}
