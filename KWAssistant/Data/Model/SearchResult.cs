namespace KWAssistant.Data.Model
{
    /// <summary>
    /// 搜索关键词的结果项
    /// </summary>
    class SearchResult
    {
        /// <summary>
        /// 从零开始的序号
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 百度重定向链接
        /// </summary>
        public string Link { get; set; }

        /// <summary>
        /// 不完整的真实地址
        /// </summary>
        public string PartOfRealUri { get; set; }

        /// <summary>
        /// 标记广告
        /// </summary>
        public bool IsAdv { get; set; }
    }
}
