using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BalticSportAPI.Models;

namespace BalticBooks.Pages.Orders
{
    public class IndexModel : PageModel
    {
        private readonly BalticSportAPI.Models.BalticBooksDbContext _context;

        public IndexModel(BalticSportAPI.Models.BalticBooksDbContext context)
        {
            _context = context;
        }

        public IList<Order> Order { get;set; }

        public async Task OnGetAsync()
        {
            Order = await _context.Orders.ToListAsync();
            Order = _context.Orders
             .Include(c => c.Customer)
             .ToList();
        }
    }
}
