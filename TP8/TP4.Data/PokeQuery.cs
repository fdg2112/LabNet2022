using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TP4.Entities;

namespace TP4.Data
{
    public class PokeQuery
    {
        public async Task<PokesDTO> GetPokes()
        {
            HttpClient client = new HttpClient();
            var json = await client.GetStringAsync("https://pokeapi.co/api/v2/pokemon/");
            var pokes = JsonConvert.DeserializeObject<PokesDTO>(json);
            return pokes;
        }

    }
}
