using HotelsServices.Models;
using HotelsServices.ViewModels.Home;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace HotelsServices.Repositories
{
    public interface IHotelReservationsRepository
    {
        IEnumerable<HotelReservation> GetHotelReservations();
    }

    public class HotelReservationsRepository : IHotelReservationsRepository
    {
        public IEnumerable<HotelReservation> GetHotelReservations()
        {
            IEnumerable<HotelReservation> result = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:19380/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = client.GetAsync("api/HotelReservations").GetAwaiter().GetResult();
                if (response.IsSuccessStatusCode)
                {
                    var jsonContent = response.Content.ReadAsStringAsync().Result;
                    result = JsonConvert.DeserializeObject<IEnumerable<HotelReservation>>(jsonContent);
                }
            }

            return result;
        }
    }
}
