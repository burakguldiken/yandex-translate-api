using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YandexApi.YandexApi
{
    public class Yandex
    {
        public string key;
    
        public Yandex()
        {
            this.key = "trnsl.1.1.20200425T204100Z.37746e672bb1e896.5d815da7a23ee5a1b7fe7d7cdd26d5ebeb412ced";
        }

        public string Translate(string text,string sourceLanguage, string destLanguage)
        {
            string command = String.Format("https://translate.yandex.net/api/v1.5/tr.json/translate?text={0}&key={1}&lang={2}-{3}",text,key,sourceLanguage,destLanguage);
            var client = new RestClient(command);
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            IRestResponse response = client.Execute(request);
            return response.Content;
        }

        public string Detect(string text)
        {
            string command = String.Format("https://translate.yandex.net/api/v1.5/tr.json/detect?text={0}&key={1}&lang=tr-en",text,key);
            var client = new RestClient(command);
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            IRestResponse response = client.Execute(request);
            return response.Content;
        }

        public string SupportedLanguage()
        {
            string command = String.Format("https://translate.yandex.net/api/v1.5/tr.json/getLangs?key={0}&lang=tr-en",key);
            var client = new RestClient("https://translate.yandex.net/api/v1.5/tr.json/getLangs?key=trnsl.1.1.20200425T204100Z.37746e672bb1e896.5d815da7a23ee5a1b7fe7d7cdd26d5ebeb412ced&lang=tr-en");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            IRestResponse response = client.Execute(request);
            return response.Content;
        }
    }

    
}
