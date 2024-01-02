using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	///CSS try rule representation.

	/// </summary>
	[SupportedBy("Chrome")]
	public class CSSTryRule
	{
		/// <summary>
		/// Gets or setsThe css style sheet identifier (absent for user agent stylesheet and user-specified
		/// stylesheet rules) this rule came from.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string StyleSheetId { get; set; }
		/// <summary>
		/// Gets or setsParent stylesheet's origin.

		/// </summary>
		public StyleSheetOrigin Origin { get; set; }
		/// <summary>
		/// Gets or setsAssociated style declaration.

		/// </summary>
		public CSSStyle Style { get; set; }
	}
}
