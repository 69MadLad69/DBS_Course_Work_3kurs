using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBS_Course_Work_3kurs.Entities
{
    public class Book
    {
        [Key]
        public int Book_Id { get; set; }
        public string? Title { get; set; }
        public string? Author { get; set; }
        public string? Genre { get; set; }
        public double Collateral_value { get; set; }
        public int Quantity { get; set; }
    }
}
