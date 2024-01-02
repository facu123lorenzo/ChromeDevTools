using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Browser
{
	/// <summary>
	///Allows a site to use privacy sandbox features that require enrollment
	/// without the site actually being enrolled. Only supported on page targets.

	/// </summary>
	[Command(ProtocolName.Browser.AddPrivacySandboxEnrollmentOverride)]
	[SupportedBy("Chrome")]
	public class AddPrivacySandboxEnrollmentOverrideCommand: ICommand<AddPrivacySandboxEnrollmentOverrideCommandResponse>
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string Url { get; set; }
	}
}
