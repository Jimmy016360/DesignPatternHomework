using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    /// <summary>
    /// Cosplay Costume 抽象工廠
    /// </summary>
    public abstract class CosplayCostumeFactory
    {
        /// <summary>
        /// 生產帽子
        /// </summary>
        /// <returns>帽子</returns>
        public abstract Hat CreateHat();

        /// <summary>
        /// 生產頭盔
        /// </summary>
        /// <returns>頭盔</returns>
        public abstract Helmet CreateHelmet();

        /// <summary>
        /// 生產盔甲
        /// </summary>
        /// <returns>盔甲</returns>
        public abstract Armor CreateArmor();

        /// <summary>
        /// 生產靴子
        /// </summary>
        /// <returns>靴子</returns>
        public abstract Boots CreateBoots();

        /// <summary>
        /// 生產武器
        /// </summary>
        /// <returns>武器</returns>
        public abstract Weapon CreateWeapon();
    }
}
