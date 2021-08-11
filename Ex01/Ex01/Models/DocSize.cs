using Newtonsoft.Json;

namespace Ex01.Models
{
    public class DocSize
    {
        [JsonProperty("totalRowCount")]
        public int TotalRowCount { get; set; }

        [JsonProperty("tableAndViewCount")]
        public int TableAndViewCount { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("overApiSizeLimit")]
        public bool OverApiSizeLimit { get; set; }
    }
}