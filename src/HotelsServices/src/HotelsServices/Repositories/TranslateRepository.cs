using HotelsServices.ViewModels.Home;
using System;
using System.Collections.Generic;
using System.Linq;
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
}
