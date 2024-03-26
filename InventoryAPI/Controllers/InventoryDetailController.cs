using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using InventoryAPI.Models;

namespace InventoryAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryDetailController : ControllerBase
    {
        private readonly InventoryDetailContext _context;

        public InventoryDetailController(InventoryDetailContext context)
        {
            _context = context;
        }

        // GET: api/InventoryDetail
        [HttpGet]
        public async Task<ActionResult<IEnumerable<InventoryDetail>>> GetInventoryDetails()
        {
            return await _context.InventoryDetails.ToListAsync();
        }

        // GET: api/InventoryDetail/5
        [HttpGet("{id}")]
        public async Task<ActionResult<InventoryDetail>> GetInventoryDetail(int id)
        {
            var inventoryDetail = await _context.InventoryDetails.FindAsync(id);

            if (inventoryDetail == null)
            {
                return NotFound();
            }

            return inventoryDetail;
        }

        // PUT: api/InventoryDetail/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInventoryDetail(int id, InventoryDetail inventoryDetail)
        {
            if (id != inventoryDetail.InventoryDetailId)
            {
                return BadRequest();
            }

            _context.Entry(inventoryDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InventoryDetailExists(id))
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

        // POST: api/InventoryDetail
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<InventoryDetail>> PostInventoryDetail(InventoryDetail inventoryDetail)
        {
            _context.InventoryDetails.Add(inventoryDetail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetInventoryDetail", new { id = inventoryDetail.InventoryDetailId }, inventoryDetail);
        }

        // DELETE: api/InventoryDetail/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInventoryDetail(int id)
        {
            var inventoryDetail = await _context.InventoryDetails.FindAsync(id);
            if (inventoryDetail == null)
            {
                return NotFound();
            }

            _context.InventoryDetails.Remove(inventoryDetail);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool InventoryDetailExists(int id)
        {
            return _context.InventoryDetails.Any(e => e.InventoryDetailId == id);
        }
    }
}
