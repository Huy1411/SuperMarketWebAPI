using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SuperMarketWebAPI.Models
{
    public class ProductOrders
    {

        [Key]
        public int ID { get; set; }

        public int ProductID { get; set; }
        public virtual Product Product { get; set; }
        public int OrderID { get; set; }
        public virtual Order Order { get; set; }
    }
}
