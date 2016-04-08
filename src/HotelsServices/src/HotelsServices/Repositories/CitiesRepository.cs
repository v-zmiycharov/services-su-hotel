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
        SearchNom GetCity(string id);
        List<SearchNom> GetCities(string term);
    }

    public class FakeCitiesRepository: ICitiesRepository
    {
        private static List<SearchNom> _cities = new List<SearchNom>()
        {
            new SearchNom(){id = "1", text = "София" },
            new SearchNom(){id = "2", text = "Пловдив" },
            new SearchNom(){id = "3", text = "Пазарджик" },
        };

        public SearchNom GetCity(string id)
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
        public SearchNom GetCity(string id)
        {
            return SOAPHelper.CallWebServiceGET<SearchNom>(string.Format("action?id={0}", id));
        }

        public List<SearchNom> GetCities(string term)
        {
            return SOAPHelper.CallWebServiceGET<List<SearchNom>>(string.Format("action?term={0}", term));
        }
    }
}
