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
    public class FilmsController : ControllerBase
    {
        //private readonly sakilaContext _context;

        //public FilmsController(sakilaContext context)
        //{
        //    _context = context;
        //}

        // GET: api/Films
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Film>>> GetFilms()
        {
            var _service = new Topicos.Sakila.BL.Inteface.Film();
            var _result = await _service.ListarAsync();
            return Ok(_result);
        }

        // GET: api/Films/5
        [HttpGet("Id/{id}")]
        public ActionResult<FilmDTO> GetFilmId(ushort id)
        {
            var _service = new Topicos.Sakila.BL.Inteface.Film();
            var _result = _service.SearchByIdDTO(id);
            if (_result == null)
            {
                return NotFound();
            }
            return Ok(_result);
        }

        // GET: api/Films/Title/ADAPTATION HOLES
        [HttpGet("Title/{title}")]
        public ActionResult<FilmDTO> GetFilmTitle(string title)
        {
            var _service = new Topicos.Sakila.BL.Inteface.Film();
            var _result = _service.SearchByTitleDTO(title);
            if (_result == null)
            {
                return NotFound();
            }
            return Ok(_result);
        }



        //// PUT: api/Films/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutFilm(ushort id, Film film)
        //{
        //    if (id != film.FilmId)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(film).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!FilmExists(id))
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

        //// POST: api/Films
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<Film>> PostFilm(Film film)
        //{
        //    _context.Films.Add(film);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetFilm", new { id = film.FilmId }, film);
        //}

        //// DELETE: api/Films/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteFilm(ushort id)
        //{
        //    var film = await _context.Films.FindAsync(id);
        //    if (film == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Films.Remove(film);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool FilmExists(ushort id)
        //{
        //    return _context.Films.Any(e => e.FilmId == id);
        //}
    }
}
