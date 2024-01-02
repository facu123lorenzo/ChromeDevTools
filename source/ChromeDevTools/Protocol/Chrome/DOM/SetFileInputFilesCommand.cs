using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	///Sets files for the given file input element.

	/// </summary>
	[Command(ProtocolName.DOM.SetFileInputFiles)]
	[SupportedBy("Chrome")]
	public class SetFileInputFilesCommand: ICommand<SetFileInputFilesCommandResponse>
	{
		/// <summary>
		/// Gets or setsArray of file paths to set.

		/// </summary>
		public string[] Files { get; set; }
		/// <summary>
		/// Gets or setsIdentifier of the node.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? NodeId { get; set; }
		/// <summary>
		/// Gets or setsIdentifier of the backend node.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? BackendNodeId { get; set; }
		/// <summary>
		/// Gets or setsJavaScript object id of the node wrapper.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ObjectId { get; set; }
	}
}
