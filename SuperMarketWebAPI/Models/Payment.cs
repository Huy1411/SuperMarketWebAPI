using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SuperMarketWebAPI.Models
{
    public class Payment
    {
        [Key]
        public int ID { get; set; }

        public DateTime PaymentDate { get; set; }

        public int CustomerID { get; set; }

        public virtual Customer Customer { get; set; }


    }
}
