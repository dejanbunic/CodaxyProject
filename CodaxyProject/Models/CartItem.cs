using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CodaxyProject.Models
{
    public class CartItem 
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("CartId")]
       // [JsonIgnore]
        public int CartId { get; set; }
        public String Name { get; set; }
       // [JsonIgnore]
        public String Description { get; set; }
       // [JsonIgnore]
        public DateTime TimeCreated { get; set; }
       // [JsonIgnore]
        public DateTime TimeUpdated { get; set; }
        //[JsonIgnore]
        public String CreatedBy { get; set; }


    }
}
