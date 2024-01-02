using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	///Data for a simple selector (these are delimited by commas in a selector list).

	/// </summary>
	[SupportedBy("Chrome")]
	public class Value
	{
		/// <summary>
		/// Gets or setsValue text.

		/// </summary>
		public string Text { get; set; }
		/// <summary>
		/// Gets or setsValue range in the underlying resource (if available).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public SourceRange Range { get; set; }
		/// <summary>
		/// Gets or setsSpecificity of the selector.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Specificity Specificity { get; set; }
	}
}
