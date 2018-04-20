using KWAssistant.Data.Model;
using KWAssistant.Util;
using System.Collections.Generic;

namespace KWAssistant.Data
{
    class Global
    {
        public static List<Group> Groups { get; set; }  //关键词组

        public static List<Record> Tasks { get; set; }  //任务队列

        public static List<string> WhiteList { get; set; } //白名单

        public static List<string> BlackList { get; set; } //黑名单

        static Global()
        {
            //从磁盘文件中读取数据
            Groups = FileUtil.LoadKeywords(Config.KeywordFilePath);
            Tasks = new List<Record>();
            WhiteList = FileUtil.LoadList(Config.WhiteListFilePath);
            BlackList = FileUtil.LoadList(Config.BlackListFilePath);
        }
    }
}
