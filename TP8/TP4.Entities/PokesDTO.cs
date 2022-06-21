namespace TP4.Entities
{
    using Newtonsoft.Json;
    using System;

    public partial class PokesDTO
    {
        [JsonProperty("results")]
        public Result[] Results { get; set; }
    }

    public partial class Result
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }
    }
}