using API_Productos.Models;
using API_Productos.DbContext;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Route("api/[controller]")]
[ApiController]
public class ProdImagesController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    public ProdImagesController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: api/Documents
    [HttpGet]
    public async Task<ActionResult<IEnumerable<ProdImages>>> GetProdImages()
    {
        return await _context.ProdImages.ToListAsync();
    }

    // GET: api/Documents
    [HttpGet("{product_id}")]
    public async Task<ActionResult<ProdImages>> GetProdImages(int product_id)
    {
        var prodImage = await _context.ProdImages.FindAsync(product_id);
        if (prodImage == null)
        {
            return NotFound();
        }
        return prodImage;
    }

    // PUT: api/Documents
    [HttpPut("{product_id}")]
    public async Task<IActionResult> PutProdImages(int product_id, ProdImages prodImage)
    {
        if (product_id != prodImage.product_id)
        {
            return BadRequest();
        }
        _context.Entry(prodImage).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return NoContent();
    }

    // POST: api/Documents
    [HttpPost]
    public async Task<ActionResult<ProdImages>> PostProdImages(ProdImages prodImage)
    {
        _context.ProdImages.Add(prodImage);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetProdImages), new { product_id = prodImage.product_id }, prodImage);
    }

    // DELETE: api/Documents/5
    [HttpDelete("{product_id}")]
    public async Task<IActionResult> DeleteProdImages(int product_id)
    {
        var prodImage = await _context.ProdImages.FindAsync(product_id);
        if (prodImage == null)
        {
            return NotFound();
        }
        _context.ProdImages.Remove(prodImage);
        await _context.SaveChangesAsync();
        return NoContent();
    }
}
