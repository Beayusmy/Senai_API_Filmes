﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_filmes_senai.Domains
{
    public class Filme
    {
        [Key]
        public Guid IdFilme { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        [Required(ErrorMessage = "O titulo do filme e obrigatorio!")]
        public string Titulo { get; set; }

        /// <summary>
        /// Referencia da tabela genero
        /// </summary>
        public Guid IdGenero { get; set; }


        [ForeignKey("IdGenero")]
        public Genero? Genero { get; set; }


    }
}
