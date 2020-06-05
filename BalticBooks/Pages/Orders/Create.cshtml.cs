using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BalticSportAPI.Models;

namespace BalticBooks.Pages.Orders
{
    public class CreateModel : PageModel
    {
        private readonly BalticSportAPI.Models.BalticBooksDbContext _context;

        public CreateModel(BalticSportAPI.Models.BalticBooksDbContext context)
        {
            _context = context;
        }
        [BindProperty]
        public Order Order { get; set; }

        public List<SelectListItem> Options { get; set; }
        public IActionResult OnGet()
        {
            Options = _context.Customers.Select(a =>
                                          new SelectListItem
                                          {
                                              Value = a.Id.ToString(),
                                              Text = a.CustomerName
                                          }).ToList();
            return Page();
        }
       
      
      
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.

        public async Task<IActionResult> OnPostAsync()
        {

            
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _context.Orders.Add(Order);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
