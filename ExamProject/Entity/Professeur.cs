using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenProjetGestionEtudiant
{
    class Professeur
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        [MaxLength(15)]
        [Index(IsUnique = true)]
        public string Telephone { get; set; }
        [MaxLength(255)]
        [Index(IsUnique = true)]
        public string Email { get; set; }

        public ICollection<Classe> classes { get; set; }
        public ICollection<Matiere> matieres { get; set; }
    }
}