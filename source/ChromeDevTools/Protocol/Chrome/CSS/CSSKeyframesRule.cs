using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	///CSS keyframes rule representation.

	/// </summary>
	[SupportedBy("Chrome")]
	public class CSSKeyframesRule
	{
		/// <summary>
		/// Gets or setsAnimation name.

		/// </summary>
		public Value AnimationName { get; set; }
		/// <summary>
		/// Gets or setsList of keyframes.

		/// </summary>
		public CSSKeyframeRule[] Keyframes { get; set; }
	}
}
