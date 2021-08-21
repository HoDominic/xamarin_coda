using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ex01.Models
{
    public class Document
    {
        [JsonProperty("id")]
        public String Id { get; set; }

        [JsonProperty("title")]
        public String Title { get; set; }


        [JsonProperty("name")]
        public String Name { get; set; }


        [JsonProperty("sourceDoc")]
        public String SourceDoc { get; set; }
    }
}
