using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace api_filmes_senai.Domains
{
    [Table("Genero")]
    public class Genero
    {
        [Key] 
        public Guid IdGenero { get; set; }

        [Column(TypeName = "VARCHAR (30)")]
        [Required (ErrorMessage = "Nome do Genero e obrigatorio")]
        public string? Nome { get; set; }
    }
}
