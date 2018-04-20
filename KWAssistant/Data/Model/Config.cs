using System;

namespace KWAssistant.Data.Model
{
    /// <summary>
    /// 数据文件存放路径类
    /// </summary>
    class Config
    {
        public static readonly string KeywordFilePath = AppDomain.CurrentDomain.BaseDirectory + "keyword.json";

        public static readonly string WhiteListFilePath = AppDomain.CurrentDomain.BaseDirectory + "whitelist.json";

        public static readonly string BlackListFilePath = AppDomain.CurrentDomain.BaseDirectory + "blacklist.json";

        public static readonly string SettingFilePath = AppDomain.CurrentDomain.BaseDirectory + "setting.json";
    }
}
