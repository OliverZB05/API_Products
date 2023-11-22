
using API_Productos.DbContext;
using API_Productos.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_Productos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsBillsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public ItemsBillsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Documents
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ItemsBills>>> GetItemsBills()
        {
            return await _context.ItemsBills.ToListAsync();
        }

        // GET: api/Documents
        [HttpGet("{id}")]
        public async Task<ActionResult<ItemsBills>> GetItemsBills(int id)
        {
            var itemsBills = await _context.ItemsBills.FindAsync(id);
            if (itemsBills == null)
            {
                return NotFound();
            }
            return itemsBills;
        }

        // PUT: api/Documents
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCustomers(int id, ItemsBills itemsBill)
        {
            if (id != itemsBill.id)
            {
                return BadRequest();
            }
            _context.Entry(itemsBill).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        // POST: api/Documents
        [HttpPost]
        public async Task<ActionResult<Bills>> PostItemsBills(ItemsBills itemsBill)
        {
            _context.ItemsBills.Add(itemsBill);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetItemsBills), new { id = itemsBill.id }, itemsBill);
        }

        // DELETE: api/Documents/
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteItemsBills(int id)
        {
            var itemsBill = await _context.ItemsBills.FindAsync(id);
            if (itemsBill == null)
            {
                return NotFound();
            }
            _context.ItemsBills.Remove(itemsBill);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
