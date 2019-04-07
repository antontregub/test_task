using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Models
{
    [Table("Students")]
    public class Student
    {
        [Key]
        public string Gradebook_Number { get; set; }
        public string Name{ get; set; }
        public string Groups { get; set; }
       
    }

    [Table("Grades")]
    public class Grade
    {
        [Key]
        public string Gradebook_Number { get; set; }
        public int Maths { get; set; }
        public int Drawing { get; set; }
        public int Literature { get; set; }
    }
}
