using RestSharp;
using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var client = new RestClient("https://translate.yandex.net/api/v1.5/tr.json/translate?text=nasılsın&key=trnsl.1.1.20200425T204100Z.37746e672bb1e896.5d815da7a23ee5a1b7fe7d7cdd26d5ebeb412ced&lang=tr-en");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
        }
    }
}
