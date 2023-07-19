using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Services.ViewModels
{
    public class AuthorDto
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

     
        public string LastName { get; set; }
     
        public String Adress { get; set; }
       
    }
}
