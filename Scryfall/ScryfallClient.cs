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

        // Cards

        private async Task<List<Card>> GetAllCards()
        {
            var response = await client.GetAsync("cards/");
            var cardContent = await response.Content.ReadAsStringAsync();
            var cardsJson = JsonConvert.DeserializeObject<List<Card>>(cardContent);
            return cardsJson;
        }

        public async Task<Card> GetRandomCard()
        {
            var response = client.GetAsync("cards/random").Result;
            var responseContent = await response.Content.ReadAsStringAsync();
            var card = JsonConvert.DeserializeObject<Card>(responseContent);
            return card;
        }

        public async Task<Card> GetCardByScyfallId(string id)
        {
            var response = client.GetAsync($"cards/{id}").Result;
            var responseContent = await response.Content.ReadAsStringAsync();
            var card = JsonConvert.DeserializeObject<Card>(responseContent);
            return card;
        }

        public async Task<Card> GetNamedCardExact(string exactName, string set = null)
        {
            var response = client.GetAsync($"cards/named?exact={exactName}").Result;
            var responseContent = await response.Content.ReadAsStringAsync();
            var card = JsonConvert.DeserializeObject<Card>(responseContent);
            return card;
        }

        public async Task<Card> GetNamedCardPartial(string partialName, string set = null)
        {
            var response = client.GetAsync($"cards/named?fuzzy={partialName}").Result;
            var responseContent = await response.Content.ReadAsStringAsync();
            var card = JsonConvert.DeserializeObject<Card>(responseContent);
            return card;
        }

        public async Task<Card> GetCardByMultiverseId(string id)
        {
            var response = client.GetAsync($"cards/multiverse/{id}").Result;
            var responseContent = await response.Content.ReadAsStringAsync();
            var card = JsonConvert.DeserializeObject<Card>(responseContent);
            return card;
        }

        public async Task<Card> GetCardByMtgoId(string id)
        {
            var response = client.GetAsync($"cards/mtgo/{id}").Result;
            var responseContent = await response.Content.ReadAsStringAsync();
            var card = JsonConvert.DeserializeObject<Card>(responseContent);
            return card;
        }

        public async Task<Card> GetCardByArenaId(string id)
        {
            var response = client.GetAsync($"cards/arena/{id}").Result;
            var responseContent = await response.Content.ReadAsStringAsync();
            var card = JsonConvert.DeserializeObject<Card>(responseContent);
            return card;
        }

        public async Task<Card> GetCardBySetCodeAndCollectorNumber(string setCode, string collectorNumber)
        {
            var response = client.GetAsync($"cards/{setCode}/{collectorNumber}").Result;
            var responseContent = await response.Content.ReadAsStringAsync();
            var card = JsonConvert.DeserializeObject<Card>(responseContent);
            return card;
        }

        // Sets

        private async Task<List<Set>> GetAllScryfallSets()
        {
            var response = client.GetAsync($"sets/").Result;
            var responseContent = await response.Content.ReadAsStringAsync();
            var sets = JsonConvert.DeserializeObject<List<Set>>(responseContent);
            return sets;
        }

        public async Task<Set> GetSetByCode(string code)
        {
            var response = client.GetAsync($"sets/{code}").Result;
            var responseContent = await response.Content.ReadAsStringAsync();
            var set = JsonConvert.DeserializeObject<Set>(responseContent);
            return set;
        }
    }
}
