using System;
using System.Collections.Generic;
using System.Text;

namespace Spooky.Json20
{
    /// <summary>
	/// A named pipes transport for Json RPC requests, using an <see cref="System.IO.Pipes"/> to make requests.
	/// </summary>
    public class JsonRpcNamedPipesTransport : NamedPipesTransport
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JsonRpcNamedPipesTransport"/> class.
        /// </summary>
        /// <param name="namedPipesAddress"></param>
        public JsonRpcNamedPipesTransport(string namedPipesAddress) : base (namedPipesAddress)
        {
           
        }
    } // class
} // namespace
