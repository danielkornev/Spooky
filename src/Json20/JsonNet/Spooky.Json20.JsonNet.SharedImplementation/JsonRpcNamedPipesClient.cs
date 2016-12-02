using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Spooky.Json20
{
    /// <summary>
	/// An <see cref="IRpcClient"/> implementation for making Json RPC 2.0 calls.
	/// </summary>
	public class JsonRpcNamedPipesClient : RpcClient
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Spooky.Json20.JsonRpcNamedPipesClient"/> class.
        /// </summary>
        /// <param name="namedPipesAddress">The named pipes of the JSON RPC service address this client accesses.</param>
        public JsonRpcNamedPipesClient(string namedPipesAddress)
            : base
            (
                new RpcClientOptions()
                {
                    Serializer = new JsonRpcSerializer(),
                    Transport = new JsonRpcNamedPipesTransport(namedPipesAddress)
                }
            )
        {
        }
    } // class
} // namespace
