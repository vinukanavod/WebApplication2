using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using WebApplication2.Services;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        private ITodooRepo _addService;
         
        public ValuesController(ITodooRepo REPO)
        {
          _addService= REPO;
        }

        [HttpGet] //("{id}")
        public IActionResult GetTodoo(int? id)
        {
            // var x = GetAllTodoos().Where(t => t.Id ==id);
            

            var x = _addService.GetAllTodoos();
            if( id == null)
            {
                return Ok(x);
            }
            x = x.Where(t => t.Id == id).ToList();

            return Ok(x);
        }



        [HttpGet] //("{id}")
        public IActionResult GetTodoomommy(int? id)
        {
            // var x = GetAllTodoos().Where(t => t.Id ==id);


            var x = _addService.GetAllTodoomommies();
            if (id == null)
            {
                return Ok(x);
            }
            x = x.Where(t => t.Id == id).ToList();

            return Ok(x);
        }


    }

  

}
