using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Services.Authors;
using WebApplication2.Services.ViewModels;

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
        public IActionResult GetAllAuthorsheee()
        {
            var heehee= _authorrepo.GetAllAuthors();
            var authoDTO = new List<AuthorDto>();
            foreach (var author in heehee)
            {
                authoDTO.Add(new AuthorDto
                {
                    Id= author.Id,
                    FirstName= author.FirstName,
                    LastName= author.LastName,
                    Adress= $"{author.AdderssNo},{author.Street},{author.City}"
                });
            }
            return Ok(authoDTO);
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
