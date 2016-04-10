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
    public interface ITranslateRepository
    {
        string Translate(string input, string toLang, string fromLang = "en");
    }

    public class FakeTranslateRepository : ITranslateRepository
    {
        public string Translate(string input, string toLang, string fromLang = "en")
        {
            return input;
        }
    }

    public class YandexTranslateRepository : ITranslateRepository
    {
        public string Translate(string input, string toLang, string fromLang = "en")
        {
            YandexTranslateResult yandexResult = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://translate.yandex.net/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = client.GetAsync(string.Format("api/v1.5/tr.json/translate?key={0}&text={1}&lang={2}-{3}"
                    , "trnsl.1.1.20160329T125742Z.7cf7029a7299121f.e2035c38942a41a74d94459866c16182668762f8"
                    , input
                    , fromLang
                    , toLang))
                .GetAwaiter().GetResult();
                if (response.IsSuccessStatusCode)
                {
                    var jsonContent = response.Content.ReadAsStringAsync().Result;
                    yandexResult = JsonConvert.DeserializeObject<YandexTranslateResult>(jsonContent);
                }
            }
            
            if (yandexResult != null && yandexResult.Text != null && yandexResult.Text.Count > 0)
                return yandexResult.Text[0];
            else
                return input;
        }
        
    }
}
