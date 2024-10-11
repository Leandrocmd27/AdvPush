using AdvPush.Context;
using AdvPush.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdvPush.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProcessosController : ControllerBase
    {
        private readonly AppDbContext _context;
        public ProcessosController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Processo>> Get()
        {
            var Processos = _context.Processos.ToList();
            if (Processos.Count() == 0)
            {
                return NotFound("Nenhum Cliente Encontrado");
            }
            return Processos;
        }
    }
}
