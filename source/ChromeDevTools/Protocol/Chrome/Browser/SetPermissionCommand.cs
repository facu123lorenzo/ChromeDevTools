using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Browser
{
	/// <summary>
	///Set permission settings for given origin.

	/// </summary>
	[Command(ProtocolName.Browser.SetPermission)]
	[SupportedBy("Chrome")]
	public class SetPermissionCommand: ICommand<SetPermissionCommandResponse>
	{
		/// <summary>
		/// Gets or setsDescriptor of permission to override.

		/// </summary>
		public PermissionDescriptor Permission { get; set; }
		/// <summary>
		/// Gets or setsSetting of the permission.

		/// </summary>
		public string Setting { get; set; }
		/// <summary>
		/// Gets or setsOrigin the permission applies to, all origins if not specified.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Origin { get; set; }
		/// <summary>
		/// Gets or setsContext to override. When omitted, default browser context is used.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string BrowserContextId { get; set; }
	}
}
