using Newtonsoft.Json;

namespace Ex01.Models
{
    public class Icon
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("browserLink")]
        public string BrowserLink { get; set; }
    }
}