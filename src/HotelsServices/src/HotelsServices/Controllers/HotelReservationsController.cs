using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using HotelsServices.Models;

namespace HotelsServices.Controllers
{
    public class HotelReservationsController : Controller
    {
        private ApplicationDbContext _context;

        public HotelReservationsController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: HotelReservations
        public IActionResult Index()
        {
            return View(_context.HotelReservation.ToList());
        }

        // GET: HotelReservations/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            HotelReservation hotelReservation = _context.HotelReservation.Single(m => m.HotelReservationId == id);
            if (hotelReservation == null)
            {
                return HttpNotFound();
            }

            return View(hotelReservation);
        }

        // GET: HotelReservations/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: HotelReservations/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(HotelReservation hotelReservation)
        {
            if (ModelState.IsValid)
            {
                _context.HotelReservation.Add(hotelReservation);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hotelReservation);
        }

        // GET: HotelReservations/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            HotelReservation hotelReservation = _context.HotelReservation.Single(m => m.HotelReservationId == id);
            if (hotelReservation == null)
            {
                return HttpNotFound();
            }
            return View(hotelReservation);
        }

        // POST: HotelReservations/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(HotelReservation hotelReservation)
        {
            if (ModelState.IsValid)
            {
                _context.Update(hotelReservation);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hotelReservation);
        }

        // GET: HotelReservations/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            HotelReservation hotelReservation = _context.HotelReservation.Single(m => m.HotelReservationId == id);
            if (hotelReservation == null)
            {
                return HttpNotFound();
            }

            return View(hotelReservation);
        }

        // POST: HotelReservations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            HotelReservation hotelReservation = _context.HotelReservation.Single(m => m.HotelReservationId == id);
            _context.HotelReservation.Remove(hotelReservation);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
