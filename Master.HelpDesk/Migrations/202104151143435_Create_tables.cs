namespace Master.HelpDesk.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_tables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Application",
                c => new
                    {
                        ApplicationId = c.Int(nullable: false, identity: true),
                        Libelle = c.String(),
                        Version = c.String(),
                    })
                .PrimaryKey(t => t.ApplicationId);
            
            CreateTable(
                "dbo.Assistant",
                c => new
                    {
                        AssistantId = c.Int(nullable: false, identity: true),
                        Matricule = c.String(),
                        NiveauEscalade = c.String(),
                        Service = c.String(),
                        Role_RoleId = c.Int(),
                    })
                .PrimaryKey(t => t.AssistantId)
                .ForeignKey("dbo.Role", t => t.Role_RoleId)
                .Index(t => t.Role_RoleId);
            
            CreateTable(
                "dbo.Role",
                c => new
                    {
                        RoleId = c.Int(nullable: false, identity: true),
                        Classe = c.String(),
                    })
                .PrimaryKey(t => t.RoleId);
            
            CreateTable(
                "dbo.Commentaire",
                c => new
                    {
                        CommentaireId = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Ticket_TicketId = c.Int(),
                        Utilisateur_UtilisateurId = c.Int(),
                    })
                .PrimaryKey(t => t.CommentaireId)
                .ForeignKey("dbo.Ticket", t => t.Ticket_TicketId)
                .ForeignKey("dbo.Utilisateur", t => t.Utilisateur_UtilisateurId)
                .Index(t => t.Ticket_TicketId)
                .Index(t => t.Utilisateur_UtilisateurId);
            
            CreateTable(
                "dbo.Ticket",
                c => new
                    {
                        TicketId = c.Int(nullable: false, identity: true),
                        DateEcheance = c.DateTime(nullable: false),
                        DateModification = c.DateTime(nullable: false),
                        DateResolution = c.DateTime(nullable: false),
                        Description = c.String(),
                        EstActif = c.Boolean(nullable: false),
                        Resume = c.String(),
                        Application_ApplicationId = c.Int(),
                        Assistant_AssistantId = c.Int(),
                        Priorite_PrioriteId = c.Int(),
                        Resolution_ResolutionId = c.Int(),
                        Statut_StatutId = c.Int(),
                        TypeTicket_TypeTicketId = c.Int(),
                        Utilisateur_UtilisateurId = c.Int(),
                    })
                .PrimaryKey(t => t.TicketId)
                .ForeignKey("dbo.Application", t => t.Application_ApplicationId)
                .ForeignKey("dbo.Assistant", t => t.Assistant_AssistantId)
                .ForeignKey("dbo.Priorite", t => t.Priorite_PrioriteId)
                .ForeignKey("dbo.Resolution", t => t.Resolution_ResolutionId)
                .ForeignKey("dbo.Statut", t => t.Statut_StatutId)
                .ForeignKey("dbo.TypeTicket", t => t.TypeTicket_TypeTicketId)
                .ForeignKey("dbo.Utilisateur", t => t.Utilisateur_UtilisateurId)
                .Index(t => t.Application_ApplicationId)
                .Index(t => t.Assistant_AssistantId)
                .Index(t => t.Priorite_PrioriteId)
                .Index(t => t.Resolution_ResolutionId)
                .Index(t => t.Statut_StatutId)
                .Index(t => t.TypeTicket_TypeTicketId)
                .Index(t => t.Utilisateur_UtilisateurId);
            
            CreateTable(
                "dbo.Priorite",
                c => new
                    {
                        PrioriteId = c.Int(nullable: false, identity: true),
                        Libelle = c.String(),
                    })
                .PrimaryKey(t => t.PrioriteId);
            
            CreateTable(
                "dbo.Resolution",
                c => new
                    {
                        ResolutionId = c.Int(nullable: false, identity: true),
                        Libelle = c.String(),
                    })
                .PrimaryKey(t => t.ResolutionId);
            
            CreateTable(
                "dbo.Statut",
                c => new
                    {
                        StatutId = c.Int(nullable: false, identity: true),
                        Libelle = c.String(),
                    })
                .PrimaryKey(t => t.StatutId);
            
            CreateTable(
                "dbo.TypeTicket",
                c => new
                    {
                        TypeTicketId = c.Int(nullable: false, identity: true),
                        Libelle = c.String(),
                    })
                .PrimaryKey(t => t.TypeTicketId);
            
            CreateTable(
                "dbo.Utilisateur",
                c => new
                    {
                        UtilisateurId = c.Int(nullable: false, identity: true),
                        Numero = c.String(),
                    })
                .PrimaryKey(t => t.UtilisateurId);
            
            CreateTable(
                "dbo.Personne",
                c => new
                    {
                        PersonneId = c.Int(nullable: false, identity: true),
                        Prenom = c.String(),
                        Nom = c.String(),
                        Email = c.String(),
                        Information = c.String(),
                        MotPasse = c.String(),
                        Telephone = c.String(),
                    })
                .PrimaryKey(t => t.PersonneId);
            
            CreateTable(
                "dbo.PieceJointe",
                c => new
                    {
                        PieceJointeId = c.Int(nullable: false, identity: true),
                        Nom = c.String(),
                        Chemin = c.String(),
                        Ticket_TicketId = c.Int(),
                    })
                .PrimaryKey(t => t.PieceJointeId)
                .ForeignKey("dbo.Ticket", t => t.Ticket_TicketId)
                .Index(t => t.Ticket_TicketId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PieceJointe", "Ticket_TicketId", "dbo.Ticket");
            DropForeignKey("dbo.Commentaire", "Utilisateur_UtilisateurId", "dbo.Utilisateur");
            DropForeignKey("dbo.Commentaire", "Ticket_TicketId", "dbo.Ticket");
            DropForeignKey("dbo.Ticket", "Utilisateur_UtilisateurId", "dbo.Utilisateur");
            DropForeignKey("dbo.Ticket", "TypeTicket_TypeTicketId", "dbo.TypeTicket");
            DropForeignKey("dbo.Ticket", "Statut_StatutId", "dbo.Statut");
            DropForeignKey("dbo.Ticket", "Resolution_ResolutionId", "dbo.Resolution");
            DropForeignKey("dbo.Ticket", "Priorite_PrioriteId", "dbo.Priorite");
            DropForeignKey("dbo.Ticket", "Assistant_AssistantId", "dbo.Assistant");
            DropForeignKey("dbo.Ticket", "Application_ApplicationId", "dbo.Application");
            DropForeignKey("dbo.Assistant", "Role_RoleId", "dbo.Role");
            DropIndex("dbo.PieceJointe", new[] { "Ticket_TicketId" });
            DropIndex("dbo.Ticket", new[] { "Utilisateur_UtilisateurId" });
            DropIndex("dbo.Ticket", new[] { "TypeTicket_TypeTicketId" });
            DropIndex("dbo.Ticket", new[] { "Statut_StatutId" });
            DropIndex("dbo.Ticket", new[] { "Resolution_ResolutionId" });
            DropIndex("dbo.Ticket", new[] { "Priorite_PrioriteId" });
            DropIndex("dbo.Ticket", new[] { "Assistant_AssistantId" });
            DropIndex("dbo.Ticket", new[] { "Application_ApplicationId" });
            DropIndex("dbo.Commentaire", new[] { "Utilisateur_UtilisateurId" });
            DropIndex("dbo.Commentaire", new[] { "Ticket_TicketId" });
            DropIndex("dbo.Assistant", new[] { "Role_RoleId" });
            DropTable("dbo.PieceJointe");
            DropTable("dbo.Personne");
            DropTable("dbo.Utilisateur");
            DropTable("dbo.TypeTicket");
            DropTable("dbo.Statut");
            DropTable("dbo.Resolution");
            DropTable("dbo.Priorite");
            DropTable("dbo.Ticket");
            DropTable("dbo.Commentaire");
            DropTable("dbo.Role");
            DropTable("dbo.Assistant");
            DropTable("dbo.Application");
        }
    }
}
