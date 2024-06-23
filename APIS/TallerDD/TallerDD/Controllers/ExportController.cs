using TallerDD.Data;
using Microsoft.AspNetCore.Mvc;
namespace TallerDD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExportController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public ExportController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Export>>> GetExport()

        {
            return await _context.Export.ToListAsync();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Export>> GetExport(int id)
        {
            var Export = await _context.Export.FindAsync(id);
            if (Export == null)
            {
                return NotFound();
            }
            return Export;
        }
        [HttpPost]
        public async Task<ActionResult<Export>>

        PostCSharpCornerArticle(Export Export)

        {
            _context.Export.Add(Export);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetExport", new
            {
                id =

            Export.IdExport
            }, Export);

        }
        [HttpPut("{id}")]
        public async Task<IActionResult> PutExport(int id, Export

        Export)
        {
            if (id != Export.IdExport)
            {
                return BadRequest();
            }
            _context.Entry(Export).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }

            catch (DbUpdateConcurrencyException)
            {
                if (!ExportExists(id))
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
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteExport(int id)
        {
            var Export = await _context.Export.FindAsync(id);
            if (Export == null)
            {
                return NotFound();
            }
            _context.Export.Remove(Export);
            await _context.SaveChangesAsync();
            return NoContent();
        }
        private bool ExportExists(int id)
        {
            return _context.Export.Any(e => e.IdExport == id);
        }
    }
}
