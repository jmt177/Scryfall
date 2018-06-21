using System.Net.Http;
using System.Net.Http.Headers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Scryfall
{
    public class ScryfallClient
    {
        private static HttpClient client = ClientFactory.GetScryfallClient();

        public ScryfallClient() {}

        public async Task<List<Card>> GetAllCards()
        {
            var response = await client.GetAsync("cards/");
            var cardContent = await response.Content.ReadAsStringAsync();
            var cardsJson = JsonConvert.DeserializeObject<List<Card>>(cardContent);
            return cardsJson;
        }
    }
}
