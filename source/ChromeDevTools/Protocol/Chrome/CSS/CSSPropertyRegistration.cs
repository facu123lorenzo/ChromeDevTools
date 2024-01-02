using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	///Representation of a custom property registration through CSS.registerProperty

	/// </summary>
	[SupportedBy("Chrome")]
	public class CSSPropertyRegistration
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string PropertyName { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Value InitialValue { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public bool Inherits { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string Syntax { get; set; }
	}
}
