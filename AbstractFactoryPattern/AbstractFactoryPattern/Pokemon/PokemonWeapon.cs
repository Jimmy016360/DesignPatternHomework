using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Pokemon
{
    /// <summary>
    /// 寶可夢的武器
    /// </summary>
    public class PokemonWeapon : Weapon
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public PokemonWeapon()
        {
            this.Name = "寶可夢";
        }
    }
}
