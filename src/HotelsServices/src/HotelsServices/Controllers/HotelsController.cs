using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Http;
using Microsoft.AspNet.Mvc;
using Microsoft.Data.Entity;
using HotelsServices.Models;
using HotelsServices.ViewModels.Home;
using HotelsServices.Repositories;

namespace HotelsServices.Controllers
{
    [Produces("application/json")]
    [Route("api/Hotels")]
    public class HotelsController : Controller
    {
        private ApplicationDbContext _context;
        private IHotelsRepository _hotelsRepository;

        public HotelsController(ApplicationDbContext context)
        {
            _context = context;
            _hotelsRepository = new FakeHotelsRepository();
        }

        // GET: api/Hotels/5
        [HttpGet("{id}", Name = "GetHotel")]
        public async Task<IActionResult> GetHotel([FromRoute] uint id)
        {
            return Ok(_hotelsRepository.GetHotel(id));
        }

        // POST: api/Hotels
        [HttpPost]
        public async Task<IActionResult> PostHotels(string term, uint? parentId)
        {
            return Ok(_hotelsRepository.GetHotels(term, parentId));
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}