using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBS_Course_Work_3kurs.Entities
{
    public class Customer
    {
        [Key]
        public int Customer_Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Paternal_name { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }

        [ForeignKey("discount")]
        public int Discount_Id { get; set; }

        public Discount discount { get; set; } = null!;
    }
}
