﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyPages.Data;
using MyPages.Models;

namespace MyPages.Pages.Movies
{
    public class DetailsModel : PageModel
    {
        private readonly MyPagesContext _context;

        public DetailsModel(MyPagesContext context)
        {
            _context = context;
        }

        public MoviesModel Movies { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movies = await _context.Movies.FirstOrDefaultAsync(m => m.ID == id);

            if (Movies == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
