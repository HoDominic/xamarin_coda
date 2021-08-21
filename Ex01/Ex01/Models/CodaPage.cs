using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ex01.Models
{
    public class CodaPage
    {

        [JsonProperty("items")]
        public List<CodaPage> CodaPages { get; set; }

     

        [JsonProperty("id")]
        public String Id { get; set; }

        [JsonProperty("name")]
        public String Name { get; set; }

        [JsonProperty("type")]
        public String Type { get; set; }


        [JsonProperty("subtitle")]
        public String Subtitle { get; set; }

        public CodaPage codaPage  {get; set; }
    }
}
