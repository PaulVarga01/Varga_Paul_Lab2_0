﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Varga_Paul_Lab2_0.Data;
using Varga_Paul_Lab2_0.Models;

namespace Varga_Paul_Lab2_0.Pages.Books
{
    public class CreateModel : PageModel
    {
        private readonly Varga_Paul_Lab2_0.Data.Varga_Paul_Lab2_0Context _context;

        public CreateModel(Varga_Paul_Lab2_0.Data.Varga_Paul_Lab2_0Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Book Book { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Book == null || Book == null)
            {
                return Page();
            }

            _context.Book.Add(Book);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
