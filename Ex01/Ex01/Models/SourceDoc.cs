using Newtonsoft.Json;

namespace Ex01.Models
{
    public class SourceDoc
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("browserLink")]
        public string BrowserLink { get; set; }
    }
}