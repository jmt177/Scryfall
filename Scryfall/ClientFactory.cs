using System.Net.Http;
using System.Net.Http.Headers;
using System;

namespace Scryfall
{
    internal class ClientFactory
    {
        private static HttpClient Client;

        static ClientFactory()
        {
            Client = new HttpClient()
            {
                BaseAddress = new Uri("https://api.scryfall.com"),
                DefaultRequestHeaders =
                {
                    Accept = { new MediaTypeWithQualityHeaderValue("application/json") }
                }
            };
        }

        internal static HttpClient GetScryfallClient()
        {
            return Client;
        }
    }
}
