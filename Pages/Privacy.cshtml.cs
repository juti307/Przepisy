using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Projekt3.Data;
using Projekt3.Models;

namespace Projekt3.Pages
{
   // [Authorize]

    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;
        private readonly ApplicationDbContext _context;
        [BindProperty]
        public Recipe Recipe { get; set; }
        public PrivacyModel(ILogger<PrivacyModel> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                using (_context)
                {

                    var src = new Recipe()
                    {
                        Date = DateTime.Now,
                        Name = Recipe.Name,
                        Ingredients = Recipe.Ingredients,
                        Description = Recipe.Description,
                        User = User.FindFirstValue(ClaimTypes.Name),
                        Like = 0
                       

                    };
                    _context.Recipe.Add(src);
                    await _context.SaveChangesAsync();
                }
            }
            return Page();
        }
    }
}
