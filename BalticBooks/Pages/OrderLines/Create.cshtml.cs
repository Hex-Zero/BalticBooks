using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BalticSportAPI.Models;

namespace BalticBooks.Pages.OrderLines
{
    public class CreateModel : PageModel
    {
        private readonly BalticSportAPI.Models.BalticBooksDbContext _context;

        public CreateModel(BalticSportAPI.Models.BalticBooksDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public OrderLine OrderLine { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.OrderLines.Add(OrderLine);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
