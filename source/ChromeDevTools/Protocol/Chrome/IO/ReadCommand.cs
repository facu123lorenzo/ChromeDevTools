using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.IO
{
	/// <summary>
	///Read a chunk of the stream

	/// </summary>
	[Command(ProtocolName.IO.Read)]
	[SupportedBy("Chrome")]
	public class ReadCommand: ICommand<ReadCommandResponse>
	{
		/// <summary>
		/// Gets or setsHandle of the stream to read.

		/// </summary>
		public string Handle { get; set; }
		/// <summary>
		/// Gets or setsSeek to the specified offset before reading (if not specificed, proceed with offset
		/// following the last read). Some types of streams may only support sequential reads.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? Offset { get; set; }
		/// <summary>
		/// Gets or setsMaximum number of bytes to read (left upon the agent discretion if not specified).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? Size { get; set; }
	}
}
