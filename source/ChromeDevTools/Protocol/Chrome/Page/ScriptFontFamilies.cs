using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	///Font families collection for a script.

	/// </summary>
	[SupportedBy("Chrome")]
	public class ScriptFontFamilies
	{
		/// <summary>
		/// Gets or setsName of the script which these font families are defined for.

		/// </summary>
		public string Script { get; set; }
		/// <summary>
		/// Gets or setsGeneric font families collection for the script.

		/// </summary>
		public FontFamilies FontFamilies { get; set; }
	}
}
