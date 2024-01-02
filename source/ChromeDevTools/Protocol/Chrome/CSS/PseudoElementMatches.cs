using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	///CSS rule collection for a single pseudo style.

	/// </summary>
	[SupportedBy("Chrome")]
	public class PseudoElementMatches
	{
		/// <summary>
		/// Gets or setsPseudo element type.

		/// </summary>
		public DOM.PseudoType PseudoType { get; set; }
		/// <summary>
		/// Gets or setsPseudo element custom ident.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string PseudoIdentifier { get; set; }
		/// <summary>
		/// Gets or setsMatches of CSS rules applicable to the pseudo style.

		/// </summary>
		public RuleMatch[] Matches { get; set; }
	}
}
