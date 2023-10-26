using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Varga_Paul_Lab2_0.Data;
using Varga_Paul_Lab2_0.Models;

namespace Varga_Paul_Lab2_0.Pages.Categories
{
    public class DetailsModel : PageModel
    {
        private readonly Varga_Paul_Lab2_0.Data.Varga_Paul_Lab2_0Context _context;

        public DetailsModel(Varga_Paul_Lab2_0.Data.Varga_Paul_Lab2_0Context context)
        {
            _context = context;
        }

      public Category Category { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Category == null)
            {
                return NotFound();
            }

            var category = await _context.Category.FirstOrDefaultAsync(m => m.ID == id);
            if (category == null)
            {
                return NotFound();
            }
            else 
            {
                Category = category;
            }
            return Page();
        }
    }
}
