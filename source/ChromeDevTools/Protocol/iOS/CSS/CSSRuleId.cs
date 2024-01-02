using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.CSS
{
	/// <summary>
	///This object identifies a CSS rule in a unique way.

	/// </summary>
	[SupportedBy("iOS")]
	public class CSSRuleId
	{
		/// <summary>
		/// Gets or setsEnclosing stylesheet identifier.

		/// </summary>
		public string StyleSheetId { get; set; }
		/// <summary>
		/// Gets or setsThe rule ordinal within the stylesheet.

		/// </summary>
		public long Ordinal { get; set; }
	}
}
