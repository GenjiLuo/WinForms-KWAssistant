using KWAssistant.Data.Model;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json.Linq;

namespace KWAssistant.Util
{
    using dsl = Dictionary<string, List<string>>;

    class FileUtil
    {
        /// <summary>
        /// 读取关键词文件
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static List<Group> LoadKeywords(string path)
        {
            if (!File.Exists(path)) return new List<Group>();
            var dic = JsonConvert.DeserializeObject<dsl>(File.ReadAllText(path));
            var list = new List<Group>();
            foreach (var obj in dic)
            {
                var group = new Group { Name = obj.Key, Keywords = obj.Value };
                list.Add(group);
            }
            return list;
        }

        /// <summary>
        /// 读取黑/白名单
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static List<string> LoadList(string path)
        {
            if (!File.Exists(path)) return new List<string>();
            var words = JsonConvert.DeserializeObject<List<string>>(File.ReadAllText(path));
            var list = new List<string>();
            foreach (var word in words)
            {
                list.Add(word);
            }
            return list;
        }

        /// <summary>
        /// 读取设置文件
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static Setting LoadSetting(string path)
        {
            if (!File.Exists(path)) return new Setting();
            return JsonConvert.DeserializeObject<Setting>(File.ReadAllText(path));
        }

        /// <summary>
        /// 保存关键词到文件
        /// </summary>
        /// <param name="path"></param>
        /// <param name="groups"></param>
        public static void SaveKeywords(string path, List<Group> groups)
        {
            var dic = new dsl();
            foreach (var group in groups)
            {
                dic.Add(group.Name, group.Keywords);
            }
            File.WriteAllText(path, JObject.Parse(JsonConvert.SerializeObject(dic)).ToString());
        }

        /// <summary>
        /// 保存黑/白名单到文件
        /// </summary>
        /// <param name="path"></param>
        /// <param name="list"></param>
        public static void SaveList(string path, List<string> list)
        {
            File.WriteAllText(path, JArray.Parse(JsonConvert.SerializeObject(list)).ToString());
        }

        /// <summary>
        /// 保存设置文件
        /// </summary>
        /// <param name="path"></param>
        /// <param name="setting"></param>
        public static void SaveSetting(string path, Setting setting)
        {
            File.WriteAllText(path, JObject.Parse(JsonConvert.SerializeObject(setting)).ToString());
        }
    }
}
