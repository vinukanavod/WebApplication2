using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication2.Models;
using Webapplication2.Database;

namespace WebApplication2.Services.Todos
{
    public class TodooServerSQLservice : ITodooRepo
    {
        private readonly TodoDbContext _context = new TodoDbContext();

       public List<Todoomommy> GetAllTodoomommies()
        {
           return _context.Todoomommies.ToList();
       }

        public List<Todoo> GetAllTodoos()
        {
            return _context.Todos.ToList();
        }

        public Todoo GetTodoo(int id)
        {
            return _context.Todos.Find(id);
        }
    }
}
