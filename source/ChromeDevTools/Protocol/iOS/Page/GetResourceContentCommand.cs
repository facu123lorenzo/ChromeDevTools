using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Page
{
	/// <summary>
	///Returns content of the given resource.

	/// </summary>
	[Command(ProtocolName.Page.GetResourceContent)]
	[SupportedBy("iOS")]
	public class GetResourceContentCommand: ICommand<GetResourceContentCommandResponse>
	{
		/// <summary>
		/// Gets or setsFrame id to get resource for.

		/// </summary>
		public string FrameId { get; set; }
		/// <summary>
		/// Gets or setsURL of the resource to get content for.

		/// </summary>
		public string Url { get; set; }
	}
}
