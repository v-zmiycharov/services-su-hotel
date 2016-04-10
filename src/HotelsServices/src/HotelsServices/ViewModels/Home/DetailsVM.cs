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
        public string PhoneNumber { get; set; }
        public string Description { get; set; }
        public uint RoomsCount { get; set; }
        public uint SingleRoomPrice { get; set; }
        public uint DoubleRoomPrice { get; set; }
        public uint TripleRoomPrice { get; set; }
        public int Stars { get; set; }
        public List<string> Facilities { get; set; }

        public string LabelSingleRoom { get; set; }
        public string LabelDoubleRoom { get; set; }
        public string LabelTripleRoom { get; set; }
        public string LabelRoomsCount { get; set; }
        public string LabelLv { get; set; }
        public string LabelFacilities { get; set; }

        public DetailsVM()
        {
            this.LabelSingleRoom = "Единична стая:";
            this.LabelDoubleRoom = "Двойна стая:";
            this.LabelTripleRoom = "Апартамент:";
            this.LabelRoomsCount = "Брой стаи:";
            this.LabelLv = "лева";
            this.LabelFacilities = "Удобства";
        }

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

                this.LabelSingleRoom = translateRepository.TranslateFromBg(this.LabelSingleRoom, toLang);
                this.LabelDoubleRoom = translateRepository.TranslateFromBg(this.LabelDoubleRoom, toLang);
                this.LabelTripleRoom = translateRepository.TranslateFromBg(this.LabelTripleRoom, toLang);
                this.LabelRoomsCount = translateRepository.TranslateFromBg(this.LabelRoomsCount, toLang);
                this.LabelLv = translateRepository.TranslateFromBg(this.LabelLv, toLang);
                this.LabelFacilities = translateRepository.TranslateFromBg(this.LabelFacilities, toLang);
            }
        }
    }
}
