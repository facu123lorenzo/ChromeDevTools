using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	///Ad advertising element inside an interest group.

	/// </summary>
	[SupportedBy("Chrome")]
	public class InterestGroupAd
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string RenderURL { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Metadata { get; set; }
	}
}
