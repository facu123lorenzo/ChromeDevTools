using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	[SupportedBy("Chrome")]
	public class AttributionReportingFilterPair
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public AttributionReportingFilterConfig[] Filters { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public AttributionReportingFilterConfig[] NotFilters { get; set; }
	}
}
