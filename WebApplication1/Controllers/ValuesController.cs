using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly ValuesDBContext _context;

        public ValuesController(ValuesDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Values.ToList());
        }

        [HttpPost]
        public IActionResult Post(Value value)
        {
            var valueEntry = _context.Values.Add(value);
            _context.SaveChanges();
            return Ok(valueEntry.Entity);
        }
    }
}
