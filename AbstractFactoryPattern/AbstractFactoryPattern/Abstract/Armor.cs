namespace AbstractFactoryPattern
{
    /// <summary>
    /// 盔甲
    /// </summary>
    public class Armor
    {
        /// <summary>
        /// 盔甲名稱
        /// </summary>
        protected string Name { set; private get; }

        /// <summary>
        /// 穿盔甲
        /// </summary>
        /// <returns></returns>
        public string Wear()
        {
            return $"著{Name}盔甲";
        }
    }
}