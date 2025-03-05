using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenProjetGestionEtudiant
{
    class Cours
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength(255)]
        [Index(IsUnique = true)]
        public string NomCours { get; set; }
        public string Description { get; set; }

        public ICollection<Classe> classes { get; set; }
        public ICollection<Matiere> matieres { get; set; }
    }
    public class CoursView
    {
        public int Id { get; set; }
        public string NomCours { get; set; }
        public string Description { get; set; }
        public string Matiere { get; set; }
        public string Classes { get; set; }
    }
}