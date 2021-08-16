using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Ex01.Models
{
    public class CodaDocument
    {

        [JsonProperty("items")]
        public List<CodaDocument> CodaDocuments { get; set; }

        public CodaDocument codaDocument { get; set; }




        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("href")]
        public string Href { get; set; }


        [JsonProperty("createdAt")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public DateTime UpdatedAt { get; set; }

        [JsonProperty("icon")]
        public Icon Icon { get; set; }

        [JsonProperty("docSize")]
        public DocSize DocSize { get; set; }

        [JsonProperty("sourceDoc")]
        public SourceDoc SourceDoc { get; set; }

        [JsonProperty("workspaceId")]
        public string WorkspaceId { get; set; }

        [JsonProperty("folderId")]
        public string FolderId { get; set; }
    }
}