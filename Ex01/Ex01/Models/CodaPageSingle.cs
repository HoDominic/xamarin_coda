using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Ex01.Models
{
    public class CodaPageSingle
    {
        
        

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }


        [JsonProperty("subtitle")]
        public string Subtitle { get; set; } 
        
    }
}