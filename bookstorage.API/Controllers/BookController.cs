using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bookstorage.BLL.BusinessImplementations;
using Microsoft.AspNetCore.Mvc;

namespace bookstorage.API.Controllers
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

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(Guid id)
        {
            var gostoso = _bookLogic.SAHdsdhf(id);
            Console.Write(gostoso);
            return "gostoso";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
