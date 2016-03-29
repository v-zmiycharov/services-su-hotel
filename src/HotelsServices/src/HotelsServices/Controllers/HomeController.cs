using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using HotelsServices.ViewModels.Home;
using HotelsServices.Repositories;

namespace HotelsServices.Controllers
{
    public class HomeController : Controller
    {
        private IHotelsRepository _hotelsRepository;
        private ITranslateRepository _translateRepository;

        public HomeController()
        {
            _hotelsRepository = new FakeHotelsRepository();
            _translateRepository = new FakeTranslateRepository();
        }

        public IActionResult Index(string cityId = null, string hotelId = null)
        {
            var vm = new SearchVM()
            {
                CityId = cityId,
                HotelId = hotelId
            };
            
            return View(vm);
        }

        [HttpPost]
        public IActionResult Search(SearchVM vm)
        {
            if(!ModelState.IsValid)
                return RedirectToAction("Index", new { cityId = vm.CityId, hotelId = vm.HotelId });

            return RedirectToAction("Details", new { id = vm.HotelId });
        }

        public IActionResult Details(string id, string lang = "")
        {
            var vm = _hotelsRepository.GetHotelDetails(id);

            vm.Translate(_translateRepository, lang);

            return View(vm);
        }
        
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
