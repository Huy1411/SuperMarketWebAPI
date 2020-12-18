using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SuperMarketWebAPI.Models
{
    public class Employee
    {

        [Key]
        public int ID { get; set; }

        [Column(TypeName = "nvarchar (10)")]
        public string Name { get; set; }

        [Column(TypeName = "nvarchar (255)")]
        public string Email { get; set; }

        [Column(TypeName = "nvarchar (255)")]
        public string Status { get; set; }

        public int RoleID { get; set; }

        public virtual Role Role { get; set; }

    }
}
