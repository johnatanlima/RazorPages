using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyPages.Data;
using MyPages.Models;

namespace MyPages.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly MyPagesContext _context;

        public IndexModel(MyPagesContext context)
        {
            _context = context;
        }

        public IList<MoviesModel> Movies { get;set; }

        public async Task OnGetAsync()
        {
            Movies = await _context.Movies.ToListAsync();

            ViewData["Detalhe"] = "Detalhe da mensagem indo para view!";
        }
    }
}
