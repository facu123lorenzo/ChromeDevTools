using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOMSnapshot
{
	/// <summary>
	///A name/value pair.

	/// </summary>
	[SupportedBy("Chrome")]
	public class NameValue
	{
		/// <summary>
		/// Gets or setsAttribute/property name.

		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Gets or setsAttribute/property value.

		/// </summary>
		public string Value { get; set; }
	}
}
