using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    /// <summary>
    /// 商店
    /// </summary>
    public class CostumeShop
    {
        /// <summary>
        /// 帽子
        /// </summary>
        private readonly Hat Hat;

        /// <summary>
        /// 頭盔
        /// </summary>
        private readonly Helmet Helmet;

        /// <summary>
        /// 盔甲
        /// </summary>
        private readonly Armor Armor;

        /// <summary>
        /// 靴子
        /// </summary>
        private readonly Boots Boots;

        /// <summary>
        /// 武器
        /// </summary>
        private readonly Weapon Weapon;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="factory">Cosplay Costume 工廠</param>
        public CostumeShop(CosplayCostumeFactory factory)
        {
            this.Hat = factory.CreateHat();
            this.Helmet = factory.CreateHelmet();
            this.Armor = factory.CreateArmor();
            this.Boots = factory.CreateBoots();
            this.Weapon = factory.CreateWeapon();
        }

        /// <summary>
        /// 製造
        /// </summary>
        public void Build()
        {
            Console.WriteLine(this.Hat.Wear());
            Console.WriteLine(this.Helmet.Wear());
            Console.WriteLine(this.Armor.Wear());
            Console.WriteLine(this.Boots.Wear());
            Console.WriteLine(this.Weapon.Take());
        }
    }
}
