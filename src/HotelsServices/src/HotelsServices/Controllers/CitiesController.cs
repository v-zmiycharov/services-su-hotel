using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Http;
using Microsoft.AspNet.Mvc;
using Microsoft.Data.Entity;
using HotelsServices.Models;
using HotelsServices.ViewModels.Home;

namespace HotelsServices.Controllers
{
    [Produces("application/json")]
    [Route("api/Cities")]
    public class CitiesController : Controller
    {
        private static List<SearchNom> _cities = new List<SearchNom>()
        {
            new SearchNom(){id = "1", text = "София" },
            new SearchNom(){id = "2", text = "Пловдив" },
            new SearchNom(){id = "3", text = "Пазарджик" },
        };

        private ApplicationDbContext _context;

        public CitiesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Cities/5
        [HttpGet("{id}", Name = "GetCity")]
        public async Task<IActionResult> GetCity([FromRoute] string id)
        {
            var city = _cities.Single(e => e.id == id);

            return Ok(city);
        }
        
        // POST: api/Cities
        [HttpPost]
        public async Task<IActionResult> PostCities(string term)
        {
            var result = _cities;
            if(!string.IsNullOrWhiteSpace(term))
            {
                result = result.Where(e => e.text.ToLower().Contains(term.ToLower())).ToList();
            }
            return Ok(result);
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