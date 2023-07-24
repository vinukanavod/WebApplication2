using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
   public class Class
    {
        [Required]
        [MaxLength(10)]

        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string ClassName { get; set; }
        [Required]
        
        public int NumberofStudents { get; set; }
        
        public ICollection<Student> Students { get; set; } = new List<Student>();
    }
}
