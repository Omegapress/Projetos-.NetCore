using EscolaPrimariaAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EscolaPrimariaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {

        private readonly EscolaPrimariaContext _context;

        public AlunoController(EscolaPrimariaContext context) 
        {
            _context = context;

        }

        [HttpGet]
        public async Task<ActionResult<List<Aluno>>> GetAluno() 
        {
        
            List<Aluno> alunos = await _context.Alunos.ToListAsync();
            return Ok(alunos);
        
        }

        [HttpGet("{IdAluno}")]
        public async Task<ActionResult<Aluno>> GetAluno(int IdAluno)
        {

            Aluno aluno = await _context.Alunos.FindAsync(IdAluno);
            return Ok(aluno);

        }

    }
}
