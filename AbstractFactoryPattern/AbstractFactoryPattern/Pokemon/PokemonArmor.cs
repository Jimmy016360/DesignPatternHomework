using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Pokemon
{
    /// <summary>
    /// 寶可夢的盔甲
    /// </summary>
    public class PokemonArmor : Armor
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public PokemonArmor()
        {
            this.Name = "寶可夢";
        }
    }
}
