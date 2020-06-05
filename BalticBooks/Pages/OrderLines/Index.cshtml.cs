using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BalticSportAPI.Models;

namespace BalticBooks.Pages.OrderLines
{
    public class IndexModel : PageModel
    {
        private readonly BalticSportAPI.Models.BalticBooksDbContext _context;

        public IndexModel(BalticSportAPI.Models.BalticBooksDbContext context)
        {
            _context = context;
        }

        public IList<OrderLine> OrderLine { get;set; }

        public async Task OnGetAsync()
        {
            OrderLine = await _context.OrderLines.ToListAsync();
            OrderLine = _context.OrderLines
            .Include(c => c.Order)
            .Include(c => c.Supplier)
            .Include(c => c.Book)
            .ToList();
        }
    }
}
