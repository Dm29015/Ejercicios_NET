using Microsoft.AspNetCore.Mvc;
using ComerciPlus.Data;
using ComerciPlus.Models;

namespace ComerciPlus.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuariosController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public UsuariosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Usuarios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<usuarios>>> GetUsuarios()
        {
            return await _context.usuarios.ToListAsync();
        }

        // GET: api/Usuarios/5
        [HttpGet("{id}")]
        public async Task<ActionResult<usuarios>> GetUsuario(int id)
        {
            var Usuario = await _context.usuarios.FindAsync(id);

            if (Usuario == null)
            {
                return NotFound();
            }

            return Usuario;
        }

        // POST: api/Usuario
        [HttpPost]
        public async Task<ActionResult<usuarios>> PostUsuarios(usuarios Usuario)
        {
            _context.usuarios.Add(Usuario);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetUsuario), new { Id = Usuario.Id }, Usuario);
        }


        // PUT: api/Usuarios/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUsuario(int id, usuarios Usuario)
        {
            if (id != Usuario.Id)
            {
                return BadRequest();
            }

            _context.Entry(Usuario).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UsuarioExists(id))
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

        // DELETE: api/Usuarios/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUsuario(int id)
        {
            var Usuario = await _context.usuarios.FindAsync(id);
            if (Usuario == null)
            {
                return NotFound();
            }

            _context.usuarios.Remove(Usuario);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UsuarioExists(int id)
        {
            return _context.usuarios.Any(e => e.Id == id);
        }
    }
}
