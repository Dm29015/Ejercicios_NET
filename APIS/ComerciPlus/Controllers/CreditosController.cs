using Microsoft.AspNetCore.Mvc;
using ComerciPlus.Data;
using ComerciPlus.Models;

namespace ComerciPlus.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CreditosController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CreditosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/creditos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<creditos>>> GetCreditos()
        {
            return await _context.creditos.ToListAsync();
        }

        // GET: api/creditos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<creditos>> GetCredito(int id)
        {
            var credito = await _context.creditos.FindAsync(id);

            if (credito == null)
            {
                return NotFound();
            }

            return credito;
        }

        // POST: api/credito
        [HttpPost]
        public async Task<ActionResult<creditos>> PostCreditos(creditos credito)
        {
            _context.creditos.Add(credito);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetCredito), new { id = credito.Id }, credito);
        }


        // PUT: api/creditos/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Putcredito(int id, creditos credito)
        {
            if (id != credito.Id)
            {
                return BadRequest();
            }

            _context.Entry(credito).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CreditoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // DELETE: api/proveedores/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCredito(int id)
        {
            var credito = await _context.creditos.FindAsync(id);
            if (credito == null)
            {
                return NotFound();
            }

            _context.creditos.Remove(credito);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CreditoExists(int id)
        {
            return _context.creditos.Any(e => e.Id == id);
        }
    }
}
