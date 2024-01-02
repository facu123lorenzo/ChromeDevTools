using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	[SupportedBy("Chrome")]
	public class ShorthandEntry
	{
		/// <summary>
		/// Gets or setsShorthand name.

		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Gets or setsShorthand value.

		/// </summary>
		public string Value { get; set; }
		/// <summary>
		/// Gets or setsWhether the property has "!important" annotation (implies `false` if absent).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? Important { get; set; }
	}
}
