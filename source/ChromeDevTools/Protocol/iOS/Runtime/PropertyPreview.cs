using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Runtime
{
	[SupportedBy("iOS")]
	public class PropertyPreview
	{
		/// <summary>
		/// Gets or setsProperty name.

		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Gets or setsObject type.

		/// </summary>
		public string Type { get; set; }
		/// <summary>
		/// Gets or setsObject subtype hint. Specified for <code>object</code> type values only.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Subtype { get; set; }
		/// <summary>
		/// Gets or setsUser-friendly property value string.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Value { get; set; }
		/// <summary>
		/// Gets or setsNested value preview.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public ObjectPreview ValuePreview { get; set; }
		/// <summary>
		/// Gets or setsTrue if this is an internal property.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? Internal { get; set; }
	}
}
