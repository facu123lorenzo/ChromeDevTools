using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.HeapProfiler
{
	[Command(ProtocolName.HeapProfiler.TakeHeapSnapshot)]
	[SupportedBy("Chrome")]
	public class TakeHeapSnapshotCommand: ICommand<TakeHeapSnapshotCommandResponse>
	{
		/// <summary>
		/// Gets or setsIf true 'reportHeapSnapshotProgress' events will be generated while snapshot is being taken.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? ReportProgress { get; set; }
		/// <summary>
		/// Gets or setsIf true, a raw snapshot without artificial roots will be generated.
		/// Deprecated in favor of `exposeInternals`.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? TreatGlobalObjectsAsRoots { get; set; }
		/// <summary>
		/// Gets or setsIf true, numerical values are included in the snapshot

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? CaptureNumericValue { get; set; }
		/// <summary>
		/// Gets or setsIf true, exposes internals of the snapshot.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? ExposeInternals { get; set; }
	}
}
