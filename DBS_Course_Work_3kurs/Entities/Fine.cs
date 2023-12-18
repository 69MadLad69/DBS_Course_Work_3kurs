using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBS_Course_Work_3kurs.Entities
{
    public class Fine
    {
        [Key]
        public int Fine_Id { get; set; }
        public string Description { get; set; } = null!;
        public double Payment { get; set; }
    }
}
