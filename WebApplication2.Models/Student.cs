using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string country { get; set; }
        public int ClassId { get; set; }
        public Class Class { get; set; }

        
 
    }
}
