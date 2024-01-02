using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CacheStorage
{
	/// <summary>
	///Fetches cache entry.

	/// </summary>
	[Command(ProtocolName.CacheStorage.RequestCachedResponse)]
	[SupportedBy("Chrome")]
	public class RequestCachedResponseCommand: ICommand<RequestCachedResponseCommandResponse>
	{
		/// <summary>
		/// Gets or setsId of cache that contains the entry.

		/// </summary>
		public string CacheId { get; set; }
		/// <summary>
		/// Gets or setsURL spec of the request.

		/// </summary>
		public string RequestURL { get; set; }
		/// <summary>
		/// Gets or setsheaders of the request.

		/// </summary>
		public Header[] RequestHeaders { get; set; }
	}
}
