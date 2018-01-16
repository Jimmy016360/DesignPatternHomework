namespace AbstractFactoryPattern
{
    /// <summary>
    /// 武器
    /// </summary>
    public abstract class Weapon
    {
        /// <summary>
        /// 武器名稱
        /// </summary>
        protected string Name { set; private get; }

        /// <summary>
        /// 拿武器
        /// </summary>
        /// <returns></returns>
        public string Take()
        {
            return $"拿著{Name}武器";
        }
    }
}