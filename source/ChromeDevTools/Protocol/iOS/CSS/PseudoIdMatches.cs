using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.CSS
{
	/// <summary>
	///CSS rule collection for a single pseudo style.

	/// </summary>
	[SupportedBy("iOS")]
	public class PseudoIdMatches
	{
		/// <summary>
		/// Gets or setsPseudo style identifier (see <code>enum PseudoId</code> in <code>RenderStyleConstants.h</code>).

		/// </summary>
		public long PseudoId { get; set; }
		/// <summary>
		/// Gets or setsMatches of CSS rules applicable to the pseudo style.

		/// </summary>
		public RuleMatch[] Matches { get; set; }
	}
}
