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
            this.LabelSingleRoom = "Single room:";
            this.LabelDoubleRoom = "Double room:";
            this.LabelTripleRoom = "Apartment:";
            this.LabelRoomsCount = "Rooms count:";
            this.LabelLv = "lev";
            this.LabelFacilities = "Facilities";
        }

        public void Translate(ITranslateRepository translateRepository, string toLang)
        {
            if (!String.IsNullOrWhiteSpace(toLang))
            {
                this.Name = translateRepository.Translate(this.Name, toLang);
                this.City = translateRepository.Translate(this.City, toLang);
                this.Address = translateRepository.Translate(this.Address, toLang);
                this.Description = translateRepository.Translate(this.Description, toLang);

                if (this.Facilities != null && this.Facilities.Count > 0)
                {
                    var oldFacilities = new List<string>();
                    oldFacilities.AddRange(this.Facilities);

                    this.Facilities = new List<string>();

                    foreach (var facility in oldFacilities)
                        this.Facilities.Add(translateRepository.Translate(facility, toLang));
                }

                this.LabelSingleRoom = translateRepository.Translate(this.LabelSingleRoom, toLang);
                this.LabelDoubleRoom = translateRepository.Translate(this.LabelDoubleRoom, toLang);
                this.LabelTripleRoom = translateRepository.Translate(this.LabelTripleRoom, toLang);
                this.LabelRoomsCount = translateRepository.Translate(this.LabelRoomsCount, toLang);
                this.LabelLv = translateRepository.Translate(this.LabelLv, toLang);
                this.LabelFacilities = translateRepository.Translate(this.LabelFacilities, toLang);
            }
        }
    }
}
