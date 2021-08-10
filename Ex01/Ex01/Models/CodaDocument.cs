using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ex01.Models
{
    public class CodaDocument
    {

        //properties : id, name, type



        [JsonProperty(PropertyName = "id")]

        public String Id { get; set; }


        [JsonProperty(PropertyName = "name")]

        public String Name { get; set; }


        [JsonProperty(PropertyName = "type")]

        public String Type { get; set; }




    }
}
