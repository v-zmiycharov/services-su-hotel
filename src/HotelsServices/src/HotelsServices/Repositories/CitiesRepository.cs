using HotelsServices.Helpers;
using HotelsServices.ViewModels.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelsServices.Repositories
{
    public interface ICitiesRepository
    {
        SearchNom GetCity(uint id);
        List<SearchNom> GetCities(string term);
    }

    public class FakeCitiesRepository: ICitiesRepository
    {
        private static List<SearchNom> _cities = new List<SearchNom>()
        {
            new SearchNom(){id = 1, text = "София" },
            new SearchNom(){id = 2, text = "Пловдив" },
            new SearchNom(){id = 3, text = "Пазарджик" },
        };

        public SearchNom GetCity(uint id)
        {
            return _cities.Single(e => e.id == id);
        }

        public List<SearchNom> GetCities(string term)
        {
            var result = _cities;
            if (!string.IsNullOrWhiteSpace(term))
                result = result.Where(e => e.text.ToLower().Contains(term.ToLower())).ToList();

            return result;
        }
    }


    public class SoapCitiesRepository : ICitiesRepository
    {
        public SearchNom GetCity(uint id)
        {
            getCityRequest request = new getCityRequest();
            request.id = id;

            var response = SOAPHelper.CallCitiesWebService<getCityResponse>(request);

            return new SearchNom() { id = response.city.id, text = response.city.name };
        }

        public List<SearchNom> GetCities(string term)
        {
            getCitiesRequest request = new getCitiesRequest();
            request.term = term;

            var response = SOAPHelper.CallCitiesWebService<getCitiesResponse>(request);
            
            response.cities.Select(e => new SearchNom() {id = e.id, text = e.name });
        }
    }
}
