using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Tracing
{
	/// <summary>
	///Signals that tracing is stopped and there is no trace buffers pending flush, all data were
	/// delivered via dataCollected events.

	/// </summary>
	[Event(ProtocolName.Tracing.TracingComplete)]
	[SupportedBy("Chrome")]
	public class TracingCompleteEvent
	{
		/// <summary>
		/// Gets or setsIndicates whether some trace data is known to have been lost, e.g. because the trace ring
		/// buffer wrapped around.

		/// </summary>
		public bool DataLossOccurred { get; set; }
		/// <summary>
		/// Gets or setsA handle of the stream that holds resulting trace data.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Stream { get; set; }
		/// <summary>
		/// Gets or setsTrace data format of returned stream.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public StreamFormat TraceFormat { get; set; }
		/// <summary>
		/// Gets or setsCompression format of returned stream.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public StreamCompression StreamCompression { get; set; }
	}
}
