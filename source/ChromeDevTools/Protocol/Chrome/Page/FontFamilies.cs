using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	///Generic font families collection.

	/// </summary>
	[SupportedBy("Chrome")]
	public class FontFamilies
	{
		/// <summary>
		/// Gets or setsThe standard font-family.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Standard { get; set; }
		/// <summary>
		/// Gets or setsThe fixed font-family.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Fixed { get; set; }
		/// <summary>
		/// Gets or setsThe serif font-family.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Serif { get; set; }
		/// <summary>
		/// Gets or setsThe sansSerif font-family.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string SansSerif { get; set; }
		/// <summary>
		/// Gets or setsThe cursive font-family.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Cursive { get; set; }
		/// <summary>
		/// Gets or setsThe fantasy font-family.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Fantasy { get; set; }
		/// <summary>
		/// Gets or setsThe math font-family.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Math { get; set; }
	}
}
