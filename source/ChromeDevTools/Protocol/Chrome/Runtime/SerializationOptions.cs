using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Runtime
{
	/// <summary>
	///Represents options for serialization. Overrides `generatePreview` and `returnByValue`.

	/// </summary>
	[SupportedBy("Chrome")]
	public class SerializationOptions
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string Serialization { get; set; }
		/// <summary>
		/// Gets or setsDeep serialization depth. Default is full depth. Respected only in `deep` serialization mode.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? MaxDepth { get; set; }
		/// <summary>
		/// Gets or setsEmbedder-specific parameters. For example if connected to V8 in Chrome these control DOM
		/// serialization via `maxNodeDepth: integer` and `includeShadowTree: "none" | "open" | "all"`.
		/// Values can be only of type string or integer.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public object AdditionalParameters { get; set; }
	}
}
