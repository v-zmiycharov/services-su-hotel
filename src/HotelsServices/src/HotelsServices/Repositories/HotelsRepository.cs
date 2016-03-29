using HotelsServices.ViewModels.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelsServices.Repositories
{
    public interface IHotelsRepository
    {
        SearchNom GetHotel(string id);
        List<SearchNom> GetHotels(string term, string parentId);
        DetailsVM GetHotelDetails(string id);
    }

    public class FakeHotelsRepository : IHotelsRepository
    {
        private static List<SearchNom> _hotels = new List<SearchNom>()
        {
            new SearchNom(){id = "1", text = "Плиска", parentId = "1" },
            new SearchNom(){id = "2", text = "Гранд хотел София", parentId = "1" },
            new SearchNom(){id = "3", text = "Вега", parentId = "1" },

            new SearchNom(){id = "4", text = "Тримонциум", parentId = "2" },
            new SearchNom(){id = "5", text = "Санкт Петербург", parentId = "2" },
            new SearchNom(){id = "6", text = "Империал", parentId = "2" },

            new SearchNom(){id = "7", text = "Тракия", parentId = "3" },
            new SearchNom(){id = "8", text = "Елбрус", parentId = "3" },
            new SearchNom(){id = "9", text = "Хебър", parentId = "3" },
        };

        public SearchNom GetHotel(string id)
        {
            return _hotels.Single(e => e.id == id);
        }

        public List<SearchNom> GetHotels(string term, string parentId)
        {
            List<SearchNom> result = _hotels;

            if (!string.IsNullOrWhiteSpace(parentId))
            {
                result = result.Where(e => e.parentId.Equals(parentId)).ToList();
            }

            if (!string.IsNullOrWhiteSpace(term))
            {
                result = result.Where(e => e.text.ToLower().Contains(term.ToLower())).ToList();
            }

            return result;
        }

        public DetailsVM GetHotelDetails(string id)
        {
            return new DetailsVM()
            {
                Id = id,
                Address = "бул. Д-р. Г.M. Димитров 75",
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
                Price = 65,
                RoomsCount = 77,
                Stars = 4
            };
        }
    }
}
