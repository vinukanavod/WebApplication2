using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webapplication2.Database;
using WebApplication2.Models;

namespace WebApplication2.Services.Authors
{
    public class AuthorSQLserverService : AuthorRepo
    {
        public readonly TodoDbContext _context = new TodoDbContext();

        public List<Author> GetAllAuthors()
        {
            return _context.Authors.ToList();
        }

        public Author GetAuthor(int id)
        {
             return _context.Authors.Find(id);
            
        }
    }
}
