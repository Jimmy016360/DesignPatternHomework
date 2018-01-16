using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.WarCraft
{
    /// <summary>
    /// 魔獸爭霸的頭盔
    /// </summary>
    public class WarCraftHelmet: Helmet
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public WarCraftHelmet()
        {
            this.Name = "魔獸爭霸";
        }
    }
}
