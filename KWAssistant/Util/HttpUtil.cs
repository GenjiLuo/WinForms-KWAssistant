using AngleSharp.Parser.Html;
using KWAssistant.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace KWAssistant.Util
{
    static class HttpUtil
    {
        private static readonly HtmlParser Parser;

        static HttpUtil()
        {
            Parser = new HtmlParser();
        }

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

        /// <summary>
        /// 分析关键词搜索页面
        /// </summary>
        /// <param name="html">页面源码</param>
        /// <returns>搜索结果集合</returns>
        public static IEnumerable<SearchResult> Analyze(this string html)
        {
            var document = Parser.Parse(html);
            var cells = document.QuerySelectorAll("#content_left div.c-container"); //取得搜索结果列表
            var i = 0;
            return from cell in cells
                   let head = cell.QuerySelector("h3 a")
                   select new SearchResult
                   {
                       Id = i++,
                       Title = head.TextContent, //标题
                       Link = head.GetAttribute("href"), //百度重定向地址，link?url=
                       PartOfRealUri = cell.QuerySelector(".c-showurl")?.TextContent
                                       ?? cell.QuerySelector(".g").TextContent //不完整的真实地址
                   };
        }
    }
}
