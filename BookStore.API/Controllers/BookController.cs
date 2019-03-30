using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.BLL.Implementation;
using Microsoft.AspNetCore.Mvc;
using BookStore.BLL.Interface;

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
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(Guid id)
        {
            var book = _bookLogic.GetBookById(id);
            return "ok";
        }

        [HttpPost]
        public string Post([FromBody] string value)
        {
            return value;
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
