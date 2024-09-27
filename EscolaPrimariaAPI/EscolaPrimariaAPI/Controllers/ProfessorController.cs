using EscolaPrimariaAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EscolaPrimariaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessorController : ControllerBase
    {

        private readonly EscolaPrimariaContext _context;

        public ProfessorController(EscolaPrimariaContext context)
        {
            _context = context;

        }

        [HttpGet]
        public async Task<ActionResult<List<Professor>>> GetProfessor()
        {

            List<Professor> professores = await _context.Professors.ToListAsync();
            return Ok(professores);

        }

        [HttpGet("{IdProfessor}")]
        public async Task<ActionResult<Professor>> GetProfessor(int IdProfessor)
        {

            Professor professor = await _context.Professors.FindAsync(IdProfessor);
            return Ok(professor);

        }

    }
}
