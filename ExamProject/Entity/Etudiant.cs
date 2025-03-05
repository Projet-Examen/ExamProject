using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace ExamenProjetGestionEtudiant
{
    class Etudiant
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength(255)]
        [Index(IsUnique = true)]
        public string Matricule { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateNaissance { get; set; }
        public string Sexe { get; set; }
        public string Adresse { get; set; }
        [MaxLength(15)]
        [Index(IsUnique = true)]
        public string Telephone { get; set; }
        [MaxLength(255)]
        [Index(IsUnique = true)]
        public string Email { get; set; }
        public int IdClasse { get; set; }
        [ForeignKey("IdClasse")]
        public Classe classe { get; set; }
        public ICollection<Notes> notes { get; set; }
    }
}