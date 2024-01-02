using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	[SupportedBy("Chrome")]
	public class AttributionReportingAggregatableTriggerData
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string KeyPiece { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string[] SourceKeys { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public AttributionReportingFilterPair Filters { get; set; }
	}
}
