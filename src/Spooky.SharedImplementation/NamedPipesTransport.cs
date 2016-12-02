using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Spooky
{
    /// <summary>
    /// An <see cref="IRpcTransport"/> implementation that uses <see cref="System.IO.Pipes"/> to transmit RPC messages.
    /// </summary>
    public class NamedPipesTransport : IRpcTransport
    {
        /// <summary>
        /// Creates a new <see cref="NamedPipesTransport"/> instance using the specified Named Pipes address.
        /// </summary>
        /// <param name="namedPipesAddress"></param>
        public NamedPipesTransport(string namedPipesAddress)
        {
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestContent"></param>
        /// <returns></returns>
        public Task<Stream> SendRequest(Stream requestContent)
        {
            
        }
    } // class
} // namespace
