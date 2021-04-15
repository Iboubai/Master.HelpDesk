using Master.HelpDesk.Entities;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Master.HelpDesk.Adapter.Dal
{
    public class DatabaseContext : DbContext
    {

        public DatabaseContext() : base("HelpDeskContext")
        {
        }

        public DbSet<Personne> Personnes { get; set; }
        public DbSet<Application> Applications { get; set; }
        public DbSet<Assistant> Assistants { get; set; }
        public DbSet<Commentaire> Commentaires { get; set; }
        public DbSet<PieceJointe> PieceJointes { get; set; }
        public DbSet<Priorite> Priorites { get; set; }
        public DbSet<Resolution> Resolutions { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Statut> Statuts { get; set; }
        public DbSet<Ticket> Ticket { get; set; }
        public DbSet<TypeTicket> TypeTicket { get; set; }
        public DbSet<Utilisateur> Utilisateur { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
