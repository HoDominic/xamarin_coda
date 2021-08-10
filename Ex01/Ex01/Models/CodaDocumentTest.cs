using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Ex01.Models
{
    public class CodaDocumentTest
    {


        public class Rootobject
        {
            [JsonProperty("items")]
            public Item[] items { get; set; }

            [JsonProperty("href")]
            public string href { get; set; }
        }

        public class Item
        {
            [JsonProperty("id")]
            public string id { get; set; }

            [JsonProperty("type")]
            public string type { get; set; }

            [JsonProperty("href")]
            public string href { get; set; }

            [JsonProperty("browserLink")]
            public string browserLink { get; set; }

            [JsonProperty("name")]
            public string name { get; set; }

            [JsonProperty("owner")]
            public string owner { get; set; }

            [JsonProperty("ownerName")]
            public string ownerName { get; set; }

            [JsonProperty("createdAt")]
            public DateTime createdAt { get; set; }

            [JsonProperty("updatedAt")]
            public DateTime updatedAt { get; set; }


            [JsonProperty("icon")]
            public Icon icon { get; set; }


            [JsonProperty("docSize")]
           
            public Docsize docSize { get; set; }

            [JsonProperty("sourceDoc")]
            public Sourcedoc sourceDoc { get; set; }

            [JsonProperty("workspaceId")]
            public string workspaceId { get; set; }

            [JsonProperty("folderId")]
            public string folderId { get; set; }
        }

        public class Icon
        {
            public string name { get; set; }
            public string type { get; set; }
            public string browserLink { get; set; }
        }

        public class Docsize
        {
            public int totalRowCount { get; set; }
            public int tableAndViewCount { get; set; }
            public int pageCount { get; set; }
            public bool overApiSizeLimit { get; set; }
        }

        public class Sourcedoc
        {
            public string id { get; set; }
            public string type { get; set; }
            public string href { get; set; }
            public string browserLink { get; set; }
        }


    }
}



