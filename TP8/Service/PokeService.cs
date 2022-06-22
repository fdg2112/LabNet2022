using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4.Data;
using TP4.Entities;
using TP4.Logic;

namespace Service
{
    public class PokeService 
    {
        PokeLogic pokeLogic = new PokeLogic();
        public List<PokemonDTO> GetPokemones()
        {
            try
            {
                return pokeLogic.GetAll();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
