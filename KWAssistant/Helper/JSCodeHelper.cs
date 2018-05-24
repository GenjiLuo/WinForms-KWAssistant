namespace KWAssistant.Helper
{
    class JsCodeHelper
    {
        public const string ResultLinkSelector = @"#content_left div.c-container h3 a";

        public const string ResultDivSelector = @"#content_left div.c-container";

        public const string AdvDivSelector = @"#content_left div[id][style=""display:block !important;visibility:visible !important""]";

        public string Search(string keyword)
        {
            return $@"document.getElementById('kw').value = '{keyword}';" +
                   @"document.getElementById('su').click();";
        }

        public string InitObject()
        {
            return $@"var myResults = document.querySelectorAll('{ResultLinkSelector}');" +
                   $@"var myAdvs = []; var myTemp = document.querySelectorAll('{AdvDivSelector}');" +
                   @"myTemp.forEach(e => myAdvs.push(e.querySelector('a')));" +
                   @"var myEvent = document.createEvent('HTMLEvents');" +
                   @"myEvent.initEvent('mousedown', true, true);";
        }

        public string ClickResult(int index)
        {
            return $@"myResults[{index}].dispatchEvent(myEvent);myResults[{index}].click();";
        }

        public string ClickAdv(int index)
        {
            return $@"myAdvs[{index}].dispatchEvent(myEvent);myAdvs[{index}].click();";
        }

        public string NextPage()
        {
            return @"var myPages = document.querySelectorAll('#page a');" +
                   @"myPages[myPages.length - 1].click();";
        }
    }
}
