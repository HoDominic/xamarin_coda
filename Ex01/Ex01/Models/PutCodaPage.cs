using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ex01.Models
{
    public class PutCodaPage
    {

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("subtitle")]
        public string Subtitle { get; set; }









    }
}
