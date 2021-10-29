﻿using Newtonsoft.Json;

namespace SJP.Avro.Tools.Schema.Model
{
    public class FixedType : NamedSchema
    {
        [JsonProperty("type")]
        public string Type { get; } = "fixed";

        [JsonProperty("size")]
        public int Size { get; set; }
    }
}