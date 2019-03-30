using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.BLL.Implementation;
using BookStore.DAL.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using BookStore.BLL.Interface;

namespace BookStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private IAuthorLogic _authorLogic;

        public AuthorController(IAuthorLogic authorLogic)
        {
            _authorLogic = authorLogic;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "author1", "author2" };
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(Guid id)
        {
            return "author";
        }

        [HttpPost]
        public ActionResult Post([FromBody] Author author)
        {
            var insertedAuthor = _authorLogic.CreateAuthor(author);
            if (insertedAuthor == null)
            {
                throw new Exception("Error in create new Author");
            }

            return StatusCode(StatusCodes.Status201Created,
                new { author = insertedAuthor.authorId });
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }


        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
