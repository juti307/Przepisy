using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Projekt3.Data;
using Projekt3.Models;


namespace Projekt3.Pages
{
    public class FavouritesModel : PageModel
    {
        private readonly ILogger<FavouritesModel> _logger;

       
       
        private readonly ApplicationDbContext _context;

      
        
        public FavouritesModel(ApplicationDbContext context, ILogger<FavouritesModel> logger)
        {
            _context = context;
            _logger = logger;


        }
        [BindProperty]
        public IList<Recipe> Recipes { get; set; }

        public string GetUser { get; set; }
        public async Task OnGetAsync()
        {
        
            GetUser = User.FindFirstValue(ClaimTypes.Name);
            Recipes = await _context.Recipe.ToListAsync();
            
        }
        
    }
}