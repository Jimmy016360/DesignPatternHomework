using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Pokemon
{
    /// <summary>
    /// 寶可夢的頭盔
    /// </summary>
    public class PokemonHelmet : Helmet
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public PokemonHelmet()
        {
            this.Name = "寶可夢";
        }
    }
}
