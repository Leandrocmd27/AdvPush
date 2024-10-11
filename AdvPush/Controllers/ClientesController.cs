using AdvPush.Context;
using AdvPush.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdvPush.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly AppDbContext _context;
        public ClientesController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Cliente>> Get()
        {
            var clientes = _context.Clientes.ToList();
            if (clientes.Count() == 0)
            {
                return NotFound("Nenhum Cliente Encontrado");
            }
            return clientes;
        }
    }
}
