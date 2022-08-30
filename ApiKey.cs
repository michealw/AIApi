using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIApi
{
    public class ApiKey : IApiKey
    {
        /// <summary>
        /// Sets the API key and hostname to pass to the request.
        /// </summary>
        /// <param name="key">RapidAPI endpoint key</param>
        /// <param name="host">RapidAPI endpoint hostname</param>
        public ApiKey(string key, string host)
        {
            Key = key;
            Host = host;
        }

        /// <summary>
        /// API key to pass to the endpoint.
        /// </summary>
        public string Key { get; set; }
        /// <summary>
        /// Host name to pass to the endpoint.
        /// </summary>
        public string Host { get; set; }
    }

    interface IApiKey
    {
        string Key { get; set; }
        string Host { get; set; }
    }
}
