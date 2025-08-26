using Microsoft.AspNetCore.Mvc;
using PersonnageLoLApi.Data;
using PersonnageLoLApi.Models;
using Microsoft.EntityFrameworkCore;

namespace PersonnageLoLApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonnageLoLController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PersonnageLoLController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: api/PersonnageLoL
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PersonnageLoL>>> GetPersonnages()
        {
            return await _context.Personnages.ToListAsync();
        }

        // GET: api/PersonnageLoL/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PersonnageLoL>> GetPersonnage(int id)
        {
            var personnage = await _context.Personnages.FindAsync(id);

            if (personnage == null)
                return NotFound();

            return personnage;
        }

        // POST: api/PersonnageLoL
        [HttpPost]
        public async Task<ActionResult<PersonnageLoL>> PostPersonnage(PersonnageLoL personnage)
        {
            _context.Personnages.Add(personnage);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetPersonnage), new { id = personnage.Id }, personnage);
        }

        // PUT: api/PersonnageLoL/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPersonnage(int id, PersonnageLoL personnage)
        {
            if (id != personnage.Id)
                return BadRequest();

            _context.Entry(personnage).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/PersonnageLoL/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePersonnage(int id)
        {
            var personnage = await _context.Personnages.FindAsync(id);
            if (personnage == null)
                return NotFound();

            _context.Personnages.Remove(personnage);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}