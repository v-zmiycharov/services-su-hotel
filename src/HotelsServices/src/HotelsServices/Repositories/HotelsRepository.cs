﻿using HotelsServices.ViewModels.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelsServices.Repositories
{
    public interface IHotelsRepository
    {
        HotelsPortService service { get; set; }

        SearchNom GetHotel(uint id);
        List<SearchNom> GetHotels(string term, uint? parentId);
        DetailsVM GetHotelDetails(uint id);
    }

    public class FakeHotelsRepository : IHotelsRepository
    {
        public HotelsPortService service { get; set; }

        private static List<SearchNom> _hotels = new List<SearchNom>()
        {
            new SearchNom(){id = 1, text = "Плиска", parentId = 1 },
            new SearchNom(){id = 2, text = "Гранд хотел София", parentId = 1 },
            new SearchNom(){id = 3, text = "Вега", parentId = 1 },

            new SearchNom(){id = 4, text = "Тримонциум", parentId = 2 },
            new SearchNom(){id = 5, text = "Санкт Петербург", parentId = 2 },
            new SearchNom(){id = 6, text = "Империал", parentId = 2 },

            new SearchNom(){id = 7, text = "Тракия", parentId = 3 },
            new SearchNom(){id = 8, text = "Елбрус", parentId = 3 },
            new SearchNom(){id = 9, text = "Хебър", parentId = 3 },
        };

        public SearchNom GetHotel(uint id)
        {
            return _hotels.Single(e => e.id == id);
        }

        public List<SearchNom> GetHotels(string term, uint? parentId)
        {
            List<SearchNom> result = _hotels;

            if (parentId.HasValue)
            {
                result = result.Where(e => e.parentId.Equals(parentId)).ToList();
            }

            if (!string.IsNullOrWhiteSpace(term))
            {
                result = result.Where(e => e.text.ToLower().Contains(term.ToLower())).ToList();
            }

            return result;
        }

        public DetailsVM GetHotelDetails(uint id)
        {
            return new DetailsVM()
            {
                Id = id,
                Address = "Boulevard GM Dimitrov",
                PhoneNumber = "0888 123 456",
                City = "Sofia",
                Description = @"For relaxation and good shape of our guests is provided extensive sports and recreation center. For lovers of fitness has a well equipped gym with professional fitness instructors. There are aesthetically rooms, which offer all kinds of relaxing treatments and massage programs. Guests and clients of the center can get rid of stress and tension with sauna and steam bath. For refreshment and complete landing our special massage programs and a good, healthy tan is provided fire hall with solarium.
                The hotel offers modern hairdressing salon.V employing proven professionals
                who are able and know how to take care of the good appearance of the customers.",
                Facilities = new List<string>()
                {
                    "Restaurant",
                    "Fitness",
                    "SPA procedures",
                    "Wi Fi",
                    "Free parking"
                },
                Name = "Hotel Vega",
                SingleRoomPrice = 65,
                DoubleRoomPrice = 75,
                TripleRoomPrice = 85,
                RoomsCount = 77,
                Stars = 4
            };
        }
    }

    public class SoapHotelsRepository : IHotelsRepository
    {
        public HotelsPortService service { get; set; }

        public SoapHotelsRepository()
        {
            this.service = new HotelsPortService();
        }

        public SearchNom GetHotel(uint id)
        {
            getHotelRequest request = new getHotelRequest();
            request.id = id;

            var response = service.getHotel(request);

            return new SearchNom() { id = response.hotel.id, text = response.hotel.name };
        }

        public List<SearchNom> GetHotels(string term, uint? parentId)
        {
            getHotelsRequest request = new getHotelsRequest();

            if (term == null)
                request.term = "";
            else
                request.term = term;

            if (parentId.HasValue)
            { 
                request.city_id = parentId.Value;
            }

            var response = service.getHotels(request);

            return response.hotels.Select(e => new SearchNom() {id = e.id, text = e.name }).ToList();
        }

        public DetailsVM GetHotelDetails(uint id)
        {
            getHotelDetailsRequest request = new getHotelDetailsRequest();
            request.id = id;

            var response = service.getHotelDetails(request);

            return new DetailsVM()
            {
                Address = response.hotel.contacts.address,
                PhoneNumber = response.hotel.contacts.phone_number,
                City = response.hotel.city_name,
                Description = response.hotel.description,
                Facilities = response.hotel.facilities.ToList(),
                Id = response.hotel.id,
                Name = response.hotel.name,
                SingleRoomPrice = response.hotel.price_list.single_room,
                DoubleRoomPrice = response.hotel.price_list.double_room,
                TripleRoomPrice = response.hotel.price_list.triple_room,
                RoomsCount = response.hotel.room_count,
                Stars = response.hotel.stars
            };
        }
    }
}
