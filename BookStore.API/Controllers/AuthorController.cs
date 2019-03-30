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
        public ActionResult<string> Get()
        {
            var allAuthor = _authorLogic.GettAllAuthor();
            return StatusCode(StatusCodes.Status200OK, allAuthor);
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(Guid id)
        {
            var author = _authorLogic.GetAuthorById(id);
            return StatusCode(StatusCodes.Status200OK, author);
        }

        [HttpPost]
        public ActionResult Post([FromBody] Author author)
        {
            var insertedAuthor = _authorLogic.CreateAuthor(author);
            if (insertedAuthor == null)
            {
                throw new Exception("Error in create new Author");
            }
            return StatusCode(StatusCodes.Status201Created, insertedAuthor);
        }

        [HttpPut("{id}")]
        public ActionResult<string> Put(Guid id, [FromBody] Author author)
        {
            _authorLogic.UpdateAuthor(id, author);
            return StatusCode(StatusCodes.Status200OK);
        }


        [HttpDelete("{id}")]
        public ActionResult<string> Delete(Guid id)
        {
            _authorLogic.DeleteAuthor(id);
            return StatusCode(StatusCodes.Status200OK);
        }
    }
}
