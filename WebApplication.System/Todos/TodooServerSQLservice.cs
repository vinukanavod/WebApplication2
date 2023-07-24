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

        public List<Todoo> GetAllTodoos(int authorid)
        {
            return _context.Todos.Where(t => t.AuthorId == authorid).ToList();
        }

        public Todoo GetTodoo( int authorid,int id)
        {
            return _context.Todos.FirstOrDefault(t => t.Id== id && t.AuthorId== authorid);
        }
    }
}
