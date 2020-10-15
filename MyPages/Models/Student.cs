using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyPages.Models
{
    public class Student
    {
        public int ID { get; set; }
        
        [Column(TypeName = "varchar(45)")]
        [Display(Name = "Nome do estudante")]
        public string Name { get; set; }


        [Display(Name = "Sobrenome")]
        [Column(TypeName = "varchar(45)")]
        public string Lastname { get; set; }
        
        [DataType(DataType.Date)]
        [Column(TypeName = "datetime(0)")]
        [Display(Name = "Data de Inscrição")]
        public DateTime EnrollmentDate { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
