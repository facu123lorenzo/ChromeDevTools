using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Console
{
	/// <summary>
	///Console message.

	/// </summary>
	[SupportedBy("Chrome")]
	public class ConsoleMessage
	{
		/// <summary>
		/// Gets or setsMessage source.

		/// </summary>
		public string Source { get; set; }
		/// <summary>
		/// Gets or setsMessage severity.

		/// </summary>
		public string Level { get; set; }
		/// <summary>
		/// Gets or setsMessage text.

		/// </summary>
		public string Text { get; set; }
		/// <summary>
		/// Gets or setsURL of the message origin.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Url { get; set; }
		/// <summary>
		/// Gets or setsLine number in the resource that generated this message (1-based).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? Line { get; set; }
		/// <summary>
		/// Gets or setsColumn number in the resource that generated this message (1-based).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? Column { get; set; }
	}
}
