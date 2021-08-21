using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ex01.Models
{
    public class Categories
    {

        [JsonProperty("items")]
        public List<Categories> CodaCategories { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

    }
}
