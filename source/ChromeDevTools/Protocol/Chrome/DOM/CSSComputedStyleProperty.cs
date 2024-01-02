using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	[SupportedBy("Chrome")]
	public class CSSComputedStyleProperty
	{
		/// <summary>
		/// Gets or setsComputed style property name.

		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Gets or setsComputed style property value.

		/// </summary>
		public string Value { get; set; }
	}
}
