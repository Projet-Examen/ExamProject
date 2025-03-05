using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenProjetGestionEtudiant
{
    class OTPCodes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int IdUtilisateur { get; set; }
        [MaxLength(10)]
        [Index(IsUnique = true)]
        public string Code { get; set; }
        public DateTime DateExpiration { get; set; }

        [ForeignKey("IdUtilisateur")]
        public Utilisateur utilisateur { get; set; }
    }
}