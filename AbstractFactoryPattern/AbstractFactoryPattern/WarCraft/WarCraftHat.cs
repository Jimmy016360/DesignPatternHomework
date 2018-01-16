using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.WarCraft
{
    /// <summary>
    /// 魔獸爭霸的帽子
    /// </summary>
    public class WarCraftHat : Hat
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public WarCraftHat()
        {
            this.Name = "魔獸爭霸";
        }
    }
}
