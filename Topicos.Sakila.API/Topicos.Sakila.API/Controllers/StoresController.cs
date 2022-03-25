#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Topicos.Sakila.Model.Models;

namespace Topicos.Sakila.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoresController : ControllerBase
    {

        //private readonly sakilaContext _context;

        //public StoresController(sakilaContext context)
        //{
        //    _context = context;
        //}

        // GET: api/Stores
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Store>>> GetStores()
        {
            var _service = new Topicos.Sakila.BL.Inteface.Store();
            var _result = await _service.ListarAsync();
            return Ok(_result);
        }

        //// GET: api/Stores/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Store>> GetStore(byte id)
        //{
        //    var store = await _context.Stores.FindAsync(id);

        //    if (store == null)
        //    {
        //        return NotFound();
        //    }

        //    return store;
        //}

        //// PUT: api/Stores/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutStore(byte id, Store store)
        //{
        //    if (id != store.StoreId)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(store).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!StoreExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/Stores
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<Store>> PostStore(Store store)
        //{
        //    _context.Stores.Add(store);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetStore", new { id = store.StoreId }, store);
        //}

        //// DELETE: api/Stores/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteStore(byte id)
        //{
        //    var store = await _context.Stores.FindAsync(id);
        //    if (store == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Stores.Remove(store);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool StoreExists(byte id)
        //{
        //    return _context.Stores.Any(e => e.StoreId == id);
        //}
    }
}
