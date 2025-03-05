using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenProjetGestionEtudiant
{
    class Notes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int IdEtudiant { get; set; }
        public int IdMatiere { get; set; }
        public float Note { get; set; }
        [ForeignKey("IdEtudiant")]
        public Etudiant etudiant { get; set; }
        [ForeignKey("IdMatiere")]
        public Matiere matiere { get; set; }
    }
}