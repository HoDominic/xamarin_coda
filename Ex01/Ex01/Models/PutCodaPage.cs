using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ex01.Models
{
    public class PutCodaPage
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("subtitle")]
        public string Subtitle { get; set; }









    }
}
