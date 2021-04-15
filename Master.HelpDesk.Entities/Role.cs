using System.ComponentModel.DataAnnotations;

namespace Master.HelpDesk.Entities
{
    public class Role
    {
        [Key]
        public int RoleId { get; set; }
        public string Classe { get; set; }
    }
}
