using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CacheStorage
{
	/// <summary>
	///Data entry.

	/// </summary>
	[SupportedBy("Chrome")]
	public class DataEntry
	{
		/// <summary>
		/// Gets or setsRequest URL.

		/// </summary>
		public string RequestURL { get; set; }
		/// <summary>
		/// Gets or setsRequest method.

		/// </summary>
		public string RequestMethod { get; set; }
		/// <summary>
		/// Gets or setsRequest headers

		/// </summary>
		public Header[] RequestHeaders { get; set; }
		/// <summary>
		/// Gets or setsNumber of seconds since epoch.

		/// </summary>
		public double ResponseTime { get; set; }
		/// <summary>
		/// Gets or setsHTTP response status code.

		/// </summary>
		public long ResponseStatus { get; set; }
		/// <summary>
		/// Gets or setsHTTP response status text.

		/// </summary>
		public string ResponseStatusText { get; set; }
		/// <summary>
		/// Gets or setsHTTP response type

		/// </summary>
		public CachedResponseType ResponseType { get; set; }
		/// <summary>
		/// Gets or setsResponse headers

		/// </summary>
		public Header[] ResponseHeaders { get; set; }
	}
}
