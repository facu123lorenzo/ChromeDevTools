using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Log
{
	/// <summary>
	///Log entry.

	/// </summary>
	[SupportedBy("Chrome")]
	public class LogEntry
	{
		/// <summary>
		/// Gets or setsLog entry source.

		/// </summary>
		public string Source { get; set; }
		/// <summary>
		/// Gets or setsLog entry severity.

		/// </summary>
		public string Level { get; set; }
		/// <summary>
		/// Gets or setsLogged text.

		/// </summary>
		public string Text { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Category { get; set; }
		/// <summary>
		/// Gets or setsTimestamp when this entry was added.

		/// </summary>
		public double Timestamp { get; set; }
		/// <summary>
		/// Gets or setsURL of the resource if known.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Url { get; set; }
		/// <summary>
		/// Gets or setsLine number in the resource.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? LineNumber { get; set; }
		/// <summary>
		/// Gets or setsJavaScript stack trace.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Runtime.StackTrace StackTrace { get; set; }
		/// <summary>
		/// Gets or setsIdentifier of the network request associated with this entry.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string NetworkRequestId { get; set; }
		/// <summary>
		/// Gets or setsIdentifier of the worker associated with this entry.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string WorkerId { get; set; }
		/// <summary>
		/// Gets or setsCall arguments.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Runtime.RemoteObject[] Args { get; set; }
	}
}
