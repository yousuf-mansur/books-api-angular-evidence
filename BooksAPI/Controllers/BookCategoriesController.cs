using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BooksAPI.Data;
using BooksAPI.Models;

namespace BooksAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BookCategoriesController : ControllerBase
    {
        private readonly BookDbContext _context;

        public BookCategoriesController(BookDbContext context)
        {
            _context = context;
        }

        // GET: BookCaegories

        [HttpGet]
        public async Task<ActionResult<IEnumerable<BookCategory>>> GetBookCategory()
        {
            return await _context.BookCategories.Include(pc => pc.Books).ToListAsync();
        }

        // GET: BookCaegories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BookCategory>> GetBookCategory(int id)
        {
            var bookCategory = await _context.BookCategories.Include(pc => pc.Books).SingleAsync(pc => pc.BookCategoryId == id);

            if (bookCategory == null)
            {
                return NotFound();
            }

            return bookCategory;
        }

        
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBookCategory(int id, BookCategory bookCategory)
        {
            if (id != bookCategory.BookCategoryId)
            {
                return BadRequest();
            }

            _context.Entry(bookCategory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BookCategoryExists(id))
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

        // POST: BookCategories

        [HttpPost]
        public async Task<ActionResult<BookCategory>> PostBookCategory(BookCategory bookCategory)
        {
            _context.BookCategories.Add(bookCategory);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBookCategory", new { id = bookCategory.BookCategoryId }, bookCategory);
        }

        // DELETE: BookCategories/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBookCategory(int id)
        {
            var bookCategories = await _context.BookCategories.FindAsync(id);
            if (bookCategories == null)
            {
                return NotFound();
            }

            _context.BookCategories.Remove(bookCategories);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BookCategoryExists(int id)
        {
            return _context.BookCategories.Any(e => e.BookCategoryId == id);
        }
    }
}
