using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.BLL.Implementation;
using Microsoft.AspNetCore.Mvc;
using BookStore.BLL.Interface;
using BookStore.DAL.Models;
using Microsoft.AspNetCore.Http;

namespace BookStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private IBookLogic _bookLogic;

        public BookController(IBookLogic bookLogic)
        {
            _bookLogic = bookLogic;
        }

        [HttpGet]
        public ActionResult<string> Get()
        {
            var allBook = _bookLogic.GettAllBook();
            return StatusCode(StatusCodes.Status200OK, allBook);
        }

       [HttpGet("{id}")]
        public ActionResult<string> Get(Guid id)
        {
            var book = _bookLogic.GetBookById(id);
            return StatusCode(StatusCodes.Status200OK, book);
        }

        [HttpPost]
        public ActionResult Post([FromBody] Book book)
        {
           var insertedBook = _bookLogic.CreateBook(book);
            if (insertedBook == null)
            {
                throw new Exception("Error in create new Book");
            }
            return StatusCode(StatusCodes.Status201Created, insertedBook);
        }

        [HttpPut("{id}")]
        public ActionResult<string> Put(Guid id, [FromBody] Book book)
        {
            _bookLogic.UpdateBook(id, book);
            return StatusCode(StatusCodes.Status200OK);
        }


         [HttpDelete("{id}")]
        public ActionResult<string> Delete(Guid id)
        {
            _bookLogic.DeleteBook(id);
            return StatusCode(StatusCodes.Status200OK);
        }
    }
}
