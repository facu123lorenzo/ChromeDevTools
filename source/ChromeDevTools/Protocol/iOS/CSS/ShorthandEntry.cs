using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.CSS
{
	[SupportedBy("iOS")]
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
	}
}
