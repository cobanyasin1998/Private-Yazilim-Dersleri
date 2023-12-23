using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Method1
{
    public class EndPointBuilder
    {
        private readonly StringBuilder sbUrl = new StringBuilder();
        private readonly StringBuilder sbParams = new StringBuilder();

        private const char defaultDelimiter = '/';
        public string BaseUrl { get; set; }
        public EndPointBuilder(string baseUrl)
        {
            BaseUrl = baseUrl;
        }
        public EndPointBuilder Append(string value)
        {
            sbUrl.Append(value);
            sbUrl.Append(defaultDelimiter);
            return this;
        }
        public EndPointBuilder AppendParam(string name, string value)
        {
            sbParams.AppendFormat("{0}={1}", name, value);
            return this;
        }

        public string Build()
        {
            if (BaseUrl.EndsWith(defaultDelimiter))
                sbUrl.Insert(0, BaseUrl);
            else
                sbUrl.Insert(0,BaseUrl+defaultDelimiter);

            var url = sbUrl.ToString().TrimEnd('&');

            if (url.Length > 0)
            {
                string qParams = sbParams.ToString().TrimEnd('&');
                url = sbUrl.ToString().TrimEnd(defaultDelimiter).TrimEnd('?');

                url = $"{url}?{qParams}";

            }

            return url.TrimEnd(defaultDelimiter);
                
        }

    }
}
