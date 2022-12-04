using System;

namespace EscolaAPIdotnet5.DTO.AlunoDTO
{
    public class ReadAlunoDTO
    {
        public int UsuarioID{ get; set; } 
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataDeNascimento { get; set; }
    }
}
