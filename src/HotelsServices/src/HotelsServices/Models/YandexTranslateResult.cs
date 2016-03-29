using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;

namespace HotelsServices.Models
{
    public class YandexTranslateResult
    {
        public string Code { get; set; }
        public string Lang { get; set; }
        public List<string> Text { get; set; }
    }
}
