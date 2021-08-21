using System.Collections.Generic;
using Newtonsoft.Json;

namespace Ex01.Models
{
    public class Root
    {
        [JsonProperty("items")]
        public List<CodaDocument> CodaDocuments { get; set; }



        [JsonProperty("href")]
        public string Href { get; set; }
    }
}