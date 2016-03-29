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
        public string HotelId { get; set; }
    }

    public class SearchNom
    {
        public string id { get; set; }
        public string text { get; set; }
        public string parentId { get; set; }
    }
}
