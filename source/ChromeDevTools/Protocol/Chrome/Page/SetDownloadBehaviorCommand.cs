using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	///Set the behavior when downloading a file.

	/// </summary>
	[Obsolete]
	[Command(ProtocolName.Page.SetDownloadBehavior)]
	[SupportedBy("Chrome")]
	public class SetDownloadBehaviorCommand: ICommand<SetDownloadBehaviorCommandResponse>
	{
		/// <summary>
		/// Gets or setsWhether to allow all or deny all download requests, or use default Chrome behavior if
		/// available (otherwise deny).

		/// </summary>
		public string Behavior { get; set; }
		/// <summary>
		/// Gets or setsThe default path to save downloaded files to. This is required if behavior is set to 'allow'

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string DownloadPath { get; set; }
	}
}
