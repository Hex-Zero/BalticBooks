using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;
using System.Linq;
using System.Threading.Tasks;

namespace BalticSportAPI.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(250)]
        public string BookTitle { get; set; }
        [Column(TypeName = "money")]
        public decimal ProductPrice { get; set; }
        public int InStock { get; set; }
    }
}
