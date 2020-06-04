using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BalticSportAPI.Models
{
    public class OrderLine
    {
        public int Id { get; set; }
        public Order Order { get; set; }
        public Supplier Supplier { get; set; }
        public Book Book { get; set; }
        public int OrderLineQuantity { get; set; }
    }
}
