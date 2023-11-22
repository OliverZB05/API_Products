
using API_Productos.DbContext;
using API_Productos.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_Productos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TypeCustomersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public TypeCustomersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Documents
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TypeCustomers>>> GetTypeCustomers()
        {
            return await _context.TypeCustomers.ToListAsync();
        }

        // GET: api/Documents
        [HttpGet("{id}")]
        public async Task<ActionResult<TypeCustomers>> GetTypeCustomers(int id)
        {
            var typeCustomer = await _context.TypeCustomers.FindAsync(id);
            if (typeCustomer == null)
            {
                return NotFound();
            }
            return typeCustomer;
        }

        // PUT: api/Documents
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTypeCustomers(int id, TypeCustomers typeCustomer)
        {
            if (id != typeCustomer.id)
            {
                return BadRequest();
            }
            _context.Entry(typeCustomer).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        // POST: api/Documents
        [HttpPost]
        public async Task<ActionResult<TypeCustomers>> PostTypeCustomers(TypeCustomers typeCustomer)
        {
            _context.TypeCustomers.Add(typeCustomer);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetTypeCustomers), new { id = typeCustomer.id }, typeCustomer);
        }

        // DELETE: api/Documents/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTypeCustomers(int id)
        {
            var typeCustomer = await _context.TypeCustomers.FindAsync(id);
            if (typeCustomer == null)
            {
                return NotFound();
            }
            _context.TypeCustomers.Remove(typeCustomer);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
