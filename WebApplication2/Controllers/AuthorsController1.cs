using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Runtime.CompilerServices;
using WebApplication2.Services.Authors;
using WebApplication2.Services.ViewModels;

namespace WebApplication2.Controllers
{
    [Route("api/authors")]
    [ApiController]
    public class AuthorsController1 : ControllerBase
    {
        private AuthorRepo _authorrepo;
        private readonly IMapper _mapper;
        public AuthorsController1(AuthorRepo aa,IMapper mapper)//methanadi thamai constructor ekata inject karanne
        {
            _authorrepo = aa;
            _mapper = mapper;

        }
       
        /// <summary>
        /// /////////
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetAllAuthorsheee()
        {
           
            var heehee= _authorrepo.GetAllAuthors();
           // var authoDTO = new List<AuthorDto>();
            /* foreach (var author in heehee)
             {
                 authoDTO.Add(new AuthorDto
                 {
                     Id= author.Id,
                     FirstName= author.FirstName,
                     LastName= author.LastName,
                     Adress= $"{author.AdderssNo},{author.Street},{author.City}"
                 });
             }*/
           var Dtoresult= _mapper.Map<ICollection<AuthorDto>>(heehee);


            return Ok(Dtoresult);
        }

        /// <summary>
       
       
        /// <returns></returns>
        [HttpGet("{id}")]
       public IActionResult GetAuthor(int id) {
        var hoohoo = _authorrepo.GetAuthor(id);
            if(hoohoo == null)
            {
                return NotFound();
            }
            var Dto = _mapper.Map<AuthorDto>(hoohoo);     
        return Ok(Dto);
        }

    }
}
