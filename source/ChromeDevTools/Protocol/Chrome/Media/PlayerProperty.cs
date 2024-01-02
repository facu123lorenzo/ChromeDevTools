using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Media
{
	/// <summary>
	///Corresponds to kMediaPropertyChange

	/// </summary>
	[SupportedBy("Chrome")]
	public class PlayerProperty
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string Value { get; set; }
	}
}
