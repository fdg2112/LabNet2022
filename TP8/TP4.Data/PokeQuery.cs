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
        public async Task<List<PokemonDTO>> GetPokes()
        {
            try
            {
                HttpClient client = new HttpClient();
                var response = client.GetAsync("https://pokeapi.co/api/v2/pokemon/").Result;
                var pokes = JsonConvert.DeserializeObject<PokeListaDTO>(await response.Content.ReadAsStringAsync());
                var pokeList = pokes.Pokemones.Select(p => new PokemonDTO
                {
                    Name = p.Name,
                    Url = p.Url
                }).ToList();
                return pokeList;
            }
            catch (Exception e)
            {
                throw e;
            }

        }
    }
}
