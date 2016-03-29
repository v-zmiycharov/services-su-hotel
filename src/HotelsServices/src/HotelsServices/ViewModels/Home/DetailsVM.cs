using Microsoft.AspNet.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelsServices.ViewModels.Home
{
    public class DetailsVM
    {
        public string Name { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public int RoomsCount { get; set; }
        public decimal Price { get; set; }
        public int Stars { get; set; }
        public List<string> Facilities { get; set; }
    }
}
