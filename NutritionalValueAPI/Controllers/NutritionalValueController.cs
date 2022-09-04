using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NutritionalValueAPI.Controllers.Data;

namespace NutritionalValueAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NutritionalValueController : ControllerBase
    {
        private readonly DataContext _context;

        public NutritionalValueController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]

        public async Task<ActionResult<List<NutritionalValue>>> GetNutritionalValues()
        {
            return Ok(await _context.NutritionalValues.ToListAsync());
        }

        [HttpPost]
        public async Task<ActionResult<List<NutritionalValue>>> CreateNutritionalValue(NutritionalValue nutriValue)
        {
            _context.NutritionalValues.Add(nutriValue);
            await _context.SaveChangesAsync();

            return Ok(await _context.NutritionalValues.ToListAsync());
        }

        [HttpPut]
        public async Task<ActionResult<List<NutritionalValue>>> UpdateNutritionalValue(NutritionalValue nutriValue)
        {
            var dbNutriValue = await _context.NutritionalValues.FindAsync(nutriValue.Id);
            if (dbNutriValue == null)
                return BadRequest("NutritionalValue not found.");
            dbNutriValue.Name = nutriValue.Name;
            dbNutriValue.Type = nutriValue.Type;
            dbNutriValue.Weight = nutriValue.Weight;
            dbNutriValue.Kcal = nutriValue.Kcal;

            await _context.SaveChangesAsync();

            return Ok(await _context.NutritionalValues.ToListAsync());
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<NutritionalValue>>> DeleteNutritionalValue(int id)
        {
            var dbNutriValue = await _context.NutritionalValues.FindAsync(id);
            if (dbNutriValue == null)
                return BadRequest("dbNutriValue not found.");

            _context.NutritionalValues.Remove(dbNutriValue);
            await _context.SaveChangesAsync();
            return Ok(await _context.NutritionalValues.FindAsync(id));
        }

    }
}
