using Microsoft.AspNet.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelsServices.ViewModels.Home
{
    public class SearchVM
    {
        public string CityId { get; set; }

        [Required]
        public string HotelId { get; set; }
    }

    public class SearchNom
    {
        public uint id { get; set; }
        public string text { get; set; }
        public uint? parentId { get; set; }
    }
}
