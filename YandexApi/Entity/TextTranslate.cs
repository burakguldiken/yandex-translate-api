using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YandexApi.Entity
{
    public class TextTranslate
    {
        public string text { get; set; }
        public string sourceLang { get; set; }
        public string destLang { get; set; }
    }
}
