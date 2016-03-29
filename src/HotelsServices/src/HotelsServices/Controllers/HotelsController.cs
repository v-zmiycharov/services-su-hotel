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
    [Route("api/Hotels")]
    public class HotelsController : Controller
    {
        private static List<SearchNom> _hotels = new List<SearchNom>()
        {
            new SearchNom(){id = "1", text = "Плиска", parentId = "1" },
            new SearchNom(){id = "2", text = "Гранд хотел София", parentId = "1" },
            new SearchNom(){id = "3", text = "Вега", parentId = "1" },

            new SearchNom(){id = "4", text = "Тримонциум", parentId = "2" },
            new SearchNom(){id = "5", text = "Санкт Петербург", parentId = "2" },
            new SearchNom(){id = "6", text = "Империал", parentId = "2" },

            new SearchNom(){id = "7", text = "Тракия", parentId = "3" },
            new SearchNom(){id = "8", text = "Елбрус", parentId = "3" },
            new SearchNom(){id = "9", text = "Хебър", parentId = "3" },
        };

        private ApplicationDbContext _context;

        public HotelsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Hotels/5
        [HttpGet("{id}", Name = "GetHotel")]
        public async Task<IActionResult> GetHotel([FromRoute] string id)
        {
            var hotel = _hotels.Single(e => e.id == id);

            return Ok(hotel);
        }

        // POST: api/Hotels
        [HttpPost]
        public async Task<IActionResult> PostHotels(string term, string parentId)
        {
            List<SearchNom> result = _hotels;

            if (!string.IsNullOrWhiteSpace(parentId))
            {
                result = result.Where(e=>e.parentId.Equals(parentId)).ToList();
            }

            if (!string.IsNullOrWhiteSpace(term))
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