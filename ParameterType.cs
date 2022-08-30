using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIApi
{
    /// <summary>
    /// Airport search types.
    /// </summary>
    public enum ParameterType
    {
        /// <summary>
        /// Three-letter airport code provided by the 
        /// International Air Transport Association.
        /// </summary>
        Iata,
        /// <summary>
        /// Four-letter airport code provided by the
        /// International Civil Aviation Organization.
        /// </summary>
        Icao
    }
}
