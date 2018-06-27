using System;

namespace Scryfall
{
    class Program
    {
        static void Main(string[] args)
        {
            DoTheStuff();
        }

        public static async void DoTheStuff()
        {
            var scryfallClient = new ScryfallClient();

            var cardsResponse = await scryfallClient.GetRandomCard();
        }
    }
}
 