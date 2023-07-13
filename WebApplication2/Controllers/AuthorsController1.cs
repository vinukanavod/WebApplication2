using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Services.Authors;

namespace WebApplication2.Controllers
{
    [Route("api/authors")]
    [ApiController]
    public class AuthorsController1 : ControllerBase
    {
        private AuthorRepo _authorrepo;

        public AuthorsController1(AuthorRepo aa)//methanadi thamai constructor ekata inject karanne
        {
            _authorrepo = aa;

        }
        /// <summary>
        /// /////////
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetAllAuthors()
        {
            var heehee= _authorrepo.GetAllAuthors();
            return Ok(heehee);
        }

        /// <summary>
        /// //
        /// </summary>
       
        /// <returns></returns>
        [HttpGet("{id}")]
       public IActionResult GetAuthor(int id) {
        var hoohoo = _authorrepo.GetAuthor(id);
            if(hoohoo == null)
            {
                return NotFound();
            }
       return Ok(hoohoo);
        }

    }
}
