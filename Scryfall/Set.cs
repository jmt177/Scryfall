using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Scryfall
{
    public class Set
    {
        [JsonProperty(PropertyName = "object")]
        public string ObjectType { get; set; }
        public string Code { get; set; }
        [JsonProperty(PropertyName = "mtgo_code")]
        public string MtgoCode { get; set; }
        public string Name { get; set; }
        public string Uri { get; set; }
        [JsonProperty(PropertyName = "scryfall_uri")]
        public string ScryfallUri { get; set; }
        [JsonProperty(PropertyName = "search_uri")]
        public string SearchUri { get; set; }
        [JsonProperty(PropertyName = "released_at")]
        public string ReleasedAt { get; set; }
        [JsonProperty(PropertyName = "set_type")]
        public string SetType { get; set; }
        [JsonProperty(PropertyName = "card_count")]
        public int CardCount { get; set; }
        public bool Digital { get; set; }
        [JsonProperty(PropertyName = "foil_only")]
        public bool FoilOnly { get; set; }
        [JsonProperty(PropertyName = "block_code")]
        public string BlockCode { get; set; }
        public string Block { get; set; }
        [JsonProperty(PropertyName = "icon_svg_uri")]
        public string IconSvgUri { get; set; }
    }
}
