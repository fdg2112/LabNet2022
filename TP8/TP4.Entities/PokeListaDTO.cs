namespace TP4.Entities
{
    using Newtonsoft.Json;
    using System;

    public partial class PokeListaDTO
    {
        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("next")]
        public Uri Next { get; set; }

        [JsonProperty("previous")]
        public object Previous { get; set; }

        [JsonProperty("results")]
        public PokemonDTO[] Pokemones { get; set; }
    }
}