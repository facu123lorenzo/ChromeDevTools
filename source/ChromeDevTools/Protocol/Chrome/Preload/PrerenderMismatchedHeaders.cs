using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Preload
{
	/// <summary>
	///Information of headers to be displayed when the header mismatch occurred.

	/// </summary>
	[SupportedBy("Chrome")]
	public class PrerenderMismatchedHeaders
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string HeaderName { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string InitialValue { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ActivationValue { get; set; }
	}
}
