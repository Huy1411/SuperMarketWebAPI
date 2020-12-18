using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SuperMarketWebAPI.Models
{
    public class Provider
    {
        [Key]
        public int ID { get; set; }

        [Column(TypeName = "nvarchar (100)")]
        public string Name { get; set; }

        [Column(TypeName = "nvarchar (255)")]
        public string Address { get; set; } 

        [Column(TypeName = "nvarchar (25)")]
        public string Phone { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
