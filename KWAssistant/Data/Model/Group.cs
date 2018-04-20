using System.Collections.Generic;

namespace KWAssistant.Data.Model
{
    /// <summary>
    /// 关键词组
    /// </summary>
    public class Group
    {
        public string Name { get; set; }

        public List<string> Keywords { get; set; }
    }
}
