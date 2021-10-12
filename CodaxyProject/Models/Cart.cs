using CodaxyProject.Enumerations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodaxyProject.Models
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }
        public StatusEnum Status { get; set; }
       // public List<CartItem> CartItems { get; set; }
        public DateTime TimeCreated { get; set; }
        public DateTime TimeUpdated { get; set; }
        public String CreatedBy { get; set; }
        public virtual List<CartItem> CartItems { get; set; }
    }
}
