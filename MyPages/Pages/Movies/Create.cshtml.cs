﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyPages.Data;
using MyPages.Models;

namespace MyPages.Pages.Movies
{
    public class CreateModel : PageModel
    {
        private readonly MyPagesContext _context;

        public CreateModel(MyPagesContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public MoviesModel Movies { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Movies.Add(Movies);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
