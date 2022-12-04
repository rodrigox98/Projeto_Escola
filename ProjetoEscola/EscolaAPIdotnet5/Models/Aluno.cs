using System.ComponentModel.DataAnnotations;
using System;

namespace EscolaAPIdotnet5.Models
{
    public class Aluno
    {
        [Key, Required]
        public int UsuarioId { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
