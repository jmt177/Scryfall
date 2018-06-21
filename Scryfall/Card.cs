using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Scryfall
{
    public class ImageUris
    {
        public string Small { get; set; }
        public string Normal { get; set; }
        public string Large { get; set; }
        public string Png { get; set; }
        [JsonProperty(PropertyName = "art_crop")]
        public string ArtCrop { get; set; }
        [JsonProperty(PropertyName = "border_crop")]
        public string BorderCrop { get; set; }
    }

    public class Legalities
    {
        public string Standard { get; set; }
        public string Future { get; set; }
        public string Frontier { get; set; }
        public string Modern { get; set; }
        public string Legacy { get; set; }
        public string Pauper { get; set; }
        public string Vintage { get; set; }
        public string Penny { get; set; }
        public string Commander { get; set; }
        [JsonProperty(PropertyName = "1v1")]
        public string OneVsOne { get; set; }
        public string Duel { get; set; }
        public string Brawl { get; set; }
    }

    public class RelatedUris
    {
        public string Gatherer { get; set; }
        [JsonProperty(PropertyName = "tcgplayer_decks")]
        public string TcgPlayerDecks { get; set; }
        public string Edhrec { get; set; }
        public string MtgTop8 { get; set; }
    }

    public class PurchaseUris
    {
        public string Amazon { get; set; }
        public string Ebay { get; set; }
        public string TcgPlayer { get; set; }
        public string MagicCardMarket { get; set; }
        public string CardHoarder { get; set; }
        [JsonProperty(PropertyName = "card_kingdom")]
        public string CardKingdom { get; set; }
        [JsonProperty(PropertyName = "mtgo_traders")]
        public string MtgoTraders { get; set; }
        public string CoolStuffInc { get; set; }
    }

    public class Card
    {
        [JsonProperty(PropertyName = "object")]
        public string ObjectType { get; set; }
        public string Id { get; set; }
        [JsonProperty(PropertyName = "oracle_id")]
        public string OracleId { get; set; }
        [JsonProperty(PropertyName = "multiverse_ids")]
        public List<int> MultiverseIds { get; set; }
        [JsonProperty(PropertyName = "mtgo_id")]
        public int MtgoId { get; set; }
        [JsonProperty(PropertyName = "mtgo_foil_id")]
        public int MtgoFoilId{ get; set; }
        public string Name { get; set; }
        public string Lang { get; set; }
        public string Uri { get; set; }
        [JsonProperty(PropertyName = "scryfall_uri")]
        public string ScryfallUri { get; set; }
        public string Layout { get; set; }
        [JsonProperty(PropertyName = "highres_image")]
        public bool HighresImage { get; set; }
        [JsonProperty(PropertyName = "image_uris")]
        public ImageUris ImageUris { get; set; }
        [JsonProperty(PropertyName = "mana_cost")]
        public string ManaCost { get; set; }
        public int Cmc { get; set; }
        [JsonProperty(PropertyName = "type_line")]
        public string TypeLine { get; set; }
        [JsonProperty(PropertyName = "oracle_text")]
        public string OracleText { get; set; }
        public List<object> colors { get; set; }
        [JsonProperty(PropertyName = "color_identity")]
        public List<object> ColorIdentity { get; set; }
        public Legalities Legalities { get; set; }
        public bool Reserved { get; set; }
        public bool Foil { get; set; }
        public bool Nonfoil { get; set; }
        public bool Oversized { get; set; }
        public bool Reprint { get; set; }
        public string Set { get; set; }
        [JsonProperty(PropertyName = "set_name")]
        public string OriginalSet { get; set; }
        [JsonProperty(PropertyName = "set_uri")]
        public string SetUri { get; set; }
        [JsonProperty(PropertyName = "set_search_uri")]
        public string SetSearchUri { get; set; }
        [JsonProperty(PropertyName = "scryfall_set_uri")]
        public string ScryfallSetUri { get; set; }
        [JsonProperty(PropertyName = "rulings_uri")]
        public string RulingsUri { get; set; }
        [JsonProperty(PropertyName = "prints_search_uri")]
        public string PrintsSearchUri { get; set; }
        [JsonProperty(PropertyName = "collector_number")]
        public string CollectorNumber { get; set; }
        public bool Digital { get; set; }
        public string Rarity { get; set; }
        [JsonProperty(PropertyName = "illustration_id")]
        public string IllustrationId { get; set; }
        public string Artist { get; set; }
        public string Frame { get; set; }
        [JsonProperty(PropertyName = "full_art")]
        public bool FullArt { get; set; }
        [JsonProperty(PropertyName = "border_color")]
        public string BorderColor { get; set; }
        public bool Timeshifted { get; set; }
        public bool Colorshifted { get; set; }
        public bool Futureshifted { get; set; }
        [JsonProperty(PropertyName = "edhrec_rank")]
        public int EdhrecRank { get; set; }
        public string Usd { get; set; }
        public string Tix { get; set; }
        public string Eur { get; set; }
        [JsonProperty(PropertyName = "related_uris")]
        public RelatedUris RelatedUris { get; set; }
        [JsonProperty(PropertyName = "purchase_uris")]
        public PurchaseUris PurchaseUris { get; set; }
    }
}
