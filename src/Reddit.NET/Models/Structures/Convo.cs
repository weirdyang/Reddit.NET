﻿using Newtonsoft.Json;
using Reddit.NET.Models.Converters;
using System;

namespace Reddit.NET.Models.Structures
{
    [Serializable]
    public class Convo
    {
        [JsonProperty("date")]
        [JsonConverter(typeof(TimestampConvert))]
        public DateTime Date;

        [JsonProperty("permalink")]
        public string Permalink;

        [JsonProperty("id")]
        public string Id;

        [JsonProperty("subject")]
        public string Subject;
    }
}
