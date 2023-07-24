using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Services.Classes
{
   public interface ClassRepo
    {
        public Class getClassdetail(int id);
        public List<Class> AllClasses();
        
    }
}
