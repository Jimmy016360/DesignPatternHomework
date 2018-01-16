namespace AbstractFactoryPattern
{
    /// <summary>
    /// 靴子
    /// </summary>
    public abstract class Boots
    {
        /// <summary>
        /// 靴子名稱
        /// </summary>
        protected string Name { set; private get; }

        /// <summary>
        /// 穿靴子
        /// </summary>
        /// <returns></returns>
        public string Wear()
        {
            return $"穿上{Name}靴子";
        }
    }
}