using System;
using System.Net.Http;

namespace KWAssistant.Util
{
    static class HttpUtil
    {
        /// <summary>
        /// 添加常见的Headers
        /// </summary>
        /// <param name="client"></param>
        public static void CreateHeaders(this HttpClient client)
        {
            client.DefaultRequestHeaders.Add("User-Agent",
                "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/66.0.3359.170 Safari/537.36");
            client.DefaultRequestHeaders.Add("Accept",
                "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8");
            client.DefaultRequestHeaders.Add("Accept-Language", "zh-CN,zh;q=0.9");
        }

        /// <summary>
        /// 设置请求头中的Referer
        /// </summary>
        /// <param name="client"></param>
        /// <param name="referer"></param>
        public static void SetReferer(this HttpClient client, Uri referer)
        {
            client.DefaultRequestHeaders.Referrer = referer;
        }

        /// <summary>
        /// 清除请求头中的Referer
        /// </summary>
        /// <param name="client"></param>
        public static void ClearReferer(this HttpClient client)
        {
            client.DefaultRequestHeaders.Referrer = null;
        }
    }
}
