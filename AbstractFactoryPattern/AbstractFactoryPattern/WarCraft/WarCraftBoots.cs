using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.WarCraft
{
    /// <summary>
    /// 魔獸爭霸的靴子
    /// </summary>
    public class WarCraftBoots : Boots
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public WarCraftBoots()
        {
            this.Name = "魔獸爭霸";
        }
    }
}
