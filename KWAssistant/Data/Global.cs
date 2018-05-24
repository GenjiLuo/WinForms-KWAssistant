using KWAssistant.Data.Model;
using System.Collections.Generic;
using KWAssistant.Helper;

namespace KWAssistant.Data
{
    class Global
    {
        public static List<Group> Groups { get; set; }  //关键词组

        public static List<Record> Tasks { get; set; }  //任务队列

        public static List<string> WhiteList { get; set; } //白名单

        public static List<string> BlackList { get; set; } //黑名单

        public static Setting Setting { get; set; } //设置

        static Global()
        {
            //从磁盘文件中读取数据
            Groups = FileHelper.LoadKeywords(Config.KeywordFilePath);
            Tasks = new List<Record>();
            WhiteList = FileHelper.LoadList(Config.WhiteListFilePath);
            BlackList = FileHelper.LoadList(Config.BlackListFilePath);
            Setting = FileHelper.LoadSetting(Config.SettingFilePath);
        }
    }
}
