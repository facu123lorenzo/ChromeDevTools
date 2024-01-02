using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	///CSS position-fallback rule representation.

	/// </summary>
	[SupportedBy("Chrome")]
	public class CSSPositionFallbackRule
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public Value Name { get; set; }
		/// <summary>
		/// Gets or setsList of keyframes.

		/// </summary>
		public CSSTryRule[] TryRules { get; set; }
	}
}
