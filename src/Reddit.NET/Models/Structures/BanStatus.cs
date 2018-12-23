﻿using Newtonsoft.Json;
using Reddit.NET.Models.Converters;
using System;

namespace Reddit.NET.Models.Structures
{
    [Serializable]
    public class BanStatus
    {
        [JsonProperty("endDate")]
        [JsonConverter(typeof(TimestampConvert))]
        public DateTime EndDate;

        [JsonProperty("reason")]
        public string Reason;

        [JsonProperty("isBanned")]
        public bool IsBanned;

        [JsonProperty("isPermanent")]
        public bool IsPermanent;
    }
}
