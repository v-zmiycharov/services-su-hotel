using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using HotelsServices.ViewModels.Home;

namespace HotelsServices.Controllers
{
    public class HomeController : Controller
    {
        private DetailsVM _detailsVM = new DetailsVM()
        {
            Address = "бул. Д-р. Г.M. Димитров 75",
            City = "София",
            Description = @"За релаксацията и добрата форма на нашите гости е предвиден обширен спортен и възстановителен център. За любителите на фитнеса има модерно оборудвана зала с уреди и професионални фитнес инструктори. На разположение са естетически издържани стаи, в които се предлагат всякакви разпускащи процедури и масажни програми. Гостите и клиентите на центъра могат да се освободят от стреса и натрупаното напрежение със сауна и парна баня. За ободряване и пълно разтоварване са специалните ни масажни програми, а за добър, здравословен тен е предведена зала със солариум.
                Хотелът предлага и модерен фризьорски салон.В тях работят доказани професионалисти,
                които умеят и знаят как да се погрижат за добрия външен вид на клиентите.",
            Facilities = new List<string>()
            {
                "Ресторант",
                "Фитнес",
                "СПА процедури",
                "Тери шоп",
                "Фризьорски салон",
                "Паркинг"
            },
            Name = "Хотел Вега",
            Price = 65,
            RoomsCount = 77,
            Stars = 4
        };

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
            var vm = _detailsVM;

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
