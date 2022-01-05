using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Projekt3.Models;

namespace Projekt3.Pages
{
    public class MinusModel : PageModel
    {
        private readonly Projekt3.Data.ApplicationDbContext _context;

        public MinusModel(Projekt3.Data.ApplicationDbContext context)
        {
            _context = context;
        }
        [BindProperty]
        public Recipe Recipe { get; set; }


        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Recipe = await _context.Recipe.FirstOrDefaultAsync(m => m.Id == id);

            if (Recipe == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {

            Recipe = await _context.Recipe.FirstOrDefaultAsync(m => m.Id == id);

            Recipe.Votes--;
            await _context.SaveChangesAsync();
            return RedirectToPage("./Index");

        }
    }
}
