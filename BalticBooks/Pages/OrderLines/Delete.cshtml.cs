﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BalticSportAPI.Models;

namespace BalticBooks.Pages.OrderLines
{
    public class DeleteModel : PageModel
    {
        private readonly BalticSportAPI.Models.BalticBooksDbContext _context;

        public DeleteModel(BalticSportAPI.Models.BalticBooksDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public OrderLine OrderLine { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            OrderLine = await _context.OrderLines.FirstOrDefaultAsync(m => m.Id == id);

            if (OrderLine == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            OrderLine = await _context.OrderLines.FindAsync(id);

            if (OrderLine != null)
            {
                _context.OrderLines.Remove(OrderLine);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
