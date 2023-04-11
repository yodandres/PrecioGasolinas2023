using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PrecioGasolinas2023.DataAccess.Entities;

namespace PrecioGasolinas2023.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrecioGasolinasController : ControllerBase
    {
        private readonly PrecioGasolinasDbContext _context;

        public PrecioGasolinasController(PrecioGasolinasDbContext context)
        {
            _context = context;
        }

        // GET api/gasolineras/precios
        //[HttpGet("precios")]
        [HttpPost]
        public ActionResult<IEnumerable<Gasolina>> GetPrecios()
        {
            var precios = _context.Gasolinas.ToList();
            return precios;
        }

    }
}
