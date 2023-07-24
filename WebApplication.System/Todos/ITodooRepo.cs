using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Services.Todos
{
    public interface ITodooRepo
    {
        public List<Todoo> GetAllTodoos(int authorid);
        public List<Todoomommy> GetAllTodoomommies();

        public Todoo GetTodoo(int authorid,int id);
    }
}
