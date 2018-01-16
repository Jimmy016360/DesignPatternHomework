using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Pokemon
{
    /// <summary>
    /// 寶可夢的帽子
    /// </summary>
    public class PokemonHat : Hat
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public PokemonHat()
        {
            this.Name = "寶可夢";
        }
    }
}
