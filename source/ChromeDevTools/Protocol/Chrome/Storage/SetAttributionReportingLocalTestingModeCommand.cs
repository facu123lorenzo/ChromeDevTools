using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	///https://wicg.github.io/attribution-reporting-api/

	/// </summary>
	[Command(ProtocolName.Storage.SetAttributionReportingLocalTestingMode)]
	[SupportedBy("Chrome")]
	public class SetAttributionReportingLocalTestingModeCommand: ICommand<SetAttributionReportingLocalTestingModeCommandResponse>
	{
		/// <summary>
		/// Gets or setsIf enabled, noise is suppressed and reports are sent immediately.

		/// </summary>
		public bool Enabled { get; set; }
	}
}
