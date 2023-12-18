using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBS_Course_Work_3kurs.Entities
{
    public class Lending
    {
        [Key]
        public int Lending_Id { get; set; }

        [ForeignKey ("Customer")]
        public int Customer_Id { get; set; }
        public Customer Customer { get; set; } = null!;

        public DateOnly Loan_date { get; set; }
        public DateOnly? Expected_return_date { get; set; }
        public DateOnly? Actual_return_date { get; set; }

        [ForeignKey("book")]
        public int Book_Id { get; set; }
        public Book book { get; set; } = null!;

        [ForeignKey("fine")]
        public int Fine_Id { get; set; }
        public Fine fine { get; set; } = null!;

        [ForeignKey("discount")]
        public int Discount_Id { get; set; }
        public Discount discount { get; set; } = null!;

        public double Initial_rental_price { get; set; }
        public double Final_rental_price { get; set; }
    }
}
