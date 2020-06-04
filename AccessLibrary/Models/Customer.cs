using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BalticSportAPI.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(250)]
        public string CustomerName { get; set; }
        public int CustomerPhone { get; set; }
        [Required]
        [MaxLength(250)]
        public string CustomerAddress { get; set; }
        [Required]
        [MaxLength(250)]
        public string CustomerEmail { get; set; }
    }
}
