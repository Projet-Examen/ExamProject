namespace ExamProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Classes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomClasse = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.NomClasse, unique: true);
            
            CreateTable(
                "dbo.Cours",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomCours = c.String(maxLength: 255),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.NomCours, unique: true);
            
            CreateTable(
                "dbo.Matieres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomMatiere = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.NomMatiere, unique: true);
            
            CreateTable(
                "dbo.Professeurs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nom = c.String(),
                        Prenom = c.String(),
                        Telephone = c.String(maxLength: 15),
                        Email = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Telephone, unique: true)
                .Index(t => t.Email, unique: true);
            
            CreateTable(
                "dbo.Etudiants",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Matricule = c.String(maxLength: 255),
                        Nom = c.String(),
                        Prenom = c.String(),
                        DateNaissance = c.DateTime(nullable: false),
                        Sexe = c.String(),
                        Adresse = c.String(),
                        Telephone = c.String(maxLength: 15),
                        Email = c.String(maxLength: 255),
                        IdClasse = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Classes", t => t.IdClasse, cascadeDelete: true)
                .Index(t => t.Matricule, unique: true)
                .Index(t => t.Telephone, unique: true)
                .Index(t => t.Email, unique: true)
                .Index(t => t.IdClasse);
            
            CreateTable(
                "dbo.Notes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdEtudiant = c.Int(nullable: false),
                        IdMatiere = c.Int(nullable: false),
                        Note = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Etudiants", t => t.IdEtudiant, cascadeDelete: true)
                .ForeignKey("dbo.Matieres", t => t.IdMatiere, cascadeDelete: true)
                .Index(t => t.IdEtudiant)
                .Index(t => t.IdMatiere);
            
            CreateTable(
                "dbo.OTPCodes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdUtilisateur = c.Int(nullable: false),
                        Code = c.String(maxLength: 10),
                        DateExpiration = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Utilisateurs", t => t.IdUtilisateur, cascadeDelete: true)
                .Index(t => t.IdUtilisateur)
                .Index(t => t.Code, unique: true);
            
            CreateTable(
                "dbo.Utilisateurs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomUtilisateur = c.String(maxLength: 50),
                        MotDePasse = c.String(),
                        Role = c.String(),
                        Telephone = c.String(maxLength: 15),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.NomUtilisateur, unique: true)
                .Index(t => t.Telephone, unique: true);
            
            CreateTable(
                "dbo.CoursClasses",
                c => new
                    {
                        Cours_Id = c.Int(nullable: false),
                        Classe_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Cours_Id, t.Classe_Id })
                .ForeignKey("dbo.Cours", t => t.Cours_Id, cascadeDelete: true)
                .ForeignKey("dbo.Classes", t => t.Classe_Id, cascadeDelete: true)
                .Index(t => t.Cours_Id)
                .Index(t => t.Classe_Id);
            
            CreateTable(
                "dbo.MatiereCours",
                c => new
                    {
                        Matiere_Id = c.Int(nullable: false),
                        Cours_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Matiere_Id, t.Cours_Id })
                .ForeignKey("dbo.Matieres", t => t.Matiere_Id, cascadeDelete: true)
                .ForeignKey("dbo.Cours", t => t.Cours_Id, cascadeDelete: true)
                .Index(t => t.Matiere_Id)
                .Index(t => t.Cours_Id);
            
            CreateTable(
                "dbo.ProfesseurClasses",
                c => new
                    {
                        Professeur_Id = c.Int(nullable: false),
                        Classe_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Professeur_Id, t.Classe_Id })
                .ForeignKey("dbo.Professeurs", t => t.Professeur_Id, cascadeDelete: true)
                .ForeignKey("dbo.Classes", t => t.Classe_Id, cascadeDelete: true)
                .Index(t => t.Professeur_Id)
                .Index(t => t.Classe_Id);
            
            CreateTable(
                "dbo.ProfesseurMatieres",
                c => new
                    {
                        Professeur_Id = c.Int(nullable: false),
                        Matiere_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Professeur_Id, t.Matiere_Id })
                .ForeignKey("dbo.Professeurs", t => t.Professeur_Id, cascadeDelete: true)
                .ForeignKey("dbo.Matieres", t => t.Matiere_Id, cascadeDelete: true)
                .Index(t => t.Professeur_Id)
                .Index(t => t.Matiere_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OTPCodes", "IdUtilisateur", "dbo.Utilisateurs");
            DropForeignKey("dbo.Notes", "IdMatiere", "dbo.Matieres");
            DropForeignKey("dbo.Notes", "IdEtudiant", "dbo.Etudiants");
            DropForeignKey("dbo.Etudiants", "IdClasse", "dbo.Classes");
            DropForeignKey("dbo.ProfesseurMatieres", "Matiere_Id", "dbo.Matieres");
            DropForeignKey("dbo.ProfesseurMatieres", "Professeur_Id", "dbo.Professeurs");
            DropForeignKey("dbo.ProfesseurClasses", "Classe_Id", "dbo.Classes");
            DropForeignKey("dbo.ProfesseurClasses", "Professeur_Id", "dbo.Professeurs");
            DropForeignKey("dbo.MatiereCours", "Cours_Id", "dbo.Cours");
            DropForeignKey("dbo.MatiereCours", "Matiere_Id", "dbo.Matieres");
            DropForeignKey("dbo.CoursClasses", "Classe_Id", "dbo.Classes");
            DropForeignKey("dbo.CoursClasses", "Cours_Id", "dbo.Cours");
            DropIndex("dbo.ProfesseurMatieres", new[] { "Matiere_Id" });
            DropIndex("dbo.ProfesseurMatieres", new[] { "Professeur_Id" });
            DropIndex("dbo.ProfesseurClasses", new[] { "Classe_Id" });
            DropIndex("dbo.ProfesseurClasses", new[] { "Professeur_Id" });
            DropIndex("dbo.MatiereCours", new[] { "Cours_Id" });
            DropIndex("dbo.MatiereCours", new[] { "Matiere_Id" });
            DropIndex("dbo.CoursClasses", new[] { "Classe_Id" });
            DropIndex("dbo.CoursClasses", new[] { "Cours_Id" });
            DropIndex("dbo.Utilisateurs", new[] { "Telephone" });
            DropIndex("dbo.Utilisateurs", new[] { "NomUtilisateur" });
            DropIndex("dbo.OTPCodes", new[] { "Code" });
            DropIndex("dbo.OTPCodes", new[] { "IdUtilisateur" });
            DropIndex("dbo.Notes", new[] { "IdMatiere" });
            DropIndex("dbo.Notes", new[] { "IdEtudiant" });
            DropIndex("dbo.Etudiants", new[] { "IdClasse" });
            DropIndex("dbo.Etudiants", new[] { "Email" });
            DropIndex("dbo.Etudiants", new[] { "Telephone" });
            DropIndex("dbo.Etudiants", new[] { "Matricule" });
            DropIndex("dbo.Professeurs", new[] { "Email" });
            DropIndex("dbo.Professeurs", new[] { "Telephone" });
            DropIndex("dbo.Matieres", new[] { "NomMatiere" });
            DropIndex("dbo.Cours", new[] { "NomCours" });
            DropIndex("dbo.Classes", new[] { "NomClasse" });
            DropTable("dbo.ProfesseurMatieres");
            DropTable("dbo.ProfesseurClasses");
            DropTable("dbo.MatiereCours");
            DropTable("dbo.CoursClasses");
            DropTable("dbo.Utilisateurs");
            DropTable("dbo.OTPCodes");
            DropTable("dbo.Notes");
            DropTable("dbo.Etudiants");
            DropTable("dbo.Professeurs");
            DropTable("dbo.Matieres");
            DropTable("dbo.Cours");
            DropTable("dbo.Classes");
        }
    }
}
