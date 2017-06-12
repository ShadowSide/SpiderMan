using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Net;

namespace SpiderMan
{
    public class WebSpider: IDisposable
    {
        private WebSpiderTargets _targets;
        private WebClient _client;

        public WebSpider(WebSpiderTargets targets)
        {
            _targets = targets;
            _client = new WebClient();
        }

        public void Crowle(Uri uri)
        {
            _client;
            HttpWebRequest g;
            g.
        }

        public void Dispose()
        {
            _client.Dispose();
        }
    }
}
