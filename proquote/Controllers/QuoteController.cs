using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using proquote.Models;

namespace proquote.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuoteController : ControllerBase
    {
        private readonly proquote_ideaContext _context;

        public QuoteController(proquote_ideaContext context)
        {
            _context = context;
        }

        // GET: api/Quote
        //[HttpGet]
        [NonAction]
        public IEnumerable<TblQuoteMain> GetTblQuoteMain()
        {
            return _context.TblQuoteMain;
        }

        // GET: api/Quote/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTblQuoteMain([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var tblQuoteMain = await _context.TblQuoteMain.FindAsync(id);

            if (tblQuoteMain == null)
            {
                return NotFound();
            }

            return Ok(tblQuoteMain);
        }

        // PUT: api/Quote/5
        [NonAction]
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTblQuoteMain([FromRoute] int id, [FromBody] TblQuoteMain tblQuoteMain)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tblQuoteMain.QuoteId)
            {
                return BadRequest();
            }

            _context.Entry(tblQuoteMain).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblQuoteMainExists(id))
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

        // POST: api/Quote
        [NonAction]
        [HttpPost]
        public async Task<IActionResult> PostTblQuoteMain([FromBody] TblQuoteMain tblQuoteMain)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.TblQuoteMain.Add(tblQuoteMain);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTblQuoteMain", new { id = tblQuoteMain.QuoteId }, tblQuoteMain);
        }

        // DELETE: api/Quote/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteTblQuoteMain([FromRoute] int id)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    var tblQuoteMain = await _context.TblQuoteMain.FindAsync(id);
        //    if (tblQuoteMain == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.TblQuoteMain.Remove(tblQuoteMain);
        //    await _context.SaveChangesAsync();

        //    return Ok(tblQuoteMain);
        //}

        private bool TblQuoteMainExists(int id)
        {
            return _context.TblQuoteMain.Any(e => e.QuoteId == id);
        }
    }
}