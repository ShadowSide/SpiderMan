using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiderMan
{
    public class WebSpiderTargets
    {
        private Uri[] _baseUri;

        public WebSpiderTargets(Uri[] baseUri)
        {
            _baseUri = baseUri
        }

        public Uri[] BaseUri {get { return _baseUri; } }
    }
}
