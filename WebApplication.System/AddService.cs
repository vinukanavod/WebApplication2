using WebApplication2.Models;

namespace WebApplication2.Services
{
    public class AddService : ITodooRepo  //methanadi interface eka inherite karapu eka thamai kare
    {
        public List<Todoo> GetAllTodoos()
        {
            var TodooList = new List<Todoo>();

            var TodooList1 = new Todoo
            {
                Id = 1,
                Title = "Apatath Dawasaka Ira Payado",
                Description = "ME kathawen kiyawenne siriyawathi gana",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = TodooStatus.High

            };


            var TodooList2 = new Todoo
            {
                Id = 2,
                Title = "B",
                Description = "MEa",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(15),
                Status = TodooStatus.Middle


            };
            var TodooList3 = new Todoo
            {
                Id = 3,
                Title = "C",
                Description = " gana",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(25),
                Status = TodooStatus.High

            };
            TodooList.Add(TodooList1);
            TodooList.Add(TodooList2);
            TodooList.Add(TodooList3);

            return TodooList;
        }
    }
}
