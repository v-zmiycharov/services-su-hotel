using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelsServices.Models
{
    public class HotelReservation
    {
        [Key]
        public int HotelReservationId { get; set; }
        public string HotelName { get; set; }
        public int HotelId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public int AdultsCount { get; set; }
        public int ChildrenCount { get; set; }
    }
}
