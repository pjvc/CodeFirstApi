using DB;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirstApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutorController : ControllerBase
    {
        private TiendaLibroContext _context;

        public AutorController(TiendaLibroContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<Autor> Get() => _context.Autores.ToList();  
    }
}
