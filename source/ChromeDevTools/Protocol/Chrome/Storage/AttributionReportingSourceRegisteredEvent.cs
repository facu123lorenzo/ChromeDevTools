using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	[Event(ProtocolName.Storage.AttributionReportingSourceRegistered)]
	[SupportedBy("Chrome")]
	public class AttributionReportingSourceRegisteredEvent
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public AttributionReportingSourceRegistration Registration { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public AttributionReportingSourceRegistrationResult Result { get; set; }
	}
}
