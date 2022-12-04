using AutoMapper;
using EscolaAPIdotnet5.App_Data;
using EscolaAPIdotnet5.DTO.AlunoDTO;
using EscolaAPIdotnet5.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace EscolaAPIdotnet5.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlunoController : ControllerBase
    {
        #region Dependencias
        private DataBaseContext _context;
        private IMapper _mapper;

        
        public AlunoController(DataBaseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        #endregion

        //private static List<Aluno> Alunos  = new List<Aluno>();

        #region Atributos
        [HttpPost]
        public IActionResult CreateAluno([FromBody] CreateAlunoDTO alunoDTO)
        {
            Aluno aluno = _mapper.Map<Aluno>(alunoDTO);
            _context.Alunos.Add(aluno);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetAlunoForId), new { Id = aluno.UsuarioId }, aluno);
        }

        [HttpGet]
        public IEnumerable<Aluno> ReadAluno()
        {
            return _context.Alunos;
        }

        [HttpGet("{id}")]
        public IActionResult GetAlunoForId(int id)
        {
            Aluno aluno = _context.Alunos.FirstOrDefault(aluno => aluno.UsuarioId == id);
            if (aluno == null) return NotFound();

            ReadAlunoDTO alunoDTO = _mapper.Map<ReadAlunoDTO>(aluno);

            return Ok(alunoDTO);
        }
        #endregion

    }
}
