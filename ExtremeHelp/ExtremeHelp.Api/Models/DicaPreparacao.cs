using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExtremeHelp.Api.Models
{
    [Table("T_EH_DICA_PREPARACAO")]
    public class DicaPreparacao
    {
        [Key]
        [Column("CD_DICA")]
        public int Id { get; set; }
        [Required]
        [StringLength(150)]
        [Column("DS_TITULO")]
        public string Titulo { get; set; }
        [Required]
        [Column("DS_CONTEUDO")]
        public string Conteudo { get; set; }
        [Column("DT_ULTIMA_ATUALIZACAO")]
        public DateTime UltimaAtualizacao { get; set; }
        public int DicaCategoriaId { get; set; }
        public DicaCategoria Categoria { get; set; }
    }
}