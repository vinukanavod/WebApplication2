using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Services.ViewModels
{
    public class classDto
    {
        public int Id { get; set; }
        public string ClassName { get; set; }
       // public int NumberofStudents { get; set; }

        public ICollection<Student> Students { get; set; } = new List<Student>();
    }
}
