using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.WarCraft
{
    /// <summary>
    /// 魔獸爭霸的武器
    /// </summary>
    public class WarCraftWeapon : Weapon
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public WarCraftWeapon()
        {
            this.Name = "魔獸爭霸";
        }
    }
}
