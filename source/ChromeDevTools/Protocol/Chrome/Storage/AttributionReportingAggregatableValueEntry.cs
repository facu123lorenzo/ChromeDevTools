using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	[SupportedBy("Chrome")]
	public class AttributionReportingAggregatableValueEntry
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string Key { get; set; }
		/// <summary>
		/// Gets or setsnumber instead of integer because not all uint32 can be represented by
		/// int

		/// </summary>
		public double Value { get; set; }
	}
}
