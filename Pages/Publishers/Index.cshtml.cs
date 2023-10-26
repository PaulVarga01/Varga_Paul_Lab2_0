﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Varga_Paul_Lab2_0.Data;
using Varga_Paul_Lab2_0.Models;

namespace Varga_Paul_Lab2_0.Pages.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly Varga_Paul_Lab2_0.Data.Varga_Paul_Lab2_0Context _context;

        public IndexModel(Varga_Paul_Lab2_0.Data.Varga_Paul_Lab2_0Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Publisher != null)
            {
                Publisher = await _context.Publisher.ToListAsync();
            }
        }
    }
}
