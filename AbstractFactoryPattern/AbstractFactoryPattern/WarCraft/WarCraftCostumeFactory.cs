using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryPattern.Pokemon;

namespace AbstractFactoryPattern.WarCraft
{
    /// <summary>
    /// 魔獸爭霸 Cosplay Costume 工廠
    /// </summary>
    public class WarCraftCostumeFactory : CosplayCostumeFactory
    {
        /// <summary>
        /// 生產帽子
        /// </summary>
        /// <returns>帽子</returns>
        public override Hat CreateHat()
        {
            return new WarCraftHat();
        }

        /// <summary>
        /// 生產頭盔
        /// </summary>
        /// <returns>頭盔</returns>
        public override Helmet CreateHelmet()
        {
            return new WarCraftHelmet();
        }

        /// <summary>
        /// 生產盔甲
        /// </summary>
        /// <returns>盔甲</returns>
        public override Armor CreateArmor()
        {
            return new WarCraftArmor();
        }

        /// <summary>
        /// 生產靴子
        /// </summary>
        /// <returns>靴子</returns>
        public override Boots CreateBoots()
        {
            return new WarCraftBoots();
        }

        /// <summary>
        /// 生產武器
        /// </summary>
        /// <returns>武器</returns>
        public override Weapon CreateWeapon()
        {
            return new WarCraftWeapon();
        }
    }
}
