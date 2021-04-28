using Desk.Gist.EntityFrameworkCore.WebApi.Datas;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desk.Gist.EntityFrameworkCore.WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TmpController : ControllerBase
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public TmpController(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            await _applicationDbContext.Blogs.FindAsync(1234);
            return Ok(DateTime.Now);
        }
    }
}
