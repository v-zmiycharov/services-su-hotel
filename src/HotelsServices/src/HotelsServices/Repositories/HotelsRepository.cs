using HotelsServices.Helpers;
using HotelsServices.ViewModels.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelsServices.Repositories
{
    public interface IHotelsRepository
    {
        SearchNom GetHotel(uint id);
        List<SearchNom> GetHotels(string term, uint? parentId);
        DetailsVM GetHotelDetails(uint id);
    }

    public class FakeHotelsRepository : IHotelsRepository
    {
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
                Address = "бул. Д-р. Г.M. Димитров 75",
                PhoneNumber = "0888 123 456",
                City = "София",
                Description = @"За релаксацията и добрата форма на нашите гости е предвиден обширен спортен и възстановителен център. За любителите на фитнеса има модерно оборудвана зала с уреди и професионални фитнес инструктори. На разположение са естетически издържани стаи, в които се предлагат всякакви разпускащи процедури и масажни програми. Гостите и клиентите на центъра могат да се освободят от стреса и натрупаното напрежение със сауна и парна баня. За ободряване и пълно разтоварване са специалните ни масажни програми, а за добър, здравословен тен е предведена зала със солариум.
                Хотелът предлага и модерен фризьорски салон.В тях работят доказани професионалисти,
                които умеят и знаят как да се погрижат за добрия външен вид на клиентите.",
                Facilities = new List<string>()
                {
                    "Ресторант",
                    "Фитнес",
                    "СПА процедури",
                    "Тери шоп",
                    "Фризьорски салон",
                    "Паркинг"
                },
                Name = "Хотел Вега",
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
        public SearchNom GetHotel(uint id)
        {
            getHotelRequest request = new getHotelRequest();
            request.id = id;

            var response = SOAPHelper.CallHotelsWebService<getHotelResponse, getHotelRequest>(request);

            return new SearchNom() { id = response.hotel.id, text = response.hotel.name };
        }

        public List<SearchNom> GetHotels(string term, uint? parentId)
        {
            getHotelsRequest request = new getHotelsRequest();
            request.term = term;

            if(parentId.HasValue)
            { 
                request.city_id = parentId.Value;
            }

            var response = SOAPHelper.CallHotelsWebService<getHotelsResponse, getHotelsRequest>(request);

            return response.hotels.Select(e => new SearchNom() {id = e.id, text = e.name }).ToList();
        }

        public DetailsVM GetHotelDetails(uint id)
        {
            getHotelDetailsRequest request = new getHotelDetailsRequest();
            request.id = id;

            var response = SOAPHelper.CallHotelsWebService<getHotelDetailsResponse, getHotelDetailsRequest>(request);

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
