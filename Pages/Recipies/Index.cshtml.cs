using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Projekt3.Data;
using Projekt3.Models;

namespace Projekt3.Pages.Recipies
{
    //[Authorize]
    public class IndexModel : PageModel
    {
        private readonly Projekt3.Data.ApplicationDbContext _context;
        
        //ApplicationDbContext ApplicationDbContext;

        public IndexModel(Projekt3.Data.ApplicationDbContext context)
        {
            _context = context;
         //  ApplicationDbContext = context;
        }
        public int ID { get; set; }
       
        public string GetUser { get; set; }
        [BindProperty]
        public string UserName { get; set; }
        [BindProperty]
        public string RecipeName { get; set; }
        public IList<Recipe> Recipes { get;set; }
      //  public IEnumerable<Recipe> historia;
     //   public void OnGet()
     //   {
      //      historia = ApplicationDbContext.Recipe.Take(20);
      //  }
       public async Task OnGetAsync()
        {
           
            Recipes = await _context.Recipe.ToListAsync();
            GetUser = User.FindFirstValue(ClaimTypes.Name);
            
        }
      public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid )
            {
                if (!(RecipeName == null && UserName == null))
                {
                    Recipes = await _context.Recipe.
                        Where(p => (p.User.Equals(UserName) || p.Name.Equals(RecipeName))).

                        OrderByDescending(p => p.Date).
                        ToListAsync();
                }
                else
                {
                    Recipes = await _context.Recipe.ToListAsync();
                }
            }
            
     
            return Page();
            /*var k=ApplicationDbContext.Recipe
                return */

        }
    }
}
