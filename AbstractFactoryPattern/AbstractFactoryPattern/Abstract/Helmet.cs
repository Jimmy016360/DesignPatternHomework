namespace AbstractFactoryPattern
{
    /// <summary>
    /// 頭盔
    /// </summary>
    public abstract class Helmet
    {
        /// <summary>
        /// 頭盔名稱
        /// </summary>
        protected string Name { set; private get; }

        /// <summary>
        /// 戴頭盔
        /// </summary>
        /// <returns></returns>
        public string Wear()
        {
            return $"戴上{Name}頭盔";
        }
    }
}