using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Accessibility
{
	[SupportedBy("Chrome")]
	public class AXProperty
	{
		/// <summary>
		/// Gets or setsThe name of this property.

		/// </summary>
		public AXPropertyName Name { get; set; }
		/// <summary>
		/// Gets or setsThe value of this property.

		/// </summary>
		public AXValue Value { get; set; }
	}
}
