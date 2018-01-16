namespace AbstractFactoryPattern
{
    /// <summary>
    /// 帽子
    /// </summary>
    public abstract class Hat
    {
        /// <summary>
        /// 帽子名稱
        /// </summary>
        protected string Name { set; private get; }

        /// <summary>
        /// 戴帽子
        /// </summary>
        /// <returns></returns>
        public string Wear()
        {
            return $"戴上{Name}帽子";
        }
    }
}