using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExtremeHelp.Api.Models
{
    [Table("T_EH_ALERTA")]
    public class Alerta
    {
        [Key]
        [Column("CD_ALERTA")]
        public int Id { get; set; }
        [Required]
        [StringLength(150)]
        [Column("DS_TITULO")]
        public string Titulo { get; set; }
        [Required]
        [StringLength(2000)]
        [Column("DS_MENSAGEM")]
        public string Mensagem { get; set; }
        [Required]
        [Column("DT_PUBLICACAO")]
        public DateTime DataPublicacao { get; set; }
    }
}