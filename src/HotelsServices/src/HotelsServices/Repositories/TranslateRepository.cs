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
        string TranslateFromBg(string input, string toLang);
        string Translate(string input, string toLang, string fromLang);
    }

    public class FakeTranslateRepository : ITranslateRepository
    {
        public string TranslateFromBg(string input, string toLang)
        {
            return Translate(input, toLang, "bg");
        }

        public string Translate(string input, string toLang, string fromLang)
        {
            return input;
        }
    }

    public class YandexTranslateRepository : ITranslateRepository
    {
        public string TranslateFromBg(string input, string toLang)
        {
            return Translate(input, toLang, "bg");
        }

        public string Translate(string input, string toLang, string fromLang)
        {
            string url = string.Format("https://translate.yandex.net/api/v1.5/tr.json/translate?key={0}&text={1}&lang={2}-{3}"
                , "trnsl.1.1.20160329T125742Z.7cf7029a7299121f.e2035c38942a41a74d94459866c16182668762f8"
                , input
                , fromLang
                , toLang);


            var result = GetRequest<JObject>(url).ToObject<YandexTranslateResult>();

            if (result != null && result.Text != null && result.Text.Count > 0)
                return result.Text[0];
            else
                return input;
        }


        private static T GetRequest<T>(string url)
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);

            request.Method = "GET";
            request.AllowAutoRedirect = false;
            request.Accept = "application/json, text/plain, */*";
            request.ContentType = "application/json; charset=UTF-8";

            return ReadResponse<T>(request);
        }

        private static T ReadResponse<T>(HttpWebRequest request)
        {
            T jO;

            using (var response = request.GetResponse())
            using (var responseStream = response.GetResponseStream())
            using (var reader = new StreamReader(responseStream))
            {
                var responseFromServer = reader.ReadToEnd();
                jO = JsonConvert.DeserializeObject<T>(responseFromServer);
            }

            return jO;
        }
    }
}
