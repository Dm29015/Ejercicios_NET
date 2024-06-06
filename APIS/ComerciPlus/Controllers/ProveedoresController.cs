using ComerciPlus.Data;
using ComerciPlus.Models;
using Microsoft.AspNetCore.Mvc;

namespace ComerciPlus.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProveedoresController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ProveedoresController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/proveedores
        [HttpGet]
        public async Task<ActionResult<IEnumerable<proveedores>>> GetProveedores()
        {
            return await _context.proveedores.ToListAsync();
        }

        // GET: api/proveedores/5
        [HttpGet("{id}")]
        public async Task<ActionResult<proveedores>> GetProveedor(int id)
        {
            var proveedor = await _context.proveedores.FindAsync(id);

            if (proveedor == null)
            {
                return NotFound();
            }

            return proveedor;
        }

        // POST: api/proveedores
        [HttpPost]
        public async Task<ActionResult<proveedores>> PostProveedor(proveedores proveedor)
        {
            _context.proveedores.Add(proveedor);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetProveedor), new { Id = proveedor.id }, proveedor);
        }

        // PUT: api/proveedores/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProveedor(int id, proveedores proveedor)
        {
            if (id != proveedor.id)
            {
                return BadRequest();
            }

            _context.Entry(proveedor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProveedorExists(id))
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
        public async Task<IActionResult> DeleteProveedor(int id)
        {
            var proveedor = await _context.proveedores.FindAsync(id);
            if (proveedor == null)
            {
                return NotFound();
            }

            _context.proveedores.Remove(proveedor);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProveedorExists(int id)
        {
            return _context.proveedores.Any(e => e.id == id);
        }
    }
}