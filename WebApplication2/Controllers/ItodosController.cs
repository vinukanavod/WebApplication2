using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using WebApplication2.Services.Todos;
using WebApplication2.Services.ViewModels;

namespace WebApplication2.Controllers
{
    [Route("api/authors/{authorid}/itudus")]
    [ApiController]
    public class ItodosController : ControllerBase
    {

        private ITodooRepo _addService;
        private readonly IMapper _mapper;
        public ItodosController(IMapper mapper ,ITodooRepo yy)
        {
            _addService = yy;
            _mapper = mapper;
        }

        [HttpGet()] //("{id}")
        public IActionResult GetallTodoo(int authorid)
        {
            // var x = GetAllTodoos().Where(t => t.Id ==id);
            

            var x = _addService.GetAllTodoos(authorid);
           /* if( id == null)
            {
                return Ok(x);
            }
            x = x.Where(t => t.Id == id).ToList();*/
           var maptodos = _mapper.Map<ICollection< TodoDto>>(x);

            return Ok(maptodos);
        }
       

        [HttpGet("{id}")]
         public IActionResult GetOneTodoo(int authorid,int id)
        {
            var ddd = _addService.GetTodoo(authorid,id);
            if( ddd == null)
            {
                return NotFound();
            }
            var maptodos = _mapper.Map<TodoDto>( ddd);
            return Ok(maptodos);
        }



    }



}
