using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Services.Classes;
using WebApplication2.Services.ViewModels;

namespace WebApplication2.Controllers
{
    [Route("api/classes")]
    [ApiController]
    public class ClassController : ControllerBase
    {
        private ClassRepo _cls;
        private IMapper _mapper;

        public ClassController(ClassRepo cls, IMapper mapper)
        {
            _cls = cls;
            _mapper = mapper;
        }



        [HttpGet]
        public IActionResult getAllClasses() {
            var allvalues = _cls.AllClasses();
            var filtereddvalues = _mapper.Map<ICollection<classDto>>(allvalues);
            return Ok(filtereddvalues);
        }

        [HttpGet("{id}")]
        public IActionResult getCalssDetail(int id)
        {
            var values = _cls.getClassdetail(id);
           
            if(values == null)
            {
                return NotFound();
            }
          //  var filtereddvalue = _mapper.Map<ICollection<classDto>>(values);

            return Ok(values);
        }


    }
}
