using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Emulation
{
	/// <summary>
	///Used to specify User Agent Cient Hints to emulate. See https://wicg.github.io/ua-client-hints
	/// Missing optional values will be filled in by the target with what it would normally use.

	/// </summary>
	[SupportedBy("Chrome")]
	public class UserAgentMetadata
	{
		/// <summary>
		/// Gets or setsBrands appearing in Sec-CH-UA.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public UserAgentBrandVersion[] Brands { get; set; }
		/// <summary>
		/// Gets or setsBrands appearing in Sec-CH-UA-Full-Version-List.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public UserAgentBrandVersion[] FullVersionList { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string FullVersion { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string Platform { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string PlatformVersion { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string Architecture { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string Model { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public bool Mobile { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Bitness { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? Wow64 { get; set; }
	}
}
