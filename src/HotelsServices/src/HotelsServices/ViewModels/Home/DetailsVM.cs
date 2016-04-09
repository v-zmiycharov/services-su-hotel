using HotelsServices.Repositories;
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
        public uint Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public int RoomsCount { get; set; }
        public decimal Price { get; set; }
        public int Stars { get; set; }
        public List<string> Facilities { get; set; }

        public void Translate(ITranslateRepository translateRepository, string toLang)
        {
            if (!String.IsNullOrWhiteSpace(toLang))
            {
                this.Name = translateRepository.TranslateFromBg(this.Name, toLang);
                this.City = translateRepository.TranslateFromBg(this.City, toLang);
                this.Address = translateRepository.TranslateFromBg(this.Address, toLang);
                this.Description = translateRepository.TranslateFromBg(this.Description, toLang);

                if (this.Facilities != null && this.Facilities.Count > 0)
                {
                    var oldFacilities = new List<string>();
                    oldFacilities.AddRange(this.Facilities);

                    this.Facilities = new List<string>();

                    foreach (var facility in oldFacilities)
                        this.Facilities.Add(translateRepository.TranslateFromBg(facility, toLang));
                }
            }
        }
    }
}
