using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Console
{
	/// <summary>
	///Console message.

	/// </summary>
	[SupportedBy("iOS")]
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
		/// Gets or setsConsole message type.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Type { get; set; }
		/// <summary>
		/// Gets or setsURL of the message origin.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Url { get; set; }
		/// <summary>
		/// Gets or setsLine number in the resource that generated this message.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? Line { get; set; }
		/// <summary>
		/// Gets or setsColumn number on the line in the resource that generated this message.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? Column { get; set; }
		/// <summary>
		/// Gets or setsRepeat count for repeated messages.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? RepeatCount { get; set; }
		/// <summary>
		/// Gets or setsMessage parameters in case of the formatted message.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Runtime.RemoteObject[] Parameters { get; set; }
		/// <summary>
		/// Gets or setsJavaScript stack trace for assertions and error messages.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public CallFrame[] StackTrace { get; set; }
		/// <summary>
		/// Gets or setsIdentifier of the network request associated with this message.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string NetworkRequestId { get; set; }
	}
}
