using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ex01.Models
{
    public class Account
    {
        [JsonProperty("Name")]
        public string Name { get; set; }


        [JsonProperty("loginId")]
        public string LoginId { get; set; }



        [JsonProperty("type")]
        public string Type { get; set; }

    }
}
