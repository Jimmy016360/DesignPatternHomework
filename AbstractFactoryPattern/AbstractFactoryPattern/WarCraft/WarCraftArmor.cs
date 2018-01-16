using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.WarCraft
{
    /// <summary>
    /// 魔獸爭霸的盔甲
    /// </summary>
    public class WarCraftArmor : Armor
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public WarCraftArmor()
        {
            this.Name = "魔獸爭霸";
        }
    }
}
