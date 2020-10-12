using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
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
       
        [BindProperty(SupportsGet = true)]
        public string StrPesquisa { get; set; }
     
        public SelectList ListaGeneros { get; set; }
       
        [BindProperty(SupportsGet = true)]
        public string Genero { get; set; }

        public async Task OnGetAsync()
        {
            IQueryable<string> listaGeneros = from m in _context.Movies
                                            orderby m.Genre
                                            select m.Genre;


            var movies = from m in _context.Movies
                                    select m;

            if (!string.IsNullOrEmpty(StrPesquisa))
            {
                movies = movies.Where(s => s.Title.Contains(StrPesquisa));
            }

            if (!string.IsNullOrEmpty(Genero))
            {
                movies = movies.Where(x => x.Genre == Genero);
            }

            ListaGeneros = new SelectList(
                await listaGeneros.Distinct().ToListAsync()
            );

            Movies = await movies.ToListAsync();

            ViewData["Detalhe"] = "Detalhe da mensagem indo para view!";
        }
    }
}
