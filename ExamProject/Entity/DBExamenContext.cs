using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;


namespace ExamenProjetGestionEtudiant
{
    internal class DBExamenContext:DbContext
    {
        public DBExamenContext() : base("examenConnect") { }

        public DbSet<Classe> classes { get; set; }
        public DbSet<Cours> cours { get; set; }
        public DbSet<Etudiant> etudiants { get; set; }
        public DbSet<Matiere> matieres { get; set; }
        public DbSet<Notes> notes { get; set; }
        public DbSet<OTPCodes> otpcodes { get; set; }
        public DbSet<Professeur> professeurs { get; set; }
        public DbSet<Utilisateur> utilisateurs { get; set; }



    }
}