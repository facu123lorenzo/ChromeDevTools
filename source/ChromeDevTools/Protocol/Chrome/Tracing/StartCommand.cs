using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Tracing
{
	/// <summary>
	///Start trace events collection.

	/// </summary>
	[Command(ProtocolName.Tracing.Start)]
	[SupportedBy("Chrome")]
	public class StartCommand: ICommand<StartCommandResponse>
	{
		/// <summary>
		/// Gets or setsCategory/tag filter

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Categories { get; set; }
		/// <summary>
		/// Gets or setsTracing options

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Options { get; set; }
		/// <summary>
		/// Gets or setsIf set, the agent will issue bufferUsage events at this interval, specified in milliseconds

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double BufferUsageReportingInterval { get; set; }
		/// <summary>
		/// Gets or setsWhether to report trace events as series of dataCollected events or to save trace to a
		/// stream (defaults to `ReportEvents`).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string TransferMode { get; set; }
		/// <summary>
		/// Gets or setsTrace data format to use. This only applies when using `ReturnAsStream`
		/// transfer mode (defaults to `json`).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string StreamFormat { get; set; }
		/// <summary>
		/// Gets or setsCompression format to use. This only applies when using `ReturnAsStream`
		/// transfer mode (defaults to `none`)

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string StreamCompression { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public TraceConfig TraceConfig { get; set; }
		/// <summary>
		/// Gets or setsBase64-encoded serialized perfetto.protos.TraceConfig protobuf message
		/// When specified, the parameters `categories`, `options`, `traceConfig`
		/// are ignored. (Encoded as a base64 string when passed over JSON)

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string PerfettoConfig { get; set; }
		/// <summary>
		/// Gets or setsBackend type (defaults to `auto`)

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string TracingBackend { get; set; }
	}
}
