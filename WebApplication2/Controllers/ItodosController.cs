using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Services.Todos;

namespace WebApplication2.Controllers
{
    [Route("api/itudus")]
    [ApiController]
    public class ItodosController : ControllerBase
    {

        private ITodooRepo _addService;

        public ItodosController(ITodooRepo yy)
        {
            _addService = yy;
        }

        [HttpGet] //("{id}")
        public IActionResult GetTodoo(int id)
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
       

        [HttpGet("{id}")]
         public IActionResult GetOneTodoo(int id)
        {
            var ddd = _addService.GetTodoo(id);
            if( ddd == null)
            {
                return NotFound();
            }
            return Ok(ddd);
        }



    }



}
