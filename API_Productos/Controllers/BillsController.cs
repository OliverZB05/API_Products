
using API_Productos.DbContext;
using API_Productos.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_Productos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BillsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public BillsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Documents
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Bills>>> GetBills()
        {
            return await _context.Bills.ToListAsync();
        }

        // GET: api/Documents
        [HttpGet("{id}")]
        public async Task<ActionResult<Bills>> GetBills(int id)
        {
            var bills = await _context.Bills.FindAsync(id);
            if (bills == null)
            {
                return NotFound();
            }
            return bills;
        }

        // PUT: api/Documents
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCustomers(int id, Bills bill)
        {
            if (id != bill.id)
            {
                return BadRequest();
            }
            _context.Entry(bill).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        // POST: api/Documents
        [HttpPost]
        public async Task<ActionResult<Bills>> PostBills(Bills bill)
        {
            _context.Bills.Add(bill);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetBills), new { id = bill.id }, bill);
        }

        // DELETE: api/Documents/
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBills(int id)
        {
            var bill = await _context.Bills.FindAsync(id);
            if (bill == null)
            {
                return NotFound();
            }
            _context.Bills.Remove(bill);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
