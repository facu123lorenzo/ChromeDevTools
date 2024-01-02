using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Runtime
{
	/// <summary>
	///Issued when object should be inspected (for example, as a result of inspect() command line API
	/// call).

	/// </summary>
	[Event(ProtocolName.Runtime.InspectRequested)]
	[SupportedBy("Chrome")]
	public class InspectRequestedEvent
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public RemoteObject Object { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public object Hints { get; set; }
		/// <summary>
		/// Gets or setsIdentifier of the context where the call was made.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? ExecutionContextId { get; set; }
	}
}
