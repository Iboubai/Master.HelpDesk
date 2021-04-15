using System;
using System.ComponentModel.DataAnnotations;

namespace Master.HelpDesk.Entities
{
    public class Ticket
    {
        [Key]
        public int TicketId { get; set; }
        public Application Application { get; set; }
        public Assistant Assistant { get; set; }
        public DateTime DateEcheance { get; set; }
        public DateTime DateModification { get; set; }
        public DateTime DateResolution { get; set; }
        public string Description { get; set; }
        public bool EstActif { get; set; }
        public Priorite Priorite { get; set; }
        public Resolution Resolution { get; set; }
        public string Resume { get; set; }
        public Statut Statut { get; set; }
        public TypeTicket TypeTicket { get; set; }
        public Utilisateur Utilisateur { get; set; }
    }
}
