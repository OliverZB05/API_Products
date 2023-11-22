using API_Productos.Models;
using API_Productos.DbContext;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Route("api/[controller]")]
[ApiController]
public class TypeDocumentsController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    public TypeDocumentsController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: api/Documents
    [HttpGet]
    public async Task<ActionResult<IEnumerable<TypeDocuments>>> GetTypeDocuments()
    {
        return await _context.TypeDocuments.ToListAsync();
    }

    // GET: api/Documents
    [HttpGet("{id}")]
    public async Task<ActionResult<TypeDocuments>> GetTypeDocuments(int id)
    {
        var typeDocument = await _context.TypeDocuments.FindAsync(id);
        if (typeDocument == null)
        {
            return NotFound();
        }
        return typeDocument;
    }

    // PUT: api/Documents
    [HttpPut("{id}")]
    public async Task<IActionResult> PutTypeDocuments(int id, TypeDocuments typeDocument)
    {
        if (id != typeDocument.id)
        {
            return BadRequest();
        }
        _context.Entry(typeDocument).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return NoContent();
    }

    // POST: api/Documents
    [HttpPost]
    public async Task<ActionResult<TypeDocuments>> PostTypeDocuments(TypeDocuments typeDocument)
    {
        _context.TypeDocuments.Add(typeDocument);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetTypeDocuments), new { id = typeDocument.id }, typeDocument);
    }

    // DELETE: api/Documents/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteTypeDocuments(int id)
    {
        var typeDocument = await _context.TypeDocuments.FindAsync(id);
        if (typeDocument == null)
        {
            return NotFound();
        }
        _context.TypeDocuments.Remove(typeDocument);
        await _context.SaveChangesAsync();
        return NoContent();
    }
}
