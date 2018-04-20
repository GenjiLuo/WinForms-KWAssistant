using System;

namespace KWAssistant.Data.Model
{
    class Config
    {
        public static readonly string KeywordFilePath = AppDomain.CurrentDomain.BaseDirectory + "keyword.json";

        public static readonly string WhiteListFilePath = AppDomain.CurrentDomain.BaseDirectory + "whitelist.json";

        public static readonly string BlackListFilePath = AppDomain.CurrentDomain.BaseDirectory + "blacklist.json";
    }
}
