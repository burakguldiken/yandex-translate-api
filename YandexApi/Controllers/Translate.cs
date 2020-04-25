using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestSharp;
using YandexApi.Entity;
using YandexApi.YandexApi;

namespace YandexApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Translate
    {
        /// <summary>
        /// Converts the entered text to the language you want
        /// </summary>
        /// <param name="translate">
        /// text = string,required,
        /// sourcLang = string,required,
        /// destLang = string,required
        /// </param>
        /// <returns></returns>
        [HttpPost("translate")]
        public IActionResult Translate_Text([FromBody] TextTranslate translate)
        {
            Yandex yandex = new Yandex();
            var result = yandex.Translate(translate.text, translate.sourceLang, translate.destLang);
            return new JsonResult(result);
        }

        /// <summary>
        /// Brings the language of the text
        /// </summary>
        /// <param name="detectLanguage">
        /// text = string,required
        /// </param>
        /// <returns></returns>
        [HttpPost("detect")]
        public IActionResult Detect_Text([FromBody] DetectLanguage detectLanguage)
        {
            Yandex yandex = new Yandex();
            var result = yandex.Detect(detectLanguage.text);
            return new JsonResult(result);
        }

        /// <summary>
        /// Get supported language list
        /// </summary>
        /// <param name="detectLanguage">
        /// text = string,required
        /// </param>
        /// <returns></returns>
        [HttpGet("supported")]
        public IActionResult Supported_Language()
        {
            Yandex yandex = new Yandex();
            var result = yandex.SupportedLanguage();
            return new JsonResult(result);
        }
    }
}
