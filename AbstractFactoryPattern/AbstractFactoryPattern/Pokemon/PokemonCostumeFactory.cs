using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Pokemon
{
    /// <summary>
    /// 寶可夢 Cosplay Costume 工廠
    /// </summary>
    public class PokemonCostumeFactory : CosplayCostumeFactory
    {
        /// <summary>
        /// 生產帽子
        /// </summary>
        /// <returns>帽子</returns>
        public override Hat CreateHat()
        {
            return new PokemonHat();
        }

        /// <summary>
        /// 生產頭盔
        /// </summary>
        /// <returns>頭盔</returns>
        public override Helmet CreateHelmet()
        {
            return new PokemonHelmet();
        }

        /// <summary>
        /// 生產盔甲
        /// </summary>
        /// <returns>盔甲</returns>
        public override Armor CreateArmor()
        {
            return new PokemonArmor();
        }

        /// <summary>
        /// 生產靴子
        /// </summary>
        /// <returns>靴子</returns>
        public override Boots CreateBoots()
        {
            return new PokemonBoots();
        }

        /// <summary>
        /// 生產武器
        /// </summary>
        /// <returns>武器</returns>
        public override Weapon CreateWeapon()
        {
            return new PokemonWeapon();
        }
    }
}
