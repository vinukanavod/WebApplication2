using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Author
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
  public string FirstName { get; set; }

        [Required]
        [MaxLength(100)]
        public string LastName { get; set; }
        [MaxLength(10)]
         public String AdderssNo { get; set; }
        [MaxLength(200)]
        public String Street { get; set; }
        [Required, MaxLength(50)]
        public String City { get; set; }
        public ICollection<Todoo> Todos { get; set; } = new List<Todoo>();
       
    }
}
