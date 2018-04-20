namespace KWAssistant.Data.Model
{
    /// <summary>
    /// 设置类
    /// </summary>
    class Setting
    {
        /// <summary>
        /// 浏览起始页
        /// </summary>
        public int PageMin { get; set; } = 1;

        /// <summary>
        /// 浏览结束页
        /// </summary>
        public int PageMax { get; set; } = 3;

        /// <summary>
        /// 最小搜索停留时间
        /// </summary>
        public int SearchMin { get; set; } = 1;

        /// <summary>
        /// 最大搜索停留时间
        /// </summary>
        public int SearchMax { get; set; } = 3;

        /// <summary>
        /// 最小点击停留时间
        /// </summary>
        public int ClickMin { get; set; } = 5;

        /// <summary>
        /// 最大点击停留时间
        /// </summary>
        public int ClickMax { get; set; } = 10;

        /// <summary>
        /// 每个关键词最多耗时
        /// </summary>
        public int TimeSpent { get; set; } = 30;
    }
}
