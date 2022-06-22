using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4.Data;
using TP4.Entities;

namespace TP4.Logic
{
    public class PokeLogic
    {
        public List<PokemonDTO> GetAll()
        {
            PokeQuery pokes = new PokeQuery();

            return pokes.GetPokes().Result;
        }
    }
}
