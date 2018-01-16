using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Pokemon
{
    /// <summary>
    /// 寶可夢的靴子
    /// </summary>
    public class PokemonBoots : Boots
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public PokemonBoots()
        {
            this.Name = "寶可夢";
        }
    }
}
