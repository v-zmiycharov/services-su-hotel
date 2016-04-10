using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Http;
using Microsoft.AspNet.Mvc;
using Microsoft.Data.Entity;
using HotelsServices.Models;
using System;

namespace HotelsServices.Controllers
{
    [Produces("application/json")]
    [Route("api/HotelReservations")]
    public class HotelReservationsController : Controller
    {
        private ApplicationDbContext _context;

        public HotelReservationsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/HotelReservations
        [HttpGet]
        public IEnumerable<HotelReservation> GetHotelReservation()
        {
            return _context.HotelReservation.OrderByDescending(e=>e.HotelReservationId);
        }

        // GET: api/HotelReservations/5
        [HttpGet("{id}", Name = "GetHotelReservation")]
        public IActionResult GetHotelReservation([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return HttpBadRequest(ModelState);
            }

            HotelReservation hotelReservation = _context.HotelReservation.Single(m => m.HotelReservationId == id);

            if (hotelReservation == null)
            {
                return HttpNotFound();
            }

            return Ok(hotelReservation);
        }

        // PUT: api/HotelReservations/5
        [HttpPut("{id}")]
        public IActionResult PutHotelReservation(int id, [FromBody] HotelReservation hotelReservation)
        {
            if (!ModelState.IsValid)
            {
                return HttpBadRequest(ModelState);
            }

            if (id != hotelReservation.HotelReservationId)
            {
                return HttpBadRequest();
            }

            _context.Entry(hotelReservation).State = EntityState.Modified;

            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HotelReservationExists(id))
                {
                    return HttpNotFound();
                }
                else
                {
                    throw;
                }
            }

            return new HttpStatusCodeResult(StatusCodes.Status204NoContent);
        }

        // POST: api/HotelReservations
        [HttpPost]
        public IActionResult PostHotelReservation(HotelReservation hotelReservation)
        {
            if (!ModelState.IsValid)
            {
                return HttpBadRequest(ModelState);
            }

            hotelReservation.CreateDate = DateTime.Now;
            _context.HotelReservation.Add(hotelReservation);
            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (HotelReservationExists(hotelReservation.HotelReservationId))
                {
                    return new HttpStatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("GetHotelReservation", new { id = hotelReservation.HotelReservationId }, hotelReservation);
        }

        // DELETE: api/HotelReservations/5
        [HttpDelete("{id}")]
        public IActionResult DeleteHotelReservation(int id)
        {
            if (!ModelState.IsValid)
            {
                return HttpBadRequest(ModelState);
            }

            HotelReservation hotelReservation = _context.HotelReservation.Single(m => m.HotelReservationId == id);
            if (hotelReservation == null)
            {
                return HttpNotFound();
            }

            _context.HotelReservation.Remove(hotelReservation);
            _context.SaveChanges();

            return Ok(hotelReservation);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool HotelReservationExists(int id)
        {
            return _context.HotelReservation.Count(e => e.HotelReservationId == id) > 0;
        }
    }
}