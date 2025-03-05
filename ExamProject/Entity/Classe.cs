using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenProjetGestionEtudiant
{
    class Classe
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength(255)]
        [Index(IsUnique = true)]
        public string NomClasse { get; set; }

        public ICollection<Professeur> professeurs { get; set; }
        public ICollection<Etudiant> etudiants { get; set; }
        public ICollection<Cours> cours { get; set; }
    }
}