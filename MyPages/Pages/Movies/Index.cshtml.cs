using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyPages.Data;
using MyPages.Models;

namespace MyPages.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly MyPages.Data.MyPagesContext _context;

        public IndexModel(MyPages.Data.MyPagesContext context)
        {
            _context = context;
        }

        public IList<Movies> Movies { get;set; }

        public async Task OnGetAsync()
        {
            Movies = await _context.Movies.ToListAsync();
        }
    }
}
