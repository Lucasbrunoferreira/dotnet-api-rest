using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bookstorage.BLL.BusinessImplementations;
using Microsoft.AspNetCore.Mvc;

namespace Bookstorage.API.Controllers
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
            var gostoso = _bookLogic.SAHdsdhf(id);
            Console.Write(gostoso);
            return "gostoso";
        }

        [HttpPost]
        public void Post([FromBody] string value)
        {
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
