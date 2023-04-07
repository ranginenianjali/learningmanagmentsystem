using learningmanagmentsystem.Data;
using learningmanagmentsystem.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace learningmanagmentsystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : Controller
    {
        private readonly LmsAPIDbContext dbContext;
        public HomeController(LmsAPIDbContext dbContext)
        {
            this.dbContext = dbContext;
          
        }

        public LmsAPIDbContext DbContext { get; }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return Ok(await dbContext.hometable.ToListAsync());
            
        }
        [HttpPost]
        public async Task<IActionResult> Adddetails(homedetailsrequest hdr)
        {
            var details = new Home()
            {
                id = hdr.id,
                coursename = hdr.coursename,
                trainername = hdr.trainername

            };
            await dbContext.hometable.AddAsync(details);
            await dbContext.SaveChangesAsync();
            return Ok( details );

        }
    }
}
