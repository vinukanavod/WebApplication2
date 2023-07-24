using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Services.ViewModels
{
   public class TodoDto
    {
        public int Id { get; set; }
        
        public string Title { get; set; }
       
        public string Description { get; set; }
     
        public DateTime Created { get; set; }
       
        public DateTime Due { get; set; }
        public String Status { get; set; }//Top,Middle,Hig
    }
}
