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
    [Route("api/Cities")]
    public class CitiesController : Controller
    {
        private ApplicationDbContext _context;
        private ICitiesRepository _citiesRepository;

        public CitiesController(ApplicationDbContext context)
        {
            _context = context;
            _citiesRepository = new FakeCitiesRepository();
        }

        // GET: api/Cities/5
        [HttpGet("{id}", Name = "GetCity")]
        public async Task<IActionResult> GetCity([FromRoute] string id)
        {
            return Ok(_citiesRepository.GetCity(id));
        }
        
        // POST: api/Cities
        [HttpPost]
        public async Task<IActionResult> PostCities(string term)
        {
            return Ok(_citiesRepository.GetCities(term));
        }
        
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ApplicationUserExists(string id)
        {
            return _context.ApplicationUser.Count(e => e.Id == id) > 0;
        }
    }
}