using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExtremeHelp.Api.Models
{
    [Table("T_EH_DICA_CATEGORIA")]
    public class DicaCategoria
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Nome { get; set; }
        public ICollection<DicaPreparacao> Dicas { get; set; } = new List<DicaPreparacao>();
    }
}