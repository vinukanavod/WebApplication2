using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webapplication2.Database;
using WebApplication2.Models;

namespace WebApplication2.Services.Classes
{
    public class ClassSQLService : ClassRepo
    {
        private readonly TodoDbContext _td = new TodoDbContext();
        public List<Class> AllClasses()
        {
            return _td.classes.ToList();
        }

        public Class getClassdetail(int id)
        {
           return _td.classes.Find(id);
        }
    }
}
